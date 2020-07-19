using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment.UserControls
{
	public partial class MedicamentGroupsUserControl : UserControl
	{
		int id;
		string tableName;
		string fieldName;
		DataTable dt = new DataTable();
		DataColumn dcId;
		DataColumn dcChecked;

        public int Id { get { return id; } /*set { id = value; }*/ }
		
		public void Init(int id, string tableName, string fieldName)
		{
			this.id = id;
			this.tableName = tableName;
			this.fieldName = fieldName;
		}

		public MedicamentGroupsUserControl()
		{
			InitializeComponent();
		}
		private void MedicamentGroupsUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			List<int> groups = new List<int>();
			using (GmConnection conn = App.CreateConnection())
			{ 
				if (id != 0)
				{
					string cmdText = string.Format("select MedicamentGroupId from {0} where {1}={2}", tableName, fieldName, id);
					using (DbDataReader dr = conn.ExecuteReader(cmdText))
					{
						while (dr.Read())
						{
							groups.Add(dr.GetInt32(0));
						}
					}
				}
				conn.Fill(dt, "select Id, Name from MedicamentGroups");
			}
			dcId = dt.Columns[0];
			dcChecked = dt.Columns.Add("Checked", typeof(bool));
			dcChecked.DefaultValue = false;
			foreach (DataRow dr in dt.Rows)
			{
				int groupId = (int)dr[dcId];
				dr[dcChecked] = groups.Contains(groupId);
			}
			gridView.DataSource = dt;
		}

		internal void Save(GmConnection conn, int id)
		{
            this.id = id;
			if (id != 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					if (dr.RowState == DataRowState.Modified)
					{
						int groupId = (int)dr[dcId];
						bool isChecked = (bool)dr[dcChecked];
						GmCommand cmd = conn.CreateCommand();
						if (isChecked)
						{
							cmd.CommandText = string.Format("insert into {0} values(@{1},@MedicamentGroupId)",tableName,fieldName);
						}
						else
						{
							cmd.CommandText = string.Format("delete from {0} where {1}=@{1} and MedicamentGroupId=@MedicamentGroupId", tableName, fieldName);
						}
						cmd.AddInt(fieldName, id);
						cmd.AddInt("MedicamentGroupId", groupId);
						cmd.ExecuteNonQuery();
					}
				}
				dt.AcceptChanges();
			}
		}
	}
}
