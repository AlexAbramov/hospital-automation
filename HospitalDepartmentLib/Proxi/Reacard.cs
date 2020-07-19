using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;
using Geomethod;
using System.IO;
using System.Xml.Serialization;

namespace HospitalDepartment
{
	public class Reacard
	{
		#region Fields
		int id = 0;
		public int patientId=0;
		public DateTime date=DateTime.Now;
		public ReacardData reacardData = new ReacardData();
		#endregion

		#region Properties
		public int Id { get { return id;} }
		#endregion 

		#region Construction
		public Reacard(int patientId)
		{
			this.patientId = patientId;
		}
		public Reacard(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
			id = gr.GetInt32();
			patientId = gr.GetInt32();
			date = gr.GetDateTime();
			reacardData = ReacardData.DeserializeString(gr.GetString());
		}
		public static Reacard GetReacard(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Reacards where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Reacard(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Reacards where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		#endregion

		#region Serialization
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("PatientId", patientId);
			cmd.AddDateTime("Date", date);
			cmd.AddString("ReacardData", reacardData.GetXmlString());
			
			if (id == 0)
			{
				cmd.CommandText = "insert into Reacards values (@PatientId,@Date,@ReacardData) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Reacards set PatientId=@PatientId,Date=@Date,ReacardData=@ReacardData where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		#endregion
	}
}