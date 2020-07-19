using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class TaskManager
	{
        UserInfo userInfo;
        Config config;
        DepartmentConfig depConfig;
        List<Task> taskList = new List<Task>();
        AppCache appCache;

        #region Construction
        public TaskManager(UserInfo userInfo, Config config, AppCache appCache)
		{
            this.userInfo = userInfo;
            this.config = config;
            this.depConfig = config.departmentConfig;
            this.appCache = appCache;
        }
        #endregion

        public List<Task> TaskList { get { return taskList; } }
        public void UpdateTaskList(GmConnection conn)
        {
            lock (taskList)
            {
                taskList.Clear();
                if (userInfo.HasWatching && userInfo.HasPermission(PermissionId.PatientAdmission))
                {
                    CheckPatients(conn);
                }
            }
        }

        private void CheckPatients(GmConnection conn)
        {
            string cond="DischargeDate is null";
            cond+= string.Format(" and Patients.Id in ({0})", userInfo.Watching.GetCommaSeparatedPatientList());
            List<Patient> patients = Patient.GetPatients(conn, cond);

            CheckDuration(conn, patients);
            CheckClinicDiagnosis(conn, patients);
            CheckObservations(conn, patients);
        }

        private void CheckDuration(GmConnection conn, List<Patient> patients)
        {
            string cmdText = @"SELECT PatientWardHistory.PatientId, MAX(PatientWardHistory.Date) AS PatientWardHistoryDate
FROM PatientWardHistory 
LEFT OUTER JOIN Patients ON Patients.Id = PatientWardHistory.PatientId AND Patients.PatientTypeId = PatientWardHistory.PatientTypeId";
            cmdText += string.Format(" where (PatientWardHistory.PatientTypeId={0} or PatientWardHistory.PatientTypeId={1}) and PatientWardHistory.PatientId in ({2})", (int)PatientTypeId.IntensiveCare, (int)PatientTypeId.Reanimation, GetCommaSeparatedList(patients));
            cmdText += " GROUP BY PatientWardHistory.PatientId";
            Dictionary<int,DateTime> transferDates=new Dictionary<int,DateTime>();
            using (DbDataReader dr = conn.ExecuteReader(cmdText)) while (dr.Read()) transferDates.Add(dr.GetInt32(0), dr.GetDateTime(1));

            List<Patient> commonPatients = new List<Patient>();
            List<Patient> intensiveCarePatients = new List<Patient>();
            List<Patient> reanimationPatients = new List<Patient>();
            foreach (Patient patient in patients)
            {
                DateTime whenArrived = transferDates.ContainsKey(patient.Id) ?  transferDates[patient.Id] : patient.admissionDate;
                TimeSpan ts = DateTime.Now - whenArrived;
                switch(patient.patientTypeId)
                {
                    case PatientTypeId.Reanimation:
                        if (ts.TotalDays >= depConfig.reanimationMaxDuration)
                        {
                            reanimationPatients.Add(patient);
                        }
                        break;
                    case PatientTypeId.IntensiveCare:
                        if (ts.TotalDays >= depConfig.intensiveCareMaxDuration)
                        {
                            intensiveCarePatients.Add(patient);
                        }
                        break;
                    case PatientTypeId.Common:
                        DiagnosisInfo di = patient.LatestDiagnosisInfo;
                        if (di!=null)
                        {
                            Diagnosis d = appCache.GetDiagnosis(di.id);
                            if (d != null)
                            {
                                int hospitalStay = depConfig.GetRecommendedHospitalStay(d);
                                if (ts.TotalDays >= hospitalStay)
                                {
                                    commonPatients.Add(patient);
                                }
                            }
                        }
                        break;
                }
            }
            AddTask(TaskTypeId.CommonDuration, commonPatients);
            AddTask(TaskTypeId.IntensiveCareDuration, intensiveCarePatients);
            AddTask(TaskTypeId.ReanimationDuration, reanimationPatients);
        }

        private void AddTask(TaskTypeId taskTypeId, List<Patient> patients)
        {
            if (patients.Count > 0)
            {
                TaskType taskType = config.GetTaskType(taskTypeId);
                Task task = new Task(taskType, "Номера пациентов: " + GetCommaSeparatedList(patients));
                this.taskList.Add(task);
            }
        }

        string GetCommaSeparatedList(List<Patient> patients)
        {
            List<int> patientIds = new List<int>();
            foreach (Patient patient in patients) patientIds.Add(patient.Id);
            return CollectionUtils.GetCommaSeparatedList(patientIds);
        }

        private void CheckClinicDiagnosis(GmConnection conn, List<Patient> patients)
        {
            List<Patient> patientsWithoutClinicDiagnosis = new List<Patient>();
            foreach (Patient patient in patients)
            {
                if (patient.patientDiagnoses.clinicalDiagnosis.IsEmpty)
                {
                    TimeSpan ts = DateTime.Now - patient.admissionDate;
                    if (ts.TotalHours >= depConfig.clinicDiagnosisDays)
                    {
                        patientsWithoutClinicDiagnosis.Add(patient);
                    }
                }
            }
            AddTask(TaskTypeId.SetClinicDiagnosis, patientsWithoutClinicDiagnosis);
        }


        #region Observations
        public void CheckObservations(GmConnection conn, List<Patient> patients)
        {
            string cmdText= @"SELECT PatientId, ObservationTypeId, Max(Time) as Time
FROM Observations WHERE ";
            cmdText+= string.Format(" PatientId in ({0})", userInfo.Watching.GetCommaSeparatedPatientList());
            cmdText += " group BY PatientId, ObservationTypeId";
            GmCommand cmd = conn.CreateCommand(cmdText);
            List<ObservationInfo> observations = new List<ObservationInfo>();
            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    observations.Add(new ObservationInfo(dr));
                }
            }
            CheckObservations(patients, observations, ObservationTypeId.Diary);
            CheckObservations(patients, observations, ObservationTypeId.TemperatureCard);
            CheckObservations(patients, observations, ObservationTypeId.DoctorRound);
            CheckObservations(patients, observations, ObservationTypeId.ChiefRound);
        }
        private void CheckObservations(List<Patient> patients, List<ObservationInfo> observations, ObservationTypeId observationTypeId)
        {
            List<Patient> taskPatients = new List<Patient>();
            foreach (Patient patient in patients)
            {
                ObservationInfo observationInfo = GetObservationInfo(patient.Id, observations, observationTypeId);
                DateTime prevTime = observationInfo == null ? patient.admissionDate : observationInfo.observationTime;
                DateTime nextTime = depConfig.GetNextObservationTime(observationTypeId, patient.patientTypeId, prevTime, observationInfo == null);
                if (nextTime < DateTime.Now)
                {
                    taskPatients.Add(patient);
                }
            }
            TaskTypeId taskTypeId = GetTaskTypeId(observationTypeId);
            AddTask(taskTypeId,taskPatients);
        }

        private ObservationInfo GetObservationInfo(int patientId, List<ObservationInfo> observations, ObservationTypeId observationTypeId)
        {
            foreach (ObservationInfo observationInfo in observations)
            {
                if (observationInfo.patientId == patientId && observationInfo.observationTypeId == observationTypeId) return observationInfo;
            }
            return null;
        }

        public int GetObservationPeriod(PatientTypeId patientTypeId)
        {
            switch (patientTypeId)
            {
                case PatientTypeId.Common: return depConfig.commonObservationPeriod;
                case PatientTypeId.IntensiveCare: return depConfig.intensiveCareObservationPeriod;
                case PatientTypeId.Reanimation: return depConfig.reanimationObservationPeriod;
                default: return 0;
            }
        }

        private TimeSpan GetObservationPeriod(ObservationTypeId observationTypeId, PatientTypeId patientTypeId)
        {
            switch (observationTypeId)
            {
                case ObservationTypeId.Diary:
                    return TimeSpan.FromHours(GetObservationPeriod(patientTypeId));
                case ObservationTypeId.TemperatureCard:
                    return TimeSpan.FromHours(depConfig.temperatureObservationPeriod);
                case ObservationTypeId.ChiefRound:
                    return TimeSpan.FromDays(depConfig.chiefRoundPeriod);
                case ObservationTypeId.DoctorRound:
                    return TimeSpan.FromDays(depConfig.doctorRoundPeriod);
                default:
                    return TimeSpan.Zero;
            }
        }
        private TaskTypeId GetTaskTypeId(ObservationTypeId observationTypeId)
        {
            switch (observationTypeId)
            {
                case ObservationTypeId.ChiefRound: return TaskTypeId.ChiefRound;
                case ObservationTypeId.Diary: return TaskTypeId.Diary;
                case ObservationTypeId.DoctorRound: return TaskTypeId.DoctorRound;
                case ObservationTypeId.TemperatureCard: return TaskTypeId.TemperatureCard;
            }
            return TaskTypeId.Null;
        }
        #endregion

	}

    public class ObservationInfo
    {
        public int patientId;
        public ObservationTypeId observationTypeId;
        public DateTime observationTime;
        public ObservationInfo(DbDataReader dr)
        {
            int i = 0;
            patientId = dr.GetInt32(i++);
            observationTypeId = (ObservationTypeId)dr.GetInt32(i++);
            observationTime = dr.GetDateTime(i++);
        }
    }
}
