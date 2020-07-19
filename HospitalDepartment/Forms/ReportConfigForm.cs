using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class ReportConfigForm : Form
	{
		Report report;

		public ReportConfigForm(Report report)
		{
			InitializeComponent();
			this.report = report;
			FormUtils.Init(this);
		}

		private void ReportConfigForm_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			cbReportType.ValueMember = "Id";
			cbReportType.DisplayMember = "Name";
			cbReportType.DataSource = App.Config.reportBuilders;
			tbName.Text = report.name;
			tbPath.Text = report.path;
			tbEmbeddedResource.Text = report.embeddedResource;
			cbReportType.SelectedValue = report.reportBuilderId;
			chkVisible.Checked = report.visible;
			if (report.IsEmbedded)
			{
				cbReportType.Enabled=false;
				tbPath.Enabled = false;
			}
		}

		private void Save()
		{
			report.name = tbName.Text.Trim();
			report.path = tbPath.Text.Trim();
			report.visible = chkVisible.Checked;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
			Close();
		}
	}
}