using System;
using System.Data.Common;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class ObservationsReportBuilder : BaseReportBuilder
	{
        string pathologies = "";
        public ObservationsReportBuilder(ConnectionFactory factory, Config config, Patient patient)
            : base(ReportBuilderId.Observations)
		{
			AddDataSource("ReportsDataSet_Observations", GetObservationsTable(factory, patient.Id, config, ref pathologies));
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				AddParameter("Analyses", patient.GetAnalysesList(conn));
			}
			AddParameter("AdmissionDiagnosis", patient.patientDiagnoses.admissionDiagnosis);
			AddParameter("ClinicalDiagnosis", patient.patientDiagnoses.clinicalDiagnosis);
			AddParameter("DepartmentName", config.DepartmentFullName);
			AddParameter("AdmissionDate", patient.admissionDate, "dd.MM.yy HH:mm");
			AddParameter("Pathologies", pathologies);
		}

        public static ReportsDataSet.ObservationsDataTable GetObservationsTable(ConnectionFactory factory, int patientId, Config config, ref string pathologies)
		{
			DataTable dataTable = new DataTable();
			string cmdText = @"
select Observations.*, Users.Name as DoctorName
from Observations
left join Users on Users.Id=DoctorId
where PatientId=" + patientId+" order by Time";
			using (GmConnection conn = factory.CreateConnection())
			{
				conn.Fill(dataTable, cmdText);
			}
			ReportsDataSet.ObservationsDataTable dtObservations = new ReportsDataSet.ObservationsDataTable();
			using(DbDataReader dr = dataTable.CreateDataReader())
			{
				while (dr.Read())
				{
					Observation observation = new Observation(dr);
					string doctorName = (string)dr["DoctorName"];
					ReportsDataSet.ObservationsRow row=dtObservations.NewObservationsRow();
					foreach (Handbook hb in config[HandbookGroupId.Observation].GetAllHandbooks())
					{
						if (hb.visible && dtObservations.Columns.Contains(hb.id))
							row[hb.id]=observation.description[hb.id];
					}
					row.Date = observation.time.ToString("dd.MM.yy");
					row.Time = observation.time.ToString("HH:mm");
					row.DoctorName = doctorName;
					row.ObservationTypeId = (int)observation.observationTypeId;
					dtObservations.AddObservationsRow(row);
                    if (observation.observationTypeId == ObservationTypeId.DoctorRound)
                    {
                        string s=observation.description["Pathologies"];
                        if (!String.IsNullOrEmpty(s)) pathologies = s;
                    }
				}
			}
			return dtObservations;
		}

        public static Dictionary<DateTime, ObservationData> GetObservationData(ConnectionFactory factory, int patientId, ObservationTypeId observationTypeId, DateTime startTime, DateTime endTime)
		{
			Dictionary<DateTime, ObservationData> dict = new Dictionary<DateTime, ObservationData>();
			string cmdText = @"select Time, Description
from Observations 
where PatientId=@PatientId 
and Time>=@StartTime
and Time<@EndTime
and ObservationTypeId=@ObservationTypeId
order by Time";
			using (GmConnection conn = factory.CreateConnection())
			{
				GmCommand cmd=conn.CreateCommand(cmdText);
				cmd.AddInt("PatientId", patientId);
				cmd.AddDateTime("StartTime", startTime);
				cmd.AddDateTime("EndTime", endTime);
				cmd.AddInt("ObservationTypeId", (int)observationTypeId);
				using (DbDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DateTime dt = dr.GetDateTime(0);
						if (!dr.IsDBNull(1))
						{
							string xmlStr = dr.GetString(1);
							if (xmlStr.Length>0)
							{
								ObservationData rd = ObservationData.Create(xmlStr);
								dict[dt] = rd;
							}
						}
					}
				}
			}
			return dict;
		}
	}
}
