using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using Geomethod.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class RoleForm : Form
	{
		Role role;
		public Role Role { get { return role; } }

		public RoleForm(Role role)
		{
			InitializeComponent();
			FormUtils.Init(this);
			this.role = role;
			using (GmConnection conn = App.CreateConnection())
			{
				ucPermissions.Init(role.Permissions);
                cbWatchingGroup.Fill(conn, "select Id, Name from WatchingGroups", role.watchingGroupId, "нет");
			}
			tbName.Text = role.name;
		}

		private void RoleForm_Load(object sender, EventArgs e)
		{

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			role.name = tbName.Text.Trim();
			role.watchingGroupId = (int)cbWatchingGroup.SelectedValue;
			ucPermissions.Save();
			using (GmConnection conn = App.CreateConnection())
			{
				role.Save(conn);
			}
		}
	}
}