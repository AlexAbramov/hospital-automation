using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class MedicamentGroup
	{
		int id;
		public string name;
        public Status status = Status.Normal;

        public int Id { get { return id; } }
        #region Construction
		public static MedicamentGroup GetMedicamentGroup(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from MedicamentGroups where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new MedicamentGroup(dr);
			}
			return null;
		}
        public static int SetStatus(GmConnection conn, int id, Status status)
        {
            GmCommand cmd = conn.CreateCommand("update MedicamentGroups set Status=@Status where Id=@Id");
            cmd.AddInt("Id", id);
            cmd.AddInt("Status", (int)status);
            return cmd.ExecuteNonQuery();
        }
        public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from MedicamentGroups where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public MedicamentGroup()
		{
			id = 0;
			name = "";
		}
		public MedicamentGroup(int id)
		{
			this.id = id;
			name = "";
		}
		public MedicamentGroup(DbDataReader dr)
		{
			int i = 0;
			id = dr.GetInt32(i++);
			name = dr.GetString(i++);
            status = (Status)dr.GetInt32(i++);
        }
		#endregion

		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("Name", name);
            cmd.AddInt("Status", (int)status);
            if (id == 0)
			{
				cmd.CommandText = "insert into MedicamentGroups values (@Name,@Status) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update MedicamentGroups set Name=@Name, Status=@Status where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
	}
}