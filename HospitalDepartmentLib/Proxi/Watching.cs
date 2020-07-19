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
	public class Watching
	{
		#region Fields
		int id = 0;
		public int userId=0;
		public DateTime startTime = DateTime.Now;
		public DateTime endTime = DateTime.MinValue;
		WatchingData data = new WatchingData();
		#endregion

		#region Properties
		public int Id { get { return id; } }
		public bool IsCompleted { get { return endTime!=DateTime.MinValue; } }
        public bool IsEmpty { get { return data.patients.Count == 0; } }
        public IEnumerable<int> Patients { get { return data.patients; } }
        #endregion 

		#region Construction
		public Watching(int userId)
		{
			this.userId = userId;
		}
		public Watching(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
			id = gr.GetInt32();
			userId = gr.GetInt32();
			startTime = gr.GetDateTime();
			endTime = gr.GetDateTime();
			data = WatchingData.DeserializeString(gr.GetString());
		}
		public static Watching GetWatching(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Watching where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Watching(dr);
			}
			return null;
		}
		public static Watching GetLastTakingWatching(GmConnection conn, int userId)
		{
			GmCommand cmd = conn.CreateCommand("select top 1 * from Watching where UserId=@UserId and EndTime is null");
			cmd.AddInt("UserId", userId);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Watching(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Watchings where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		#endregion

		#region Serialization
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("UserId", userId);
			cmd.AddDateTime("StartTime", startTime);
			cmd.AddNullableDateTime("EndTime", endTime);
			cmd.AddString("Data", data.Serialize());
			
			if (id == 0)
			{
				cmd.CommandText = "insert into Watching values (@UserId,@StartTime,@EndTime,@Data) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Watching set UserId=@UserId,StartTime=@StartTime,EndTime=@EndTime,Data=@Data where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		public void SaveEndTime(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddNullableDateTime("EndTime", endTime);

			if (id != 0)
			{
				cmd.CommandText = "update Watching set EndTime=@EndTime where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		#endregion

		#region Methods
		public bool HasWard(int wardId)
		{
			return data.wards.Contains(wardId);
		}
		public bool HasPatient(int patientId)
		{
			return data.patients.Contains(patientId);
		}

		public void Clear()
		{
			data.wards.Clear();
			data.patients.Clear();
		}

		public void AddWard(int id)
		{
			data.wards.Add(id);
		}

		public void AddPatient(int id)
		{
			data.patients.Add(id);
		}
		public string GetCommaSeparatedPatientList() 
		{
            return Geomethod.CollectionUtils.GetCommaSeparatedList(data.patients,",");
		}
		#endregion
	}
}