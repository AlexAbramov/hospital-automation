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
	public partial class ReacardsForm : Form
	{
		Patient patient;
		DataTable dataTable = new DataTable();

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public ReacardsForm(Patient patient)
		{
			InitializeComponent();
			this.patient = patient;
			FormUtils.Init(this);
		}

		private void ReacardsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
		}

		void LoadData()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				conn.Fill(dataTable,"select Id, Date from Reacards where PatientId="+patient.Id);
			}
			dataTable.DefaultView.Sort = "Date";
			gridView.DataSource = dataTable;
			List<ReportBuilderId> list = new List<ReportBuilderId>();
			list.Add(ReportBuilderId.Reacard);
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
				Reacard reacard = GetReacard();
				if (reacard != null)
				{
					ReacardForm form = new ReacardForm(reacard, patient);
					if (form.ShowDialog() == DialogResult.OK)
					{
						UpdateRow(SelectedRow, reacard);
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private Reacard GetReacard()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				return Reacard.GetReacard(conn, SelectedId);
			}
		}

		private void UpdateRow(DataRow dr, Reacard reacard)
		{
			dr["Id"] = reacard.Id;
			dr["Date"] = reacard.date;
		}

		DataRow GetPrevRow()
		{
			return dataTable.Rows.Count > 0 ? dataTable.Rows[dataTable.Rows.Count - 1] : null;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow prevRow=GetPrevRow();
				DateTime dt=patient.admissionDate;
				if (prevRow != null)
				{
					DateTime prevTime = (DateTime)prevRow["Date"];
					dt=new DateTime(prevTime.Year, prevTime.Month, prevTime.Day);
					dt += TimeSpan.FromDays(1);
				}
				Reacard reacard = new Reacard(patient.Id);
				reacard.date =dt;
				ReacardForm form = new ReacardForm(reacard,patient);
				if (form.ShowDialog() == DialogResult.OK)
				{
					DataRow newRow=dataTable.NewRow();
					dataTable.Rows.Add(newRow);
					UpdateRow(newRow, reacard);
					GridViewUtils.SetCurrentRow(gridView, newRow);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void ucSelectReport_OnShowReport(object sender, HospitalDepartment.UserControls.SelectReportEventArgs e)
		{
			Reacard reacard = GetReacard();
			if (reacard != null)
			{
				switch (BaseReportBuilder.GetReportBuilderId(e.Report.ReportBuilderId))
				{
					case ReportBuilderId.Reacard:
						e.ReportBuilder = new ReacardReportBuilder(App.ConnectionFactory, App.Config, patient, reacard);
						break;
				}
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow selRow = SelectedRow;
				if (selRow != null)
				{
					int id = (int)selRow[0];
					using (GmConnection conn = App.CreateConnection())
					{
						Reacard.Remove(conn, id);
					}
					dataTable.Rows.Remove(selRow);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}
	}
}