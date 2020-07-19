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
using HospitalDepartment.UserControls;

namespace HospitalDepartment.Forms
{
	public partial class PatientAdmissionForm : Form
	{
		Patient patient;
		Passport passport;
		Insurance insurance;
		PatientIdentification patientIdentification;

		public PatientAdmissionForm(Patient patient)
		{
			InitializeComponent();
			using (WaitCursor wc = new WaitCursor())
			{
				this.patient = patient;
				using (GmConnection conn = App.CreateConnection())
				{
					passport = patient.GetPassport(conn);
					insurance = patient.GetInsurance(conn);
					patientIdentification = patient.GetPatientIdentification(conn);
				}
				if(passport==null) passport=new Passport();
				if(insurance == null) insurance = new Insurance();
				if (patientIdentification == null) patientIdentification = new PatientIdentification();
				ucPassport.Init(passport);
				ucInsurance.Init(insurance);
				ucPatientIdentification.Init(patientIdentification);
				ucPatientData.Init(patient);
				ucPatientDescription.Init(patient.patientDescription);
				ucPrescriptions.Init(patient);
				ucDiagnoses.Init(patient);
				ucAnalyses.Init(patient);
			}
			FormUtils.Init(this);
		}

		private void PatientAdmissionForm_Load(object sender, EventArgs e)
		{
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			using (WaitCursor wc = new WaitCursor())
			{
				using (GmConnection conn = App.CreateConnection())
				{
                    int patientId = patient.Id;
					int wardId = patient.wardId;
                    PatientTypeId patientTypeId = patient.patientTypeId;
					try
					{
						if (ucPassport.Save())
						{
							passport.Save(conn);
							patient.passportId = passport.Id;
						}

						if (ucInsurance.Save())
						{
							insurance.Save(conn);
							patient.insuranceId = insurance.Id;
						}

						if (ucPatientIdentification.Save())
						{
							patientIdentification.Save(conn);
							patient.patientIdentificationId = patientIdentification.Id;
						}

						ucPatientData.Save();
						ucPatientDescription.Save();
                        ucDiagnoses.Save();
					}
					finally
					{
                        if(patient.doctorId==0)
                            patient.doctorId = App.Instance.UserId;
						patient.Save(conn);
                        ucPrescriptions.Save(conn);
                        ucAnalyses.Save(conn);
                        if (wardId != patient.wardId || patientTypeId != patient.patientTypeId)
                            patient.SaveWardHistory(conn);
                        if (patientId == 0 && App.Instance.UserInfo.HasWatching)
                        {
                            Watching watching=App.Instance.UserInfo.Watching;
                            watching.AddPatient(patient.Id);
                            watching.Save(conn);
                        }
					}
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void tcPatient_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			foreach(Control ctl in tcPatient.SelectedTab.Controls)
			{
				if (ctl is IPatientAdmissionControl)
				{
					(ctl as IPatientAdmissionControl).OnSelected();
				}
			}
		}
	}
}