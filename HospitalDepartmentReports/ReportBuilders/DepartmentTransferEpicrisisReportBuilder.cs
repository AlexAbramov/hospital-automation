using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class DepartmentTransferEpicrisisReportBuilder : BaseReportBuilder
	{
        public DepartmentTransferEpicrisisReportBuilder(ConnectionFactory factory, Config config, Patient patient)
			: base(ReportBuilderId.DepartmentTransferEpicrisis)
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

            
			AddParameter("DischargeDate", patient.dischargeDate);
			AddParameter("AdmissionDate", patient.admissionDate);
			AddParameter("Department", config.DepartmentFullName);
			AddParameter("AdmissionDiagnosis", patient.patientDiagnoses.admissionDiagnosis);
			AddParameter("FinalDiagnosis", patient.patientDiagnoses.clinicalDiagnosis);
			AddParameter("Complication", patient.patientDiagnoses.complicationDiagnosis);

            AddParameter("Complaints", patient.patientDescription);
            AddParameter("Breath", patient.patientDescription);
			AddParameter("HeartSounds", patient.patientDescription);
			AddParameter("Abdomen", patient.patientDescription);
			AddParameter("Liver", patient.patientDescription);
			AddParameter("Hypostases", patient.patientDescription);
            AddParameter("GeneralCondition", patient.patientDescription);
            AddParameter("Coverlet", patient.patientDescription);
            AddParameter("Stool", patient.patientDescription);
            AddParameter("SystolicBloodPressure", patient.patientDescription);
            AddParameter("DiastolicBloodPressure", patient.patientDescription);
            AddParameter("HeartRate", patient.patientDescription);
            AddParameter("RespiratoryRate", patient.patientDescription);
            

            AddHandbooksInfo(patient.dischargeData, config[HandbookGroupId.DepartmentTransfer]);
		}
	}
}
