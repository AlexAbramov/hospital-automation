using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment.Utils;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.Forms
{
	public partial class ObservationForm : Form
	{
		Observation observation;
		string patientName;
		public Observation Observation { get { return observation; } }
		public ObservationForm()
		{
			InitializeComponent();
		}
		public ObservationForm(Observation observation, string patientName)
		{
			InitializeComponent();
			this.observation = observation;
			this.patientName = patientName;
			FormUtils.Init(this);
		}

		private void ObservationForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			dtpTime.Value = observation.time;
            HandbookGroupId hgId = Observation.GetHandbookGroupId(observation.observationTypeId);
			HandbookGroup hg=App.Config[hgId];
			base.Text = hg.name;
			if (patientName.Trim().Length > 0) base.Text += " - " + patientName;
			ucHandbooksInfo.Init(observation.description, hg);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			using (WaitCursor wc = new WaitCursor())
			{
				observation.doctorId = App.Instance.UserId;
				observation.time = dtpTime.Value;
				using (GmConnection conn = App.CreateConnection())
				{
					ucHandbooksInfo.Save();
					observation.Save(conn);
				}
			}
		}
	}
}