using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class User
	{
		int id;
		public string name;
		public int roleId;
		public string login;
		public string password;
		public int Id { get { return id; } }
		Permissions permissions = new Permissions();
		public bool HasPermission(PermissionId p) { return permissions.HasPermission(p); }
		public Permissions Permissions { get { return permissions; }}
		public string NonEmptyName { get { return name.Length > 0 ? name : id.ToString(); } }

		public static User GetUser(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Users where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new User(dr);
			}
			return null;
		}
		public static User GetUser(GmConnection conn, string login)
		{
			GmCommand cmd = conn.CreateCommand("select * from Users where Login=@Login");
			cmd.AddString("Login", login);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new User(dr);
			}
			return null;
		}
		public static void GetUsers(GmConnection conn, Dictionary<int, User> users)
		{
			GmCommand cmd = conn.CreateCommand("select * from Users");
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				while (dr.Read())
				{
					User user= new User(dr);
					users.Add(user.Id, user);
				}
			}
		}
		public static User GetUser(GmConnection conn, string login, string password)
		{
			GmCommand cmd = conn.CreateCommand("select * from Users where Login=@Login and Password=@Password");
			cmd.AddString("Login", login);
			cmd.AddString("Password", password);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new User(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Users where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public User()
			: this(0)
		{
		}
		public User(int id)
		{
			this.id = id;
			name = "";
			roleId = 0;
			login = "";
			password = "";
		}
		public User(DbDataReader dr)
		{
			int i = 0;
			id = dr.GetInt32(i++);
			name = dr.GetString(i++);
			roleId = dr.GetInt32(i++);
			login = dr.GetString(i++);
			password = dr.GetString(i++);
			permissions.Read(dr, i++);
		}
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("Name", name);
			cmd.AddInt("RoleId", roleId);
			cmd.AddString("Login", login);
			cmd.AddString("Password", password);
			cmd.AddBinary("Permissions").Value = permissions.Count == 0 ? (object)DBNull.Value : (object)permissions.GetBytes();
			if (id == 0)
			{
				cmd.CommandText = "insert into Users values (@Name,@RoleId,@Login,@Password,@Permissions) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				string pswCmdText = password.Trim().Length == 0 ? "" : ",Password=@Password";
				cmd.CommandText = string.Format("update Users set Name=@Name,RoleId=@RoleId,Login=@Login{0},Permissions=@Permissions where Id=@Id", pswCmdText);
				cmd.ExecuteNonQuery();
			}
		}

		#region Aux
		public static string GetUserNameById(GmConnection conn, int id)
		{
			if (id == 0) return "";
			object obj = conn.ExecuteScalar("select Name from Users where Id=" + id);
			return obj is string ? obj.ToString() : "";
		}
		public static string GetChiefName(GmConnection conn)
		{
			object obj = conn.ExecuteScalar("select Name from Users where RoleId=" + (int)RoleId.Chief);
			return obj is string ? obj.ToString() : "";
		}
		#endregion


	}
}