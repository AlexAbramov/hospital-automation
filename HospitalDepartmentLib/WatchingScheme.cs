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
	public class WatchingScheme
	{
		#region Fields
		int id = 0;
		public int userId=0;
		public string name="";
		WatchingSchemeData data = new WatchingSchemeData();
		#endregion

		#region Properties
		public int Id { get { return id; } }
		public string Name { get { return name; } }
		#endregion 

		#region Construction
		public WatchingScheme(int userId)
		{
			this.userId = userId;
		}
		public WatchingScheme(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
			int i = 0;
			id = dr.GetInt32(i++);
			userId = dr.GetInt32(i++);
			name = dr.GetString(i++);
			data = WatchingSchemeData.Create(gr.GetString(i++));
		}
		public static WatchingScheme GetWatchingScheme(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from WatchingSchemes where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new WatchingScheme(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from WatchingSchemes where Id=@Id");
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
			cmd.AddString("Name", name);
			cmd.AddString("Data", data.GetXmlString());
			
			if (id == 0)
			{
				cmd.CommandText = "insert into WatchingSchemes values (@UserId,@Name,@Data) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update WatchingSchemes set UserId=@UserId,Name=@Name,Data=@Data where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		#endregion

		public bool UpdateWard(int wardId, bool present)
		{
			if (data.wards.Contains(wardId))
			{
				if (!present)
				{
					data.wards.Remove(wardId);
					return true;
				}
			}
			else
			{
				if (present)
				{
					data.wards.Add(wardId);
					return true;
				}
			}
			return false;
		}

		public bool HasWard(int wardId)
		{
			return data.wards.Contains(wardId);
		}
	}
}