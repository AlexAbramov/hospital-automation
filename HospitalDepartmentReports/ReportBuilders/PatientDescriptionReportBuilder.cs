using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class PatientDescriptionReportBuilder : BaseReportBuilder
	{
        public PatientDescriptionReportBuilder(ConnectionFactory factory, Config config, Patient patient)
            : base(ReportBuilderId.PatientDescription)
		{
			AddDataSource("ReportsDataSet_Prescriptions", PrescriptionsReportBuilder.GetPrescriptionsTable(factory, patient.Id));
			AddHandbooksInfo(patient.patientDescription, config[HandbookGroupId.PatientDescription]);
			AddHandbooksInfo(patient.patientData, config[HandbookGroupId.PatientData]);
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("Age", patient.GetAgeStr(conn));
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				AddParameter("PatientName", patient.GetPatientName(conn));
				GenderId genderId = patient.GetGender(conn);
				AddParameter("EndingOi", GenderUtils.GetEndingOi(genderId));//2	Больн(ой) (-ая)
				AddParameter("EndingA", GenderUtils.GetEndingA(genderId));
				AddParameter("EndingGo", GenderUtils.GetEndingGo(genderId));
				AddParameter("PatientSex", GenderUtils.GetGender(genderId));
				AddParameter("Analyses", patient.GetAnalysesList(conn));
				AddParameter("Examinations", patient.GetExamination(conn));//80 Обследования
			}
			AddParameter("DescriptionTime", patient.patientData.descriptionTime, "dd.MM.yy HH:mm");//1 Дата и время жалоб
			AddParameter("AdmissionDiagnosis", patient.patientDiagnoses.admissionDiagnosis);//3	Предварительный диагноз
			AddParameter("SickListStartDate", patient.patientData.sickListStartDate);//15 Дата начала больничного
			AddParameter("DepartmentName", config.departmentConfig.departmentName);
			AddParameter("HospitalName", config.departmentConfig.hospitalName);
			AddParameter("PulseShortage", GetPulseShortage(patient.patientDescription));
			AddParameter("ECGData", patient.patientData["ECG"]);

			
		}
		public static string GetPulseShortage(PatientDescription pd)
		{
			
			try
			{
				string s = pd["Pulse"];
				if (s.Length > 0)
				{
					int ps = int.Parse(pd["HeartRate"]) - int.Parse(s);
					return ps.ToString();
				}
			}
			catch 
			{
			}
			return "";
		}
	}
}
