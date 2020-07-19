using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class ExpertBoardReportBuilder : BaseReportBuilder
	{
        public ExpertBoardReportBuilder(ConnectionFactory factory, Config config, Patient patient, ExpertBoard expertBoard)
			: base(ReportBuilderId.ExpertBoard)
		{
			AddParameter("SickListStartDate", patient.patientData.sickListStartDate);
			AddParameter("AdmissionDate", patient.admissionDate);
			AddParameter("Date", expertBoard.date);
			AddParameter("Diagnosis", expertBoard.expertBoardData.diagnosisInfo);
			AddParameter("DiagnosisCode", expertBoard.expertBoardData.diagnosisInfo.code);
			using (GmConnection conn = factory.CreateConnection())
			{
				Diagnosis d=expertBoard.expertBoardData.diagnosisInfo.GetDiagnosis(conn);
				AddParameter("MCode", d.mcode);
			}
		}
	}
}
