using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class ConsultationRequestReportBuilder : BaseReportBuilder
	{
        public ConsultationRequestReportBuilder(ConnectionFactory factory, Config config, Patient patient, PatientConsultation patientConsultation)
			: base(ReportBuilderId.ConsultationRequest)
		{
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("Age", patient.GetAgeStr(conn));
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				AddParameter("WardNumber", patient.GetWardNumber(conn));
			}
			
			AddHandbooksInfo(patientConsultation.consultationData, config[HandbookGroupId.ConsultationData]);
			AddHandbooksInfo(patient.patientData, config[HandbookGroupId.PatientData]);
			
			AddParameter("DepartmentName", config.departmentConfig.departmentName);
			AddParameter("RequestDate", patientConsultation.requestDate, "dd.MM.yy");
			AddParameter("ExecutionDate", patientConsultation.executionDate, "dd.MM.yy HH:mm");
		}
	}
}
