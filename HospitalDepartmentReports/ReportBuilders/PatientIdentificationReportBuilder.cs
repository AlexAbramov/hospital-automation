using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class PatientIdentificationReportBuilder : BaseReportBuilder
	{
        public PatientIdentificationReportBuilder(ConnectionFactory factory, Config config, Patient patient)
            : base(ReportBuilderId.PatientIdentification)
		{
			AddDataSource("ReportsDataSet_Dummy", new ReportsDataSet.DummyDataTable());
			PatientIdentification patientIdentification;
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				patientIdentification = patient.GetPatientIdentification(conn);
			}
			if (patientIdentification == null) patientIdentification = new PatientIdentification();
			AddHandbooksInfo(patientIdentification.identificationData, config[HandbookGroupId.PatientIdentification]);
			AddParameter("PatientName", patientIdentification.PatientName);
			AddParameter("Birthday", patientIdentification.birthday);
			AddParameter("Date", DateTime.Today.ToString("dd.MM.yy"));
			AddParameter("DepartmentFullName", config.DepartmentFullName);
			AddParameter("AdmissionDate", patient.admissionDate.ToString("dd.MM.yy"));
            AddParameter("LPUChief", config.departmentConfig.headDoctor);//ֳכאגםûי גנאק ֻֿ׃            
			base.ReplaceEmptyStrings("-");
		}
	}
}
