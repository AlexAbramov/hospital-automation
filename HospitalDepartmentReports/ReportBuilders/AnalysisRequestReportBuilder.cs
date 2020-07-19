using System;
using System.Data.Common;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class AnalysisRequestReportBuilder : BaseReportBuilder
	{
        public AnalysisRequestReportBuilder(ConnectionFactory factory, Config config, Patient patient, int analysisId)
            : base(ReportBuilderId.AnalysisRequest)
		{
			AddDataSource("ReportsDataSet_AnalysisRequest", GetAnalysisRequestTable(factory, config, patient.Id, analysisId));
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("WardNumber", patient.GetWardNumber(conn));
				AddParameter("Age", patient.GetAgeStr(conn));
			}
			AddParameter("DepartmentName", config.departmentConfig.departmentName);
			AddParameter("CaseHistoryNumber", patient.patientData);
		}

        public static ReportsDataSet.AnalysisRequestDataTable GetAnalysisRequestTable(ConnectionFactory factory, Config config, int patientId, int analysisId)
		{
			DataTable dataTable = new DataTable();
			string cmdText = @"
select Code, AnalysisTypes.Name as AnalysisTypeName, RequestDate
from Analyses
left join AnalysisTypes on AnalysisTypes.Id=AnalysisTypeId
where ";
			cmdText += analysisId == 0 ? "PatientId=@PatientId order by RequestDate" : "AnalysisId=@AnalysisId";
			using (GmConnection conn = factory.CreateConnection())
			{
				GmCommand cmd = new GmCommand(conn,cmdText);
				cmd.AddInt("PatientId", patientId);
				cmd.AddInt("AnalysisId", analysisId);
				cmd.Fill(dataTable);
			}
			ReportsDataSet.AnalysisRequestDataTable dtAnalysisRequest = new ReportsDataSet.AnalysisRequestDataTable();
			foreach (DataRow dr in dataTable.Rows)
			{
				ReportsDataSet.AnalysisRequestRow row = dtAnalysisRequest.NewAnalysisRequestRow();
				row.AnalysisCode = (string)dr["Code"];
				row.AnalysisName= (string)dr["AnalysisTypeName"];
				row.RequestDate = ((DateTime)dr["RequestDate"]).ToString("dd.MM.yy");
				dtAnalysisRequest.AddAnalysisRequestRow(row);
			}
			return dtAnalysisRequest;
		}
	}
}
