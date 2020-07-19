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
	public partial class PatientConsultationForm : Form
	{
		PatientConsultation patientConsultation;
		Patient patient;
		public PatientConsultation PatientConsultation { get { return patientConsultation; } }
		public PatientConsultationForm(PatientConsultation patientConsultation, Patient patient)
		{
			InitializeComponent();
			this.patientConsultation = patientConsultation;
			this.patient = patient;
			FormUtils.Init(this);
		}

		private void PatientConsultationForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			DateTimePickerUtils.Init(dtpRequestDate,patientConsultation.requestDate);
			DateTimePickerUtils.Init(dtpExecutionDate,patientConsultation.executionDate);
			ucHandbooksInfo.Init(patientConsultation.consultationData, App.Config[HandbookGroupId.ConsultationData]);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			patientConsultation.requestDate = DateTimePickerUtils.GetDateTime(dtpRequestDate);
			patientConsultation.executionDate = DateTimePickerUtils.GetDateTime(dtpExecutionDate);
			ucHandbooksInfo.Save();
			using (GmConnection conn = App.CreateConnection())
			{
				patientConsultation.Save(conn);
			}
		}
	}
}