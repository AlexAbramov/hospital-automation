using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class SanatoriumTransferEpicrisisReportBuilder : BaseReportBuilder
	{
        public SanatoriumTransferEpicrisisReportBuilder(ConnectionFactory factory, Config config, Patient patient)
			: base(ReportBuilderId.SanatoriumTransferEpicrisis)
		{
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("Age", patient.GetAgeStr(conn));
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				AddParameter("Address", patient.GetAddress(conn));
				AddParameter("Treatment", patient.GetTreatment(conn));
				AddParameter("PatientExamination", patient.GetExamination(conn));
			}

			AddHandbooksInfo(patient.dischargeData, config[HandbookGroupId.SanatoriumTransfer]);
			AddHandbooksInfo(patient.patientData, config[HandbookGroupId.PatientData]);
			AddHandbooksInfo(patient.patientDescription, config[HandbookGroupId.PatientDescription]);

			AddParameter("DischargeDate", patient.dischargeDate);
			AddParameter("AdmissionDate", patient.admissionDate);
			AddParameter("ClinicalDiagnosis", patient.patientDiagnoses.clinicalDiagnosis);
			AddParameter("SickListStartDate", patient.patientData.sickListStartDate);

			AddParameter("Department", config.DepartmentFullName);
			AddParameter("ConcomitantDiagnosis", patient.patientDiagnoses.concomitantDiagnosis);
	
			// unused below
			AddParameter("FinalDiagnosis", patient.patientDiagnoses.clinicalDiagnosis);
			AddParameter("Complication", patient.patientDiagnoses.complicationDiagnosis);			
			
		}
	}
}
