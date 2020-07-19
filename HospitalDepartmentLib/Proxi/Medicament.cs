using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class Medicament
	{
		int id;
		public string name;
        public Status status = Status.Normal;

		public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public Status Status { get { return status; } set { status = value; } }
        public int StatusInt { get { return (int)status; }}

		#region Construction
		public static Medicament GetMedicament(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Medicaments where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Medicament(dr);
			}
			return null;
		}
        public static int GetMedicaments(GmConnection conn,List<Medicament> medicaments)
        {
            GmCommand cmd = conn.CreateCommand("select * from Medicaments");
            int count = 0;
            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Medicament med = new Medicament(dr);
                    medicaments.Add(med);
                    count++;
                }
            }
            return count;
        }
        public static int SetStatus(GmConnection conn, int id, Status status)
        {
            if (id != 0)
            {
                GmCommand cmd = conn.CreateCommand("update Medicaments set Status=@Status where Id=@Id");
                cmd.AddInt("Id", id);
                cmd.AddInt("Status", (int)status);
                return cmd.ExecuteNonQuery();
            }
            return 0;
        }
        public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Medicaments where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public Medicament()
		{
			id = 0;
			name = "";
		}
		public Medicament(int id)
		{
			this.id = id;
			name = "";
		}
		public Medicament(DbDataReader dr)
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
				cmd.CommandText = "insert into Medicaments values (@Name,@Status) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Medicaments set Name=@Name,Status=@Status where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}

        public void SaveStatus(GmConnection conn)
        {
            Medicament.SetStatus(conn, id, status);
        }
    }
}