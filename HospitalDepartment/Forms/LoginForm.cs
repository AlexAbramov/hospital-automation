using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class LoginForm : Form
	{
        bool lockMode = false;
        public LoginForm(bool lockMode)
		{
			InitializeComponent();
			FormUtils.Init(this);
            this.lockMode = lockMode;
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			UpdateControls();
            Text += " - " + App.DepartmentConfig.departmentName;
		}

		private void tbLogin_TextChanged(object sender, EventArgs e)
		{
			UpdateControls();
		}

		private void tbPassword_TextChanged(object sender, EventArgs e)
		{
			UpdateControls();
		}

		private void UpdateControls()
		{
			btnOk.Enabled = tbLogin.Text.Length > 0 && tbPassword.Text.Length > 0;
			lblResult.Text = "";
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Login();
		}

		void Login()
		{
            string login=tbLogin.Text.Trim();
            string psw=tbPassword.Text.Trim();
            bool loginOk = false;
            if (lockMode)
            {
                if (App.Instance.UserInfo.CheckLogin(login, psw)) loginOk = true;
            }
            else if (App.Instance.Login(login, psw)) loginOk=true;
            if(loginOk)
            {
                    DialogResult=DialogResult.OK;
                    Close();
            }
			else lblResult.Text="Неправильный логин или пароль.";
		}

		private void tbPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Login();
			}
		}
	}
}