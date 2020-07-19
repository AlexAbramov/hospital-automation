using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Reports;
using HospitalDepartment.Forms;
using Geomethod.Windows.Forms;
using Geomethod;

namespace HospitalDepartment.UserControls
{
	public partial class SelectReportUserControl : UserControl
	{
		public event EventHandler<SelectReportEventArgs> OnShowReport;
		public void Init(IEnumerable<Report> reports)
		{
			lbReports.DataSource = reports;
		}
		public void Init(IEnumerable<ReportBuilderId> ids)
		{
			List<Report> ds = new List<Report>();
			foreach (ReportBuilderId id in ids)
			{
				AddReports(ds, id);
			}
			Init(ds);
		}
		private void AddReports(List<Report> ds, ReportBuilderId reportBuilderId)
		{
			ds.AddRange(App.Config.GetVisibleReports(reportBuilderId.ToString()));
		}
		public SelectReportUserControl()
		{
			InitializeComponent();
		}

		public Report SelectedReport
		{
			get { return lbReports.SelectedItem as Report; }
		}

		private void lbReports_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnReport_Click(object sender, EventArgs e)
		{
			ShowReport();
		}

		private void lbReports_DoubleClick(object sender, EventArgs e)
		{
			ShowReport();
		}

		private void ShowReport()
		{
			try
			{
				if (OnShowReport != null)
				{
					using (WaitCursor wc = new WaitCursor())
					{
						SelectReportEventArgs ev = new SelectReportEventArgs(SelectedReport);
						if (ev.Report != null)
						{
							OnShowReport(this, ev);
							if (ev.ReportBuilder != null)
							{
								ReportForm form = new ReportForm(ev.Report, ev.ReportBuilder);
								if (form.ShowDialog() == DialogResult.OK)
								{
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

        int prevIndex = -1;

		private void lbReports_MouseMove(object sender, MouseEventArgs e)
		{
			int index=lbReports.IndexFromPoint(e.Location);
            if (index != prevIndex)
            {
                prevIndex = index;
                string s = index >= 0 && index < lbReports.Items.Count ? lbReports.Items[index].ToString() : "";
                toolTip.SetToolTip(lbReports, s);
                toolTip.Active = s.Length > 0;
            }
		}
	}
	public class SelectReportEventArgs : EventArgs
	{
		Report report;
		IReportBuilder reportBuilder = null;
		public Report Report { get { return report; } }
		public IReportBuilder ReportBuilder { get { return reportBuilder; } set { reportBuilder = value; } }
		public SelectReportEventArgs(Report report)
		{
			this.report = report;
		}
	}
}
