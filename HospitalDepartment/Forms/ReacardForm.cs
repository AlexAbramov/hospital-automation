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
	public partial class ReacardForm : Form
	{
		Reacard reacard;
		Patient patient;
		public Reacard Reacard { get { return reacard; } }
		public ReacardForm(Reacard reacard, Patient patient)
		{
			InitializeComponent();
			this.reacard = reacard;
			this.patient = patient;
			FormUtils.Init(this);
		}

		private void ReacardForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			dtpDate.Value = reacard.date;
			ucHandbooksInfo.Init(reacard.reacardData, App.Config[HandbookGroupId.ReacardData]);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			ucHandbooksInfo.Save();
			reacard.date = dtpDate.Value;
			using (GmConnection conn = App.CreateConnection())
			{
				reacard.Save(conn);
			}
		}

	}
}