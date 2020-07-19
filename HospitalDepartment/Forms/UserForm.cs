using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class UserForm : Form
	{
		User user;
		public User User { get { return user; } }
		public string RoleName { get { return ucUser.RoleName; } }

		public UserForm(User user)
		{
			InitializeComponent();
			FormUtils.Init(this);
			this.user = user;
			using (GmConnection conn = App.CreateConnection())
			{
				ucUser.Init(user);
				ucPermissions.Init(user.Permissions);
			}
		}

		private void UserForm_Load(object sender, EventArgs e)
		{

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			ucUser.Save();
			ucPermissions.Save();
			using (GmConnection conn = App.CreateConnection())
			{
				user.Save(conn);
			}
		}
	}
}