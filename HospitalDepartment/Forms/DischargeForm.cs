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
using HospitalDepartment.Reports;
using Geomethod;

namespace HospitalDepartment.Forms
{
	public partial class DischargeForm : Form
	{
		bool loaded = false;
		Patient patient;
		DischargeData dischargeData;
		public Patient Patient { get { return patient; } }
		string patientName;
		public DischargeForm()
		{
			InitializeComponent();
		}
		public DischargeForm(Patient patient)
		{
			InitializeComponent();
			this.patient=patient;
			dischargeData=patient.dischargeData;
			FormUtils.Init(this);
		}

		private void DischargeForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			if (patient.dischargeTypeId == DischargeTypeId.None) patient.dischargeTypeId = DischargeTypeId.Discharge;
			DateTimePickerUtils.Init(dtpDischargeDate, patient.dischargeDate);
			using (GmConnection conn = App.CreateConnection())
			{
				patientName = patient.GetPatientName(conn);
                cbDischargeType.Fill( conn, "select * from DischargeTypes", (int)patient.dischargeTypeId);
			}
			SetDischargeType();
			loaded = true;
		}

		void SetDischargeType()
		{
			List<ReportBuilderId> list = new List<ReportBuilderId>();
			list.Add(ReportBuilderId.Discharge);
			list.Add(ReportBuilderId.DischargeEpicrisis);
			HandbookGroupId hgId = HandbookGroupId.Discharge;
			switch (patient.dischargeTypeId)
			{
				case DischargeTypeId.DepartmentTransfer:
					hgId = HandbookGroupId.DepartmentTransfer;
					list.Add(ReportBuilderId.DepartmentTransferEpicrisis);
					break;
				case DischargeTypeId.SanatoriumTransfer:
					hgId = HandbookGroupId.SanatoriumTransfer;
					list.Add(ReportBuilderId.SanatoriumTransferEpicrisis);
					break;
				case DischargeTypeId.Postmortal:
					hgId = HandbookGroupId.Postmortal;
					list.Add(ReportBuilderId.PostmortalEpicrisis);
					break;
			}
			HandbookGroup hg = App.Config[hgId];
			base.Text = hg.name;
			if (patientName.Trim().Length > 0) base.Text += " - " + patientName;
			ucHandbooksInfo.Init(patient.dischargeData, hg);
			ucSelectReport.Init(list);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			using (WaitCursor wc = new WaitCursor())
			{
				patient.dischargeDate=DateTimePickerUtils.GetDateTime(dtpDischargeDate);
				using (GmConnection conn = App.CreateConnection())
				{
					ucHandbooksInfo.Save();
					patient.SaveDischargeData(conn);
				}
			}
		}

		private void ucSelectReport_OnShowReport(object sender, HospitalDepartment.UserControls.SelectReportEventArgs e)
		{
			if(patient != null)
			{
				switch(BaseReportBuilder.GetReportBuilderId(e.Report.ReportBuilderId))
				{
					case ReportBuilderId.Discharge:
						e.ReportBuilder = new DischargeReportBuilder(App.ConnectionFactory, App.Config, patient);
						break;
					case ReportBuilderId.DischargeEpicrisis:
						e.ReportBuilder = new DischargeEpicrisisReportBuilder(App.ConnectionFactory, App.Config, patient);
						break;
					case ReportBuilderId.DepartmentTransferEpicrisis:
						e.ReportBuilder = new DepartmentTransferEpicrisisReportBuilder(App.ConnectionFactory, App.Config, patient);
						break;
					case ReportBuilderId.SanatoriumTransferEpicrisis:
						e.ReportBuilder = new SanatoriumTransferEpicrisisReportBuilder(App.ConnectionFactory, App.Config, patient);
						break;
					case ReportBuilderId.PostmortalEpicrisis:
						e.ReportBuilder = new PostmortalEpicrisisReportBuilder(App.ConnectionFactory, App.Config, patient);
						break;
				}
			}
		}

		private void cbDischargeType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (loaded)
			{
				patient.dischargeTypeId = (DischargeTypeId)ComboBoxUtils.GetSelectedValue(cbDischargeType);
				SetDischargeType();
			}
		}

	}
}