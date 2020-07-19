using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class PrescriptionType
	{
		#region Fields
		int id=0;
		public string name = "";
		public string shortName = "";
		#endregion

		#region Properties
		public int Id { get { return id; } }
		#endregion

		#region Construction
        public static void GetPrescriptionTypes(GmConnection conn, List<PrescriptionType> list)
        {
            GmCommand cmd = conn.CreateCommand("select * from PrescriptionTypes");
            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read()) list.Add( new PrescriptionType(dr));
            }
        }
        public static PrescriptionType GetPrescriptionType(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from PrescriptionTypes where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new PrescriptionType(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from PrescriptionTypes where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public PrescriptionType()
		{
		}
		public PrescriptionType(DbDataReader dr)
		{
//			GmDataReader gr = new GmDataReader(dr);
			int i = 0;
			id = dr.GetInt32(i++);
			name = dr.GetString(i++);
			shortName = dr.GetString(i++);
		}
		#endregion

		#region Serialization
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("Name", name);
			cmd.AddString("ShortName", shortName);
			if (id == 0)
			{
				cmd.CommandText = "insert into PrescriptionTypes values (@Name,@ShortName) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update PrescriptionTypes set Name=@Name,ShortName=@ShortName where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		#endregion

        public override string ToString()
        {
            return name;
        }
	}
}