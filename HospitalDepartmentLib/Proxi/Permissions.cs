using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Configuration;
using Geomethod.Data;

namespace HospitalDepartment
{
	/// <summary>
	/// Summary description for Permissions
	/// </summary>
	public class Permissions
	{
		List<int> items = new List<int>();
		public bool HasPermission(int p) { return items.Contains(p); }
		public bool HasPermission(PermissionId p) { return items.Contains((int)p); }
		public void SetPermission(int p) { if (!items.Contains(p)) items.Add(p); }
		public void SetPermission(PermissionId p) { if (!items.Contains((int)p)) items.Add((int)p); }
		public int Count { get { return items.Count; } }
		public void Clear() { items.Clear(); }

		public Permissions()
		{
		}

		public void Read(DbDataReader dr, int i)
		{
			if (dr.IsDBNull(i)) return;
			byte[] bytes = (byte[]) dr[i];
			int[] intAr = new int[bytes.Length / 4];
			Buffer.BlockCopy(bytes, 0, intAr, 0, bytes.Length);
			items.AddRange(intAr);
		}

		public byte[] GetBytes()
		{
			int[] intAr = items.ToArray();
			byte[] bytes = new byte[intAr.Length * 4];
			Buffer.BlockCopy(intAr, 0, bytes, 0, bytes.Length);
			return bytes;
		}
	}
}