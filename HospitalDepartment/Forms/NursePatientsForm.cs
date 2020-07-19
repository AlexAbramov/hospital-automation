using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment.Utils;
using HospitalDepartment.Reports;

namespace HospitalDepartment.Forms
{
	public partial class NursePatientsForm : Form
	{
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }
		Patient SelectedPatient
		{ 
			get
			{
				int id = SelectedId;
				if (id != 0)
				{
					using (GmConnection conn = App.CreateConnection())
					{
						return Patient.GetPatient(conn, id);
					}
				}
				return null;
			}
		}

		public NursePatientsForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
		}

		private void PatientsUsersForm_Load(object sender, EventArgs e)
		{
			using (WaitCursor wc = new WaitCursor())
			{
				LoadData();
			}
		}

		void LoadData()
		{
			string cmdText= @"
select Patients.Id, Passports.Surname, Passports.Name, Passports.MiddleName, AdmissionDate, DischargeDate, Wards.Number as WardNumber, Users.Name as DoctorName
from Patients 
left join Passports on PassportId=Passports.Id
left join Wards on WardId=Wards.Id
left join Users on DoctorId=Users.Id
where ";
			if (!App.Instance.UserInfo.HasWatching || App.Instance.UserInfo.Watching.IsEmpty) cmdText += "DischargeDate is null";
			else cmdText += string.Format("Patients.Id in ({0})",App.Instance.UserInfo.Watching.GetCommaSeparatedPatientList());
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter(cmdText);
				dataAdapter.Fill(dataTable);
			}
			dataTable.DefaultView.Sort = "WardNumber";
			gridView.DataSource = dataTable;

			List<ReportBuilderId> list=new List<ReportBuilderId>();
//			list.Add(ReportBuilderId.PatientDescription);
			list.Add(ReportBuilderId.PatientIdentification);
			list.Add(ReportBuilderId.Prescriptions);
//			list.Add(ReportBuilderId.Observations);
			list.Add(ReportBuilderId.AnalysisRequest);
			list.Add(ReportBuilderId.AnalysisResult);
			list.Add(ReportBuilderId.TemperatureCard);
			ucSelectReport.Init(list);
		}


		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            Prescriptions();
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
/*			try
			{
				User user = new User();
				UserForm form = new UserForm(user);
				if (form.ShowDialog() == DialogResult.OK)
				{
					DataRow newRow = dataTable.NewRow();
					dataTable.Rows.Add(newRow);
					newRow["Id"] = user.Id;
					newRow["Name"] = user.name;
					newRow["RoleName"] = form.RoleName;
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}*/

		}

		private void btnObservations_Click(object sender, EventArgs e)
		{
			Observations();
		}

		private void Observations()
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					Patient patient = SelectedPatient;
					if (patient != null)
					{
						ObservationsForm form = new ObservationsForm(patient,true);
						if (form.ShowDialog() == DialogResult.OK)
						{
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{

		}

		private void btnDischarge_Click(object sender, EventArgs e)
		{
			Discharge();
		}

		private void Discharge()
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					Patient patient = SelectedPatient;
					if (patient != null)
					{
						DischargeForm form = new DischargeForm(patient);
						if (form.ShowDialog() == DialogResult.OK)
						{
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
		{
//			toolTip.SetToolTip(cbReport, cbReport.Text);
		}

		private void btnReacard_Click(object sender, EventArgs e)
		{
			Reacard();
		}

		private void Reacard()
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					Patient patient = SelectedPatient;
					if (patient != null)
					{
						ReacardsForm form = new ReacardsForm(patient);
						if (form.ShowDialog() == DialogResult.OK)
						{
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnConsultations_Click(object sender, EventArgs e)
		{
			Consultations();
		}

		private void Consultations()
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					Patient patient = SelectedPatient;
					if (patient != null)
					{
						PatientConsultationsForm form = new PatientConsultationsForm(patient);
						if (form.ShowDialog() == DialogResult.OK)
						{
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnAnalyses_Click(object sender, EventArgs e)
		{
			Analyses();
		}

        private void Analyses()
		{
            try
            {
                using (WaitCursor wc = new WaitCursor())
                {
                    Patient patient = SelectedPatient;
                    if (patient != null)
                    {
                        AnalysesForm form = new AnalysesForm(patient);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
		}

		private void ucSelectReport_OnShowReport(object sender, HospitalDepartment.UserControls.SelectReportEventArgs e)
		{
			Patient patient = SelectedPatient;
			if (patient != null)
			{
				switch (BaseReportBuilder.GetReportBuilderId(e.Report.ReportBuilderId))
				{
					case ReportBuilderId.PatientIdentification:
						e.ReportBuilder= new PatientIdentificationReportBuilder(App.ConnectionFactory, App.Config, patient);
						break;
					case ReportBuilderId.PatientDescription:
						e.ReportBuilder = new PatientDescriptionReportBuilder(App.ConnectionFactory, App.Config, patient);
						break;
					case ReportBuilderId.Prescriptions:
						e.ReportBuilder = new PrescriptionsReportBuilder(App.ConnectionFactory, App.Config, patient);
						break;
					case ReportBuilderId.Observations:
						e.ReportBuilder = new ObservationsReportBuilder(App.ConnectionFactory, App.Config, patient);
						break;
					case ReportBuilderId.TemperatureCard:
						e.ReportBuilder = new TemperatureCardReportBuilder(App.ConnectionFactory, App.Config, patient, 0);
						break;
					case ReportBuilderId.AnalysisRequest:
						e.ReportBuilder = new AnalysisRequestReportBuilder(App.ConnectionFactory, App.Config, patient, 0);
						break;
					case ReportBuilderId.AnalysisResult:
						e.ReportBuilder = new AnalysisResultReportBuilder(App.ConnectionFactory, App.Config, patient, 0);
						break;
				}
			}
		}

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            Prescriptions();
        }

        private void Prescriptions()
        {
            try
            {
                using (WaitCursor wc = new WaitCursor())
                {
                    Patient patient = SelectedPatient;
                    if (patient != null)
                    {
                        PrescriptionsForm form = new PrescriptionsForm(patient);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

	}
}