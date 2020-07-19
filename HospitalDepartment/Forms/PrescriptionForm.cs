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
	public partial class PrescriptionForm : Form
	{
		DataRow dataRow;
		Patient patient;
		public PrescriptionForm(DataRow dataRow, Patient patient)
		{
			InitializeComponent();
			this.dataRow = dataRow;
			this.patient = patient;
			FormUtils.Init(this);
		}

		private void PrescriptionForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			tbMedicament.Text=dataRow["ProductName"].ToString();
			using (GmConnection conn = App.CreateConnection())
			{
                cbPrescriptionType.Fill(conn,"select Id, Name from PrescriptionTypes order by Name",(int)dataRow["PrescriptionTypeId"]);
			}
			dtpStartDate.Value = (DateTime)dataRow["StartDate"];
			dtpEndDate.Value=(DateTime)dataRow["EndDate"];
			nudDose.Value = (decimal)dataRow["Dose"];
			nudMultiplicity.Value = (int)dataRow["Multiplicity"];
			lblUnit.Text = dataRow["BaseUnitName"].ToString();
			dtpStartDate.ShowUpDown = true;
			dtpEndDate.ShowUpDown = true;
			nudDuration.Value = (int)dataRow["Duration"];
			chkReanimation.Checked = (bool)dataRow["ReanimationFlag"];

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			dataRow["PrescriptionTypeId"]=ComboBoxUtils.GetSelectedValue(cbPrescriptionType);
			dataRow["PrescriptionTypeName"]=ComboBoxUtils.GetSelectedText(cbPrescriptionType);
			dataRow["StartDate"]=dtpStartDate.Value;
			dataRow["EndDate"]=dtpEndDate.Value;
			dataRow["Dose"]=nudDose.Value;
			dataRow["Multiplicity"]=(int)nudMultiplicity.Value;
			dataRow["Duration"]= (int)nudDuration.Value;
			dataRow["ReanimationFlag"] = (bool)chkReanimation.Checked;
		}

		private void nudDuration_ValueChanged(object sender, EventArgs e)
		{
			SetEndDate();
		}

		private void dtpStartDate_ValueChanged(object sender, EventArgs e)
		{
			SetEndDate();
		}

		private void chkReanimation_CheckedChanged(object sender, EventArgs e)
		{
			lblDurationUnit.Text = chkReanimation.Checked ? "часов" : "дней";
			SetEndDate();
		}

		private void SetEndDate()
		{
			double dur = (double)nudDuration.Value;
			TimeSpan ts=chkReanimation.Checked?TimeSpan.FromHours(dur):TimeSpan.FromDays(dur);
			dtpEndDate.Value = dtpStartDate.Value + ts;
		}

	}
}