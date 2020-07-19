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
	public partial class RolesForm : Form
	{
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public RolesForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
			LoadData();
		}

		private void RolesForm_Load(object sender, EventArgs e)
		{
		}

		void LoadData()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter("select Id, Name from Roles");
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
				int id = SelectedId;
				if (id != 0)
				{
					Role role = null;
					using (GmConnection conn = App.CreateConnection())
					{
						role = Role.GetRole(conn, id);
					}
					if (role != null)
					{
						RoleForm form = new RoleForm(role);
						if (form.ShowDialog() == DialogResult.OK)
						{
							DataRow dr = SelectedRow;
							if (dr != null)
							{
								dr["Name"] = role.name;
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
				Role role = new Role();
				RoleForm form = new RoleForm(role);
				if (form.ShowDialog() == DialogResult.OK)
				{
					DataRow newRow=dataTable.NewRow();
					dataTable.Rows.Add(newRow);
					newRow["Id"] = role.Id;
					newRow["Name"] = role.name;
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow selRow = SelectedRow;
                if (selRow != null)
                {
                    int id = (int)selRow[0];
                    using (GmConnection conn = App.CreateConnection())
                    {
                        Role.Remove(conn, id);
                    }
                    dataTable.Rows.Remove(selRow);
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }
	}
}