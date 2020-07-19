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
	public partial class DiagnosisForm : Form
	{
		Diagnosis diagnosis;
		public Diagnosis Diagnosis { get { return diagnosis; } }
		public DiagnosisForm()
		{
			InitializeComponent();
		}
		public DiagnosisForm(Diagnosis diagnosis)
		{
			InitializeComponent();
			FormUtils.Init(this);
			this.diagnosis = diagnosis;
		}

		private void DiagnosisForm_Load(object sender, EventArgs e)
		{
			ucMedicamentGroups.Init(diagnosis.Id, "DiagnosisGroupTies", "DiagnosisId");
			tbCode.Text = diagnosis.code;
			tbMCode.Text = diagnosis.mcode;
			tbName.Text = diagnosis.name;
			nudDay.Value = diagnosis.hospitalStayDay;
			nudFirst.Value = diagnosis.hospitalStayFirst;
			nudHigh.Value = diagnosis.hospitalStayHigh;
			nudSecond.Value = diagnosis.hospitalStaySecond;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			diagnosis.name = tbName.Text.Trim();
			diagnosis.code = tbCode.Text.Trim();
			diagnosis.mcode = tbMCode.Text.Trim();
			diagnosis.hospitalStayDay = (int)nudDay.Value;
			diagnosis.hospitalStayFirst = (int)nudFirst.Value;
			diagnosis.hospitalStayHigh = (int)nudHigh.Value;
			diagnosis.hospitalStaySecond = (int)nudSecond.Value;
			using (GmConnection conn = App.CreateConnection())
			{
				diagnosis.Save(conn);
                ucMedicamentGroups.Save(conn, diagnosis.Id);
			}
		}
	}
}