using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment.UserControls
{
	public partial class PatientDescriptionUserControl : UserControl
	{
		bool loaded = false;
		PatientDescription patientDescription;
		public void Init(PatientDescription patientDescription)
		{
			this.patientDescription = patientDescription;
		}

		public PatientDescriptionUserControl()
		{
			InitializeComponent();
		}

		private void PatientDescriptionUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			ucHandbooksInfo.Init(patientDescription, App.Config[HandbookGroupId.PatientDescription], true);
			loaded = true;
		}

		internal void Save()
		{
			if (!loaded) return;
			ucHandbooksInfo.Save();
		}

		private void ucHandbooksInfo_Load(object sender, EventArgs e)
		{

		}
	}
}
