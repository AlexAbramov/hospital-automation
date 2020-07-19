using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class Analysis
	{
		#region Static
		public static Analysis GetAnalysis(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Analyses where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Analysis(dr);
			}
			return null;
		}
		public static Analysis GetLastAnalysis(GmConnection conn, int patientId, string handbookGroupId)
		{
			if (patientId != 0)
			{
				string cmdText = @"SELECT TOP (1) *
FROM Analyses 
LEFT OUTER JOIN AnalysisTypes ON Analyses.AnalysisTypeId = AnalysisTypes.Id
WHERE (AnalysisTypes.HandbookGroupId = @HandbookGroupId) AND (Analyses.PatientId = @PatientId)
ORDER BY Analyses.ExecutionDate desc";

				GmCommand cmd = conn.CreateCommand(cmdText);
				cmd.AddInt("PatientId", patientId);
				cmd.AddString("HandbookGroupId", handbookGroupId);
				using (DbDataReader dr = cmd.ExecuteReader())
				{
					if (dr.Read()) return new Analysis(dr);
				}
			}
			return null;
		}
		public static List<Analysis> GetAnalyses(GmConnection conn, int patientId)
		{
			List<Analysis> list = new List<Analysis>();
			GmCommand cmd = conn.CreateCommand("select * from Analyses where PatientId=@PatientId");
			cmd.AddInt("PatientId", patientId);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				list.Add(new Analysis(dr));
			}
			return list;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Analyses where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		#endregion

		#region Fields
		int id=0;
		public int patientId = 0;
		public int analysisTypeId = 0;
		public DateTime requestDate = DateTime.Now;
		public DateTime executionDate = DateTime.MinValue;
		public AnalysisData analysisData=new AnalysisData();
		#endregion

		#region Properties
		public int Id { get { return id; } }
		#endregion

		#region Construction
		public Analysis(int patientId, int analysisTypeId)
		{
			this.patientId = patientId;
			this.analysisTypeId = analysisTypeId;
		}
		public Analysis(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
			id = gr.GetInt32();
			patientId = gr.GetInt32();
			analysisTypeId = gr.GetInt32();
			requestDate = gr.GetDateTime();
			executionDate = (DateTime)gr.GetDateTime();
			analysisData = AnalysisData.DeserializeString(gr.GetString());
		}
		public Analysis(DataRow dr)
		{
			int i = 0;
			id = dr.IsNull(i) ? 0 : (int)dr[i]; i++;
			patientId = (int)dr[i++];
			analysisTypeId = (int)dr[i++];
			requestDate = (DateTime)dr[i++];
			executionDate = DateTimeUtils.GetNullableTime(dr[i++]);
			analysisData = AnalysisData.DeserializeString((string)dr[i++]);
		}
		#endregion

		#region Serialization
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("PatientId", patientId);
			cmd.AddInt("AnalysisTypeId", analysisTypeId);
			cmd.AddDateTime("RequestDate", requestDate);
			cmd.AddNullableDateTime("ExecutionDate", executionDate);
			cmd.AddString("AnalysisData", analysisData.GetXmlString());
			if (id == 0)
			{
				cmd.CommandText = "insert into Analyses values (@PatientId,@AnalysisTypeId,@RequestDate,@ExecutionDate,@AnalysisData) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Analyses set PatientId=@PatientId,AnalysisTypeId=@AnalysisTypeId,RequestDate=@RequestDate,ExecutionDate=@ExecutionDate,AnalysisData=@AnalysisData where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		#endregion

		#region Methods
		public AnalysisType GetAnalysisType(GmConnection conn)
		{
			return AnalysisType.GetAnalysisType(conn, analysisTypeId);
		}
		#endregion
	}
}