using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace HospitalDepartment.Reports
{
	public enum ReportBuilderId { PatientDescription, Prescriptions, Observations, PatientIdentification, ConsultationRequest,ExpertBoard,
	Discharge, DischargeEpicrisis, DepartmentTransferEpicrisis, SanatoriumTransferEpicrisis, PostmortalEpicrisis,
    Reacard, AnalysisRequest, AnalysisResult, TemperatureCard, PrescriptionsOrder, PatientMedicaments}

	public interface IReportBuilder
	{
		ReportBuilderId ReportBuilderId { get;}
		Dictionary<string, object> GetDataSources();
		Dictionary<string, string> GetParameters();
	}

	public class BaseReportBuilder: IReportBuilder
	{
		public static ReportBuilderId GetReportBuilderId(string idStr) { return (ReportBuilderId)Enum.Parse(typeof(ReportBuilderId), idStr); }

		ReportBuilderId reportBuilderId;
		protected Dictionary<string, string> parameters = new Dictionary<string, string>();
		protected Dictionary<string, object> dataSources = new Dictionary<string, object>();
		public BaseReportBuilder(ReportBuilderId reportBuilderId)
		{ 
			this.reportBuilderId=reportBuilderId;
		}

		public ReportBuilderId ReportBuilderId { get{return reportBuilderId;}}

		public Dictionary<string, object> GetDataSources()
		{
			return dataSources;
		}

		public Dictionary<string, string> GetParameters()
		{
			return parameters;
		}
		public void AddParameter(string key, string val)
		{
			parameters.Add(key, val);
		}
		public void AddParameter(string key, HandbooksInfo hi)
		{
			parameters.Add(key, hi[key]);
		}
		public void AddParameter(string key, int val)
		{
			parameters.Add(key, val.ToString());
		}
		public void AddParameter(string key, DateTime val) { AddParameter(key, val, "dd.MM.yy"); }
		public void AddParameter(string key, DateTime val, string format)
		{
			parameters.Add(key, val == DateTime.MinValue ? "" : val.ToString(format));
		}
		public void AddDataSource(string key, DataTable dt)
		{
			dataSources.Add(key, dt);
		}

		protected void AddHandbooksInfo(HandbooksInfo handbooksInfo, HandbookGroup handbookGroup)
		{
			foreach (Handbook handbook in handbookGroup.GetAllHandbooks())
			{
				if (handbook.handbookType != HandbookType.Header)
					AddParameter(handbook.id, handbooksInfo[handbook.id]);
			}
		}

		protected void ReplaceEmptyStrings(string s)
		{
			ArrayList ar = new ArrayList(parameters);
			foreach (KeyValuePair<string, string> pair in ar)
			{
				if (pair.Value.Trim().Length == 0)
				{
					parameters[pair.Key] = s;
				}
			}
		}
	}

}
