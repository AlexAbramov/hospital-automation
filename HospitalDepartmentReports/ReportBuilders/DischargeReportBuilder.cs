using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class DischargeReportBuilder : BaseReportBuilder
	{
        public DischargeReportBuilder(ConnectionFactory factory, Config config, Patient patient)
			: base(ReportBuilderId.Discharge)
		{
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("Age", patient.GetAgeStr(conn));
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				AddParameter("Address", patient.GetAddress(conn));
				GenderId genderId = patient.GetGender(conn);
				AddParameter("EndingOi", GenderUtils.GetEndingOi(genderId));
				AddParameter("EndingA", GenderUtils.GetEndingA(genderId));
				AddParameter("Treatment", patient.GetTreatment(conn));
				AddParameter("PatientInvestigation", patient.GetAnalysesReport(conn,config));
				AddParameter("PatientExamination", patient.GetExamination(conn));
				AddParameter("PatientStateDynamics", patient.GetPatientStateDynamics(conn));
			} 

			AddHandbooksInfo(patient.patientData, config[HandbookGroupId.PatientData]);

			AddParameter("Department", config.DepartmentFullName);
			AddParameter("AdmissionDiagnosis", patient.patientDiagnoses.admissionDiagnosis);
			AddParameter("FinalDiagnosis", patient.patientDiagnoses.finalDiagnosis);
			AddParameter("GeneralCondition", patient.patientDescription);
			AddParameter("Coverlet", patient.patientDescription);
			AddParameter("SystolicBloodPressure", patient.patientDescription);
			AddParameter("DiastolicBloodPressure", patient.patientDescription);
			AddParameter("HeartRate", patient.patientDescription);
			AddParameter("RespiratoryRate", patient.patientDescription);
			AddParameter("AdmissionDate", patient.admissionDate);
			AddParameter("DischargeDate", patient.dischargeDate);
			AddParameter("Breath", patient.patientDescription);
			AddParameter("HeartSounds", patient.patientDescription);
			AddParameter("AbdomenPalpation", patient.patientDescription);
			AddParameter("Liver", patient.patientDescription);
			AddParameter("Spleen", patient.patientDescription);
			AddParameter("LumbarKnocking", patient.patientDescription);
			AddParameter("Hypostases", patient.patientDescription);
			AddParameter("Complaints", patient.patientDescription);
			AddParameter("Pulse", patient.patientDescription);
			AddParameter("Complication", patient.patientDiagnoses.complicationDiagnosis);
			AddParameter("ÑoncomitantDiagnosis", patient.patientDiagnoses.concomitantDiagnosis);
			AddParameter("RecommendationsToCardiologist", patient.dischargeData);
		}
	}
}
