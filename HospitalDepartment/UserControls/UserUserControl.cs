using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class UserUserControl : UserControl
	{
		User user;
		public User User { get { return user; } }
		public string RoleName { get { return cbRole.Text; } }
		public void Init(User user)
		{
			this.user = user;
		}

		public UserUserControl()
		{
			InitializeComponent();
		}

		private void UserUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			using (GmConnection conn = App.CreateConnection())
			{
                cbRole.Fill( conn, "select Id, Name from Roles", user.roleId);
			}
			tbName.Text = user.name;
			tbLogin.Text = user.login;
		}

		public void Save()
		{
			user.name = tbName.Text.Trim();
			user.login = tbLogin.Text.Trim();
			user.roleId=(int)cbRole.SelectedValue;
			user.password = tbPassword.Text.Trim();
		}

		private void UserUserControl_Validating(object sender, CancelEventArgs e)
		{
		}
	}
}
