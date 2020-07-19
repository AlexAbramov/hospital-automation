using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class Diagnosis
	{
		int id=0;
		public string code="";
		public string name="";
		public int hospitalStayHigh=0;
		public int hospitalStayFirst=0;
		public int hospitalStaySecond=0;
		public int hospitalStayDay=0;
		public string mcode = "";

		public int Id { get { return id; } }

		#region Construction
		public static Diagnosis GetDiagnosis(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Diagnoses where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Diagnosis(dr);
			}
			return null;
		}
        public static int GetDiagnoses(GmConnection conn, Dictionary<int, Diagnosis> diagnoses)
        {
            GmCommand cmd = conn.CreateCommand("select * from Diagnoses");
//            cmd.AddInt("Id", id);
            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Diagnosis diagnosis = new Diagnosis(dr);
                    diagnoses.Add(diagnosis.Id, diagnosis);
                }
            }
            return diagnoses.Count;
        }
        public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Diagnoses where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public Diagnosis()
		{
		}
		public Diagnosis(DbDataReader dr)
		{
			int i = 0;
			id = dr.GetInt32(i++);
			code = dr.GetString(i++);
			name = dr.GetString(i++);
			hospitalStayHigh = dr.GetInt32(i++);
			hospitalStayFirst = dr.GetInt32(i++);
			hospitalStaySecond = dr.GetInt32(i++);
			hospitalStayDay = dr.GetInt32(i++);
			mcode = dr.GetString(i++);
		}
		#endregion

		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("Code", code);
			cmd.AddString("Name", name);
			cmd.AddInt("HospitalStayHigh", hospitalStayHigh);
			cmd.AddInt("HospitalStayFirst", hospitalStayFirst);
			cmd.AddInt("HospitalStaySecond", hospitalStaySecond);
			cmd.AddInt("HospitalStayDay", hospitalStayDay);
			cmd.AddString("MCode", code);
			if (id == 0)
			{                
				cmd.CommandText = "insert into Diagnoses values (@Code,@Name,@HospitalStayHigh,@HospitalStayFirst,@HospitalStaySecond,@HospitalStayDay,@MCode) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Diagnoses set Code=@Code,Name=@Name,HospitalStayHigh=@HospitalStayHigh,HospitalStayFirst=@HospitalStayFirst,HospitalStaySecond=@HospitalStaySecond,HospitalStayDay=@HospitalStayDay,MCode=@MCode where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}

		public int GetHospitalStayDuration(HospitalType hospitalType)
		{
			switch (hospitalType)
			{
				case HospitalType.Day: return hospitalStayDay;
				case HospitalType.First: return hospitalStayFirst;
				case HospitalType.High: return hospitalStayHigh;
				case HospitalType.Second: return hospitalStaySecond;
			}
			return 0;
		}
	}
}