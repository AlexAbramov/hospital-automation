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
	public partial class PatientDataUserControl : UserControl
	{
		bool loaded = false;
		Patient patient;
		PatientData patientData;
		public void Init(Patient patient)
		{
			this.patient = patient;
			this.patientData = patient.patientData;
		}
		public PatientDataUserControl()
		{
			InitializeComponent();
		}

		private void PatientUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			cbDiet.Items.AddRange(App.DepartmentConfig.Diets.ToArray());
            cbDiet.Text = patient.dietNumber.Length == 0 ? App.DepartmentConfig.defaultDiet : patient.dietNumber;
			HandbookGroup hg = App.Config[HandbookGroupId.PatientData];
			dtpAdmissionDate.Value = patient.admissionDate;
			dtpDescriptionTime.Value = patientData.descriptionTime;
			dtpSickListStartDate.Value = patientData.sickListStartDate;
			using (GmConnection conn = App.CreateConnection())
			{
                if (patient.wardId == 0) patient.wardId = Ward.GetDefaultWardId(conn);
                cbWard.Fill(conn, "select Wards.Id, Number+' '+WardTypes.Name from Wards left join WardTypes on WardTypes.Id=WardTypeId order by Number", patient.wardId);
                cbPatientType.Fill( conn, "select Id, Name from PatientTypes", (int)patient.patientTypeId);
			}
			ucHandbooksInfo.Init(patientData, hg);
			loaded = true;
		}

		internal void Save()
		{
			if (!loaded) return;
			ucHandbooksInfo.Save();
			patient.admissionDate = dtpAdmissionDate.Value;
			patient.patientTypeId = (PatientTypeId)ComboBoxUtils.GetSelectedValue(cbPatientType);
			patient.wardId = ComboBoxUtils.GetSelectedValue(cbWard);
			patientData.descriptionTime = dtpDescriptionTime.Value;
			patientData.sickListStartDate = dtpSickListStartDate.Value;
			patient.dietNumber = cbDiet.Text;
		}

		private void dtpAdmissionDate_ValueChanged(object sender, EventArgs e)
		{
			const double maxDelay = 300;//[sec]
			double delay = (dtpDescriptionTime.Value - dtpAdmissionDate.Value).TotalSeconds;
			if (delay < 0 || delay > maxDelay)
			{
				Random r = new Random();
				dtpDescriptionTime.Value = dtpAdmissionDate.Value + TimeSpan.FromSeconds(r.NextDouble() * maxDelay);
			}
		}

		private void ucHandbooksInfo_Load(object sender, EventArgs e)
		{

		}

		private void btnPatientWardHistory_Click(object sender, EventArgs e)
		{
            Forms.PatientWardHistoryForm form = new HospitalDepartment.Forms.PatientWardHistoryForm(patient);
			form.ShowDialog();
		}

	}
}
