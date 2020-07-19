using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

using Geomethod.Data;
namespace HospitalDepartment
{

	public class Employee
	{
		int id;
		int passportId;
		public string login;
		public string password;

		#region Construction
		public static Employee GetEmployee(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("select * from Employees where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Employee(dr);
			}
			return null;
		}
		public static Employee GetEmployee(GmConnection conn, string login, string password)
		{
			GmCommand cmd = conn.CreateCommand("select * from Employees where Login=@Login and Password=@Password");
			cmd.AddString("Login", login);
			cmd.AddString("Password", password);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Employee(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Employees where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public Employee()
		{
			id = 0;
			passportId = 0;
		}
		public Employee(DbDataReader dr)
		{
			int i = 0;
			id = dr.GetInt32(i++);
			passportId = dr.GetInt32(i++);
			login = dr.GetString(i++);
			password = dr.GetString(i++);
		}
		#endregion

		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("PassportId", passportId);
			cmd.AddString("Login", login);
			cmd.AddString("Password", password);
			if (id == 0)
			{
				cmd.CommandText = "insert into Employees values (@Id,@PassportId,@Login,@Password) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Employees set PassportId=@PassportId,Login=@Login,@Password=@Password where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
	}
}