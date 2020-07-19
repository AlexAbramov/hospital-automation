using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class Ward
	{
		int id=0;
		public string number="";
		public WardTypeId wardTypeId=WardTypeId.Common;
		public int numberOfBeds=0;

		public int Id { get { return id; } }

		#region Construction
		public static Ward GetWard(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Wards where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Ward(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Wards where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public Ward()
		{ 
		}
		public Ward(DbDataReader dr)
		{
			int i = 0;
			id = dr.GetInt32(i++);
			number = dr.GetString(i++);
			wardTypeId = (WardTypeId)dr.GetInt32(i++);
			numberOfBeds = dr.GetInt32(i++);
		}
		#endregion

		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("Number", number);
			cmd.AddInt("WardTypeId", (int)wardTypeId);
			cmd.AddInt("NumberOfBeds", numberOfBeds);
			if (id == 0)
			{
				cmd.CommandText = "insert into Wards values (@Number,@WardTypeId,@NumberOfBeds) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Wards set Number=@Number,WardTypeId=@WardTypeId,NumberOfBeds=@NumberOfBeds where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}

        public static int GetDefaultWardId(GmConnection conn)
        {
            object obj=conn.ExecuteScalar("select top 1 Id from Wards where WardTypeId="+(int)WardTypeId.Corridor);
            return obj is int ? (int)obj : 0;
        }
    }
}