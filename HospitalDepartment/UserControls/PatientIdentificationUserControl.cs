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
	public partial class PatientIdentificationUserControl : UserControl
	{
		bool loaded = false;
	  PatientIdentification patientIdentification;
		public void Init(PatientIdentification patientIdentification)
		{
			this.patientIdentification = patientIdentification;
		}
		public PatientIdentificationUserControl()
		{
			InitializeComponent();
		}

		private void PatientIdentificationUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			ucHandbooksInfo.Init(patientIdentification.identificationData, App.Config[HandbookGroupId.PatientIdentification]);
			using (GmConnection conn = App.CreateConnection())
			{
                cbGender.Fill( conn, "select Id, Name from Genders", (int)patientIdentification.gender, "");
			}
			DateTimePickerUtils.Init(dtpBirthday,patientIdentification.birthday);
			tbMiddleName.Text = patientIdentification.middleName;
			tbName.Text = patientIdentification.name;
			tbSurname.Text = patientIdentification.surname;
			loaded = true;
		}

		public bool Save()
		{
			if (!loaded) return false;
			patientIdentification.birthday=DateTimePickerUtils.GetDateTime(dtpBirthday);
			patientIdentification.gender = (GenderId)cbGender.SelectedValue;
			patientIdentification.middleName = StringUtils.TrimAndCap(tbMiddleName.Text);
			patientIdentification.name = StringUtils.TrimAndCap(tbName.Text);
			patientIdentification.surname = StringUtils.TrimAndCap(tbSurname.Text);
			ucHandbooksInfo.Save();
			return ReflectionUtils.HasData(patientIdentification);
		}
	}
}
