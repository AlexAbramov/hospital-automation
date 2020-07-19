using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;
using HospitalDepartment.Reports;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.Forms
{
	public partial class PatientConsultationsForm : Form
	{
		Patient patient;
		DataTable dataTable = new DataTable();

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public PatientConsultationsForm(Patient patient)
		{
			InitializeComponent();
			this.patient = patient;
			FormUtils.Init(this);
		}

		private void PatientConsultationsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
		}

		void LoadData()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				conn.Fill(dataTable,"select Id, RequestDate, ExecutionDate from PatientConsultations where PatientId="+patient.Id);
			}
			gridView.DataSource = dataTable;
			List<ReportBuilderId> list = new List<ReportBuilderId>();
			list.Add(ReportBuilderId.ConsultationRequest);
			ucSelectReport.Init(list);
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Open();
		}

		private void Open()
		{
			try
			{
				PatientConsultation patientConsultation = GetPatientConsultation();
				if (patientConsultation != null)
				{
					PatientConsultationForm form = new PatientConsultationForm(patientConsultation,patient);
					if (form.ShowDialog() == DialogResult.OK)
					{
						UpdateRow(SelectedRow, patientConsultation);
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private PatientConsultation GetPatientConsultation()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				return PatientConsultation.GetPatientConsultation(conn, SelectedId);
			}
		}

		private void UpdateRow(DataRow dr, PatientConsultation patientConsultation)
		{
			dr["Id"] = patientConsultation.Id;
			dr["RequestDate"] = patientConsultation.requestDate;
			dr["ExecutionDate"] = DateTimeUtils.GetNullableTime(patientConsultation.executionDate);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				PatientConsultation patientConsultation = new PatientConsultation(patient.Id);
				PatientConsultationForm form = new PatientConsultationForm(patientConsultation,patient);
				if (form.ShowDialog() == DialogResult.OK)
				{
					DataRow newRow=dataTable.NewRow();
					dataTable.Rows.Add(newRow);
					UpdateRow(newRow, patientConsultation);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void ucSelectReport_OnShowReport(object sender, HospitalDepartment.UserControls.SelectReportEventArgs e)
		{
			PatientConsultation patientConsultation = GetPatientConsultation();
			if (patientConsultation != null)
			{
				switch (BaseReportBuilder.GetReportBuilderId(e.Report.ReportBuilderId))
				{
					case ReportBuilderId.ConsultationRequest:
						e.ReportBuilder = new ConsultationRequestReportBuilder(App.ConnectionFactory, App.Config, patient, patientConsultation);
						break;
				}
			}
		}

	}
}