using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class Role
	{
		int id;
		public string name;
//		public string password;
		Permissions permissions = new Permissions();
		public int watchingGroupId;

		public int Id { get { return id; } }
		public bool IsAdmin { get { return id == 1 || id == 2; } }
		public Permissions Permissions { get { return permissions; } }
		public bool HasPermission(PermissionId p) { return IsAdmin ? true : permissions.HasPermission(p); }
		public void SetPermission(PermissionId p) { permissions.SetPermission(p); }

		public static Role GetRole(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("select * from Roles where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Role(dr);
			}
			return null;
		}
		public static void GetRoles(GmConnection conn, Dictionary<int,Role> roles)
		{
			GmCommand cmd = conn.CreateCommand("select * from Roles");
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				while (dr.Read())
				{
					Role role = new Role(dr);
					roles.Add(role.id,role);
				}
			}
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Roles where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}

		public Role()
			: this(0)
		{
		}
		public Role(int id)
		{
			this.id = id;
			name = "";
//			password = "";
			watchingGroupId = 0;
		}
		public Role(DbDataReader dr)
		{
			//		GmDataReader gr = new GmDataReader(dr);
			int i = 0;
			id = dr.GetInt32(i++);
			name = dr.GetString(i++);
			permissions.Read(dr, i++);
			watchingGroupId = dr.GetInt32(i++);
		}
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("Name", name);
			cmd.AddBinary("Permissions", permissions.GetBytes());
			cmd.AddInt("WatchingGroupId", watchingGroupId);
			if (id == 0)
			{
				cmd.CommandText = "insert into Roles values (@Name,@Permissions,@WatchingGroupId) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Roles set Name=@Name, Permissions=@Permissions, WatchingGroupId=@WatchingGroupId where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
	}
}