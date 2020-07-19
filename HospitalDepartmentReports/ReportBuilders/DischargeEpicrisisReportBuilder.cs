using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class DischargeEpicrisisReportBuilder : BaseReportBuilder
	{
		public DischargeEpicrisisReportBuilder(ConnectionFactory factory, Config config, Patient patient)
			: base(ReportBuilderId.DischargeEpicrisis)
		{
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("Age", patient.GetAgeStr(conn));
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				GenderId genderId = patient.GetGender(conn);
				AddParameter("EndingOi", GenderUtils.GetEndingOi(genderId));
				AddParameter("EndingA", GenderUtils.GetEndingA(genderId));
				AddParameter("Treatment", patient.GetTreatment(conn));
				AddParameter("PatientExamination", patient.GetExamination(conn));
				AddParameter("PatientStateDynamics", patient.GetPatientStateDynamics(conn));
			}

			AddParameter("Department", config.DepartmentFullName);
			AddParameter("AdmissionDiagnosis", patient.patientDiagnoses.admissionDiagnosis);
			AddParameter("FinalDiagnosis", patient.patientDiagnoses.clinicalDiagnosis);
			AddParameter("Complication", patient.patientDiagnoses.complicationDiagnosis);
			AddParameter("GeneralCondition", patient.patientDescription);
			AddParameter("Coverlet", patient.patientDescription);
			AddParameter("SystolicBloodPressure", patient.patientDescription);
			AddParameter("DiastolicBloodPressure", patient.patientDescription);
			AddParameter("HeartRate", patient.patientDescription);
			AddParameter("RespiratoryRate", patient.patientDescription);
			
		}
	}
}
