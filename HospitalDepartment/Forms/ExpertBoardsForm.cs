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
	public partial class ExpertBoardsForm : Form
	{
		Patient patient;
		DataTable dataTable = new DataTable();

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public ExpertBoardsForm(Patient patient)
		{
			InitializeComponent();
			this.patient = patient;
			FormUtils.Init(this);
		}

		private void ExpertBoardsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
		}

		void LoadData()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				conn.Fill(dataTable,"select Id, Date from ExpertBoards where PatientId="+patient.Id);
			}
			gridView.DataSource = dataTable;
			List<ReportBuilderId> list = new List<ReportBuilderId>();
			list.Add(ReportBuilderId.ExpertBoard);
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
				ExpertBoard expertBoard = GetExpertBoard();
				if (expertBoard != null)
				{
					ExpertBoardForm form = new ExpertBoardForm(expertBoard, patient);
					if (form.ShowDialog() == DialogResult.OK)
					{
						UpdateRow(SelectedRow, expertBoard);
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private ExpertBoard GetExpertBoard()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				return ExpertBoard.GetExpertBoard(conn, SelectedId);
			}
		}

		private void UpdateRow(DataRow dr, ExpertBoard expertBoard)
		{
			dr["Id"] = expertBoard.Id;
			dr["Date"] = expertBoard.date;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				ExpertBoard expertBoard = new ExpertBoard(patient.Id);
				ExpertBoardForm form = new ExpertBoardForm(expertBoard,patient);
				if (form.ShowDialog() == DialogResult.OK)
				{
					DataRow newRow=dataTable.NewRow();
					dataTable.Rows.Add(newRow);
					UpdateRow(newRow, expertBoard);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void ucSelectReport_OnShowReport(object sender, HospitalDepartment.UserControls.SelectReportEventArgs e)
		{
			ExpertBoard expertBoard = GetExpertBoard();
			if (expertBoard != null)
			{
				switch (BaseReportBuilder.GetReportBuilderId(e.Report.ReportBuilderId))
				{
					case ReportBuilderId.ExpertBoard:
						e.ReportBuilder = new ExpertBoardReportBuilder(App.ConnectionFactory, App.Config, patient, expertBoard);
						break;
				}
			}
		}

	}
}