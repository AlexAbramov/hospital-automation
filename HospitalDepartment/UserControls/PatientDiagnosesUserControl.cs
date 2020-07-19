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
	public partial class PatientDiagnosesUserControl : UserControl
	{
		bool loaded = false;
		Patient patient;
		PatientDiagnoses patientDiagnoses;
		public void Init(Patient patient)
		{
			this.patient = patient;
			this.patientDiagnoses = patient.patientDiagnoses;
		}
		public PatientDiagnosesUserControl()
		{
			InitializeComponent();
		}

		private void PatientDiagnosesUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			HandbookGroup hg = App.Config[HandbookGroupId.PatientDiagnoses];
			ucDirectionalDiagnosis.Init(patientDiagnoses.directionalDiagnosis, hg.GetHandbookItems(PatientDiagnosesHandbookId.DirectionalDiagnosis.ToString()));
			ucAdmissionDiagnosis.Init(patientDiagnoses.admissionDiagnosis);
			ucClinicalDiagnosis.Init(patientDiagnoses.clinicalDiagnosis);
		  ucFinalDiagnosis.Init(patientDiagnoses.finalDiagnosis);
			ucComplicationDiagnosis.Init(patientDiagnoses.complicationDiagnosis, hg.GetHandbookItems(PatientDiagnosesHandbookId.ComplicationDiagnosis.ToString()));
			ucConcomitantDiagnosis.Init(patientDiagnoses.concomitantDiagnosis, hg.GetHandbookItems(PatientDiagnosesHandbookId.ConcomitantDiagnosis.ToString()));
			loaded = true;
		}

		internal void Save()
		{
			if (!loaded) return;
			patientDiagnoses.directionalDiagnosis = ucDirectionalDiagnosis.Text;
			patientDiagnoses.complicationDiagnosis = ucComplicationDiagnosis.Text;
			patientDiagnoses.concomitantDiagnosis = ucConcomitantDiagnosis.Text;
			patient.diagnosisId = patientDiagnoses.LatestDiagnosisInfo.id;
			patientDiagnoses.admissionDiagnosis = ucAdmissionDiagnosis.DiagnosisInfo;
			patientDiagnoses.clinicalDiagnosis = ucClinicalDiagnosis.DiagnosisInfo;
			patientDiagnoses.finalDiagnosis = ucFinalDiagnosis.DiagnosisInfo;
		}

		private void cbDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
/*			patient.diagnosisId = ComboBoxUtils.GetSelectedValue(cbDiagnosis);
			if (ucAdmissionDiagnosis.Text.Trim().Length == 0)
			{
				ucAdmissionDiagnosis.Text = ComboBoxUtils.GetSelectedText(cbDiagnosis);
			}*/
		}

		private void ucFinalDiagnosis_Load(object sender, EventArgs e)
		{
		}

		private void ucAdmissionDiagnosis_OnDiagnosisIdChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			patientDiagnoses.admissionDiagnosis = ucAdmissionDiagnosis.DiagnosisInfo;
		}

		private void ucClinicalDiagnosis_OnDiagnosisIdChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			patientDiagnoses.clinicalDiagnosis = ucClinicalDiagnosis.DiagnosisInfo;
		}

		private void ucFinalDiagnosis_OnDiagnosisIdChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			patientDiagnoses.finalDiagnosis = ucFinalDiagnosis.DiagnosisInfo;
		}

	}
}
