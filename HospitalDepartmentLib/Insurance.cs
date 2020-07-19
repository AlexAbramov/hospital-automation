using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class Insurance
	{
		int id;
		public int insuranceCompanyId = 0;
		public string number="";
		public string series="";
		public string delo="";

		public int Id { get { return id; } }

		#region Construction
		public static Insurance GetInsurance(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Insurances where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Insurance(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Insurances where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public Insurance()
		{
			id = 0;
		}
		public Insurance(DbDataReader dr)
		{
			int i = 0;
			id = dr.GetInt32(i++);
			insuranceCompanyId = dr.GetInt32(i++);
			number = dr.GetString(i++);
			series = dr.GetString(i++);
			delo = dr.GetString(i++);
		}
		#endregion

        public string GetInsuranceCompanyName(GmConnection conn)
        {
            GmCommand cmd = conn.CreateCommand("select Name from InsuranceCompanies where Id=@Id");
            cmd.AddInt("Id", insuranceCompanyId);
            using (DbDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read()) return dr.GetString(0);
            }
            return "";
        }

		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("InsuranceCompanyId", insuranceCompanyId);
			cmd.AddString("Number", number);
			cmd.AddString("Series", series);
			cmd.AddString("Delo", delo);
			if (id == 0)
			{
				cmd.CommandText = "insert into Insurances values (@InsuranceCompanyId,@Number,@Series,@Delo) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Insurances set InsuranceCompanyId=@InsuranceCompanyId,Number=@Number,Series=@Series,Delo=@Delo where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
	}
}