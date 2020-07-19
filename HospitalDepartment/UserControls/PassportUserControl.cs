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
	public partial class PassportUserControl : UserControl
	{
		bool loaded = false;
		Passport passport;
		public void Init(Passport passport) 
		{ 
			this.passport = passport;
		}

		public PassportUserControl()
		{
			InitializeComponent();
		}

		private void PassportUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			using (GmConnection conn = App.CreateConnection())
			{
                cbGender.Fill( conn, "select Id, Name from Genders", (int)passport.gender);
			}
			dtpBirthday.Value=passport.birthday;
			tbMiddleName.Text=passport.middleName;
			tbName.Text=passport.name;
			tbSurname.Text = passport.surname;
			tbBirthPlace.Text = passport.birthPlace;
			tbDepartmentCode.Text=passport.departmentCode;
		  dtpIssueDate.Value=passport.issueDate;
			ucIssueDepartment.Init(passport.issueDepartment, App.Config.GetHandbookItems("IssueDepartment"));
			tbRegistration.Text=passport.registration;
			tbSerialNumber.Text=passport.serialNumber;
			loaded = true;
		}

		internal bool Save()
		{
			if (!loaded) return false;
			passport.birthday=dtpBirthday.Value;
			passport.gender = (GenderId)cbGender.SelectedValue;
			passport.middleName = StringUtils.TrimAndCap(tbMiddleName.Text);
			passport.name =StringUtils.TrimAndCap(tbName.Text);
			passport.surname = StringUtils.TrimAndCap(tbSurname.Text);
			passport.birthPlace=tbBirthPlace.Text.Trim();
			passport.departmentCode = tbDepartmentCode.Text.Trim();
			passport.issueDate = dtpIssueDate.Value;
			passport.issueDepartment = ucIssueDepartment.Text.Trim();
			passport.registration = tbRegistration.Text.Trim();
			passport.serialNumber = tbSerialNumber.Text.Trim();
			return ReflectionUtils.HasData(passport);
		}

		private void tbSurname_TextChanged(object sender, EventArgs e)
		{
			TextBoxUtils.FixNameInput(tbSurname);
		}

		private void tbName_TextChanged(object sender, EventArgs e)
		{
			TextBoxUtils.FixNameInput(tbName);
		}

		private void tbMiddleName_TextChanged(object sender, EventArgs e)
		{
			TextBoxUtils.FixNameInput(tbMiddleName);
		}

	}
}
