using System;
using System.Data.Common;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class AnalysisResultReportBuilder : BaseReportBuilder
	{
        public AnalysisResultReportBuilder(ConnectionFactory factory, Config config, Patient patient, int analysisId)
            : base(ReportBuilderId.AnalysisResult)
		{
			AddDataSource("ReportsDataSet_AnalysisResult", GetAnalysisResultTable(factory, config, patient.Id, analysisId));
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("WardNumber", patient.GetWardNumber(conn));
			}
			AddParameter("DepartmentName", config.departmentConfig.departmentName);
		}

        public static ReportsDataSet.AnalysisResultDataTable GetAnalysisResultTable(ConnectionFactory factory, Config config, int patientId, int analysisId)
		{
			DataTable dataTable = new DataTable();
			string cmdText = @"
select Code, AnalysisTypes.Name as AnalysisTypeName, ExecutionDate, AnalysisData, HandbookGroupId
from Analyses
left join AnalysisTypes on AnalysisTypes.Id=AnalysisTypeId
where ExecutionDate is not null and ";
			cmdText += analysisId == 0 ? "PatientId=@PatientId order by ExecutionDate" : "AnalysisId=@AnalysisId";
			using (GmConnection conn = factory.CreateConnection())
			{
				GmCommand cmd = new GmCommand(conn,cmdText);
				cmd.AddInt("PatientId", patientId);
				cmd.AddInt("AnalysisId", analysisId);
				cmd.Fill(dataTable);
			}
			ReportsDataSet.AnalysisResultDataTable dtAnalysisResult = new ReportsDataSet.AnalysisResultDataTable();
			foreach (DataRow dr in dataTable.Rows)
			{
				AnalysisData ad = AnalysisData.DeserializeString(dr["AnalysisData"] as string);
				ReportsDataSet.AnalysisResultRow row = dtAnalysisResult.NewAnalysisResultRow();
				row.AnalysisCode = (string)dr["Code"];
				row.AnalysisName= (string)dr["AnalysisTypeName"];
				row.ExecutionDate = ((DateTime)dr["ExecutionDate"]).ToString("dd.MM.yy");
				HandbookGroup hg = config.GetHandbookGroup((string)dr["HandbookGroupId"]);
				row.Result = ad.GetText(hg);
				dtAnalysisResult.AddAnalysisResultRow(row);
			}
			return dtAnalysisResult;
		}
	}
}
