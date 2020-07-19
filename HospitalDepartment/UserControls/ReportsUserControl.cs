using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Forms;
using HospitalDepartment.Utils;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class ReportsUserControl : UserControl
	{
		Config config;
		public void Init(Config config) { this.config = config; }

		Report SelectedReport { get { return GridViewUtils.GetSelectedItem(gridView) as Report; } }

		public ReportsUserControl()
		{
			InitializeComponent();
		}

		private void ReportsUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			colReportBuilder.ValueMember = "Id";
			colReportBuilder.DisplayMember = "Name";
			colReportBuilder.DataSource = config.reportBuilders;
			gridView.DataSource=config.reports;
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void Open()
		{
			try
			{
				Report report = SelectedReport;
				if (report != null)
				{
					ReportConfigForm form = new ReportConfigForm(report);
					if (form.ShowDialog() == DialogResult.OK)
					{
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Open();
		}
	}
}
