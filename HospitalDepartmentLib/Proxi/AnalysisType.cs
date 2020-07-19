using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class AnalysisType
	{
		#region Fields
		int id=0;
		public string name = "";
		public string code = "";
		public string handbookGroupId = "";
		#endregion

		#region Properties
		public int Id { get { return id; } }
		#endregion

		#region Construction
		public static AnalysisType GetAnalysisType(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from AnalysisTypes where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new AnalysisType(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from AnalysisTypes where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public AnalysisType()
		{
		}
		public AnalysisType(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
			id = gr.GetInt32();
			name = gr.GetString();
			code = gr.GetString();
			handbookGroupId = gr.GetString();
		}
		#endregion

		#region Serialization
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("Name", name);
			cmd.AddString("Code", code);
			cmd.AddString("HandbookGroupId", handbookGroupId);
			if (id == 0)
			{
				cmd.CommandText = "insert into AnalysisTypes values (@Name,@Code,@HandbookGroupId) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update AnalysisTypes set Name=@Name,Code=@Code,HandbookGroupId=@HandbookGroupId where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		#endregion
	}
}