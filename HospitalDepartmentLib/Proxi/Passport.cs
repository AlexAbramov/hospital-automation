using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	/// <summary>
	/// Summary description for Passport
	/// </summary>
	public class Passport
	{
		int id = 0;
		public string serialNumber = "";
		public string issueDepartment = "";
		public DateTime issueDate = DateTime.Now;
		public string departmentCode = "";
		public string surname = "";
		public string name = "";
		public string middleName = "";
		public GenderId gender = GenderId.Male;
		public DateTime birthday = DateTime.Now;
		public string birthPlace = "";
		public string registration = "";

		public int Id { get { return id; } }
		public string PatientName { get { return surname + " " + name + " " + middleName; } }
//		public int Age { get { return DateTimeUtils.Age(birthday); } }

		//	public string IssueDateStr { get { Utils.ToString(issueDate); } set { issueDate = Utils.ToString(); } }

		#region Static
		public static Passport GetPassport(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Passports where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Passport(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Passports where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		#endregion

		#region Construction
		public Passport() : this(0) { }
		public Passport(int id)
		{
			this.id = id;
		}
		public Passport(DbDataReader dr)
		{
			int i = 0;
			id = dr.GetInt32(i++);
			serialNumber = dr.GetString(i++);
			issueDepartment = dr.GetString(i++);
			issueDate = dr.GetDateTime(i++);
			departmentCode = dr.GetString(i++);
			surname = dr.GetString(i++);
			name = dr.GetString(i++);
			middleName = dr.GetString(i++);
			gender = (GenderId)dr.GetInt32(i++);
			birthday = dr.GetDateTime(i++);
			birthPlace = dr.GetString(i++);
			registration = dr.GetString(i++);
		}
		#endregion

		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("SerialNumber", serialNumber);
			cmd.AddString("IssueDepartment", issueDepartment);
			cmd.AddDateTime("IssueDate", issueDate);
			cmd.AddString("DepartmentCode", departmentCode);
			cmd.AddString("Surname", surname);
			cmd.AddString("Name", name);
			cmd.AddString("MiddleName", middleName);
			cmd.AddInt("Gender", (int)gender);
			cmd.AddDateTime("Birthday", birthday);
			cmd.AddString("BirthPlace", birthPlace);
			cmd.AddString("Registration", registration);
			if (id == 0)
			{
				cmd.CommandText = "insert into Passports values (@SerialNumber,@IssueDepartment,@IssueDate,@DepartmentCode,@Surname,@Name,@MiddleName,@Gender,@Birthday,@BirthPlace,@Registration) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Passports set SerialNumber=@SerialNumber,IssueDepartment=@IssueDepartment,IssueDate=@IssueDate,DepartmentCode=@DepartmentCode,Surname=@Surname,Name=@Name,MiddleName=@MiddleName,Gender=@Gender,Birthday=@Birthday,BirthPlace=@BirthPlace,Registration=@Registration where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}

	}
}