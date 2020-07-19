using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;
using Geomethod;
using System.IO;
using System.Xml.Serialization;

namespace HospitalDepartment
{
	public class WatchingList:IEnumerable<Watching>
	{
		#region Fields
		List<Watching> list=new List<Watching>();
		DateTime time = DateTime.Now;
		#endregion

		#region Properties
		public DateTime Time { get { return time; } }
		#endregion 

		#region Construction
		public WatchingList()
		{
		}
		#endregion

		#region Methods
		public int UpdateList(GmConnection conn, int roleId)
		{
			GmCommand cmd = conn.CreateCommand("select Watching.* from Watching left join Users on Users.Id=UserId where RoleId=@RoleId and EndTime is null");
			cmd.AddInt("RoleId", roleId);
			int count = 0;
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				while (dr.Read())
				{
					Watching watching = new Watching(dr);
					list.Add(watching);
					count++;
				}
			}
			return count;
		}
		public void Clear()
		{
			list.Clear();
		}

		public bool HasPatient(int patientId)
		{
			foreach (Watching watching in list)
			{
				if (watching.HasPatient(patientId)) return true;
			}
			return false;
		}

		#endregion

		#region IEnumerable<Watching> Members

		public IEnumerator<Watching> GetEnumerator()
		{
			return list.GetEnumerator();
		}

		#endregion

		#region IEnumerable Members

		IEnumerator IEnumerable.GetEnumerator()
		{
			return list.GetEnumerator();
		}

		#endregion
	}
}