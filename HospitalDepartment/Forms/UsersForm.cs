using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using Geomethod.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class UsersForm : Form
	{
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public UsersForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
			LoadData();
		}

		private void UsersForm_Load(object sender, EventArgs e)
		{
		}

		void LoadData()
		{
			string cmdText=@"
select Users.Id, Users.Name, Roles.Name as RoleName 
from Users 
left join Roles on RoleId=Roles.Id";
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter(cmdText);
				dataAdapter.Fill(dataTable);
			}
			dataTable.DefaultView.Sort = "Name";
			gridView.DataSource = dataTable;
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Open();
		}

		private void Open()
		{
			try
			{
				int userId = SelectedId;
				if (userId != 0)
				{
					User user = null;
					using (GmConnection conn = App.CreateConnection())
					{
						user = User.GetUser(conn, userId);
					}
					if (user != null)
					{
						UserForm form = new UserForm(user);
						if (form.ShowDialog() == DialogResult.OK)
						{
							DataRow dr = SelectedRow;
							if (dr != null)
							{
								dr["Name"] = user.name;
								dr["RoleName"] = form.RoleName;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				User user = new User();
				UserForm form = new UserForm(user);
				if (form.ShowDialog() == DialogResult.OK)
				{
					DataRow newRow = dataTable.NewRow();
					dataTable.Rows.Add(newRow);
					newRow["Id"] = user.Id;
					newRow["Name"] = user.name;
					newRow["RoleName"] = form.RoleName;
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}

		}
	}
}