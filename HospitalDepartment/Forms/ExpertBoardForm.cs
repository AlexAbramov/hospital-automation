using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class ExpertBoardForm : Form
	{
		ExpertBoard expertBoard;
		Patient patient;
		public ExpertBoard ExpertBoard { get { return expertBoard; } }
		public ExpertBoardForm(ExpertBoard expertBoard, Patient patient)
		{
			InitializeComponent();
			this.expertBoard = expertBoard;
			this.patient = patient;
			FormUtils.Init(this);
		}

		private void ExpertBoardForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			dtpDate.Value = expertBoard.date;
			if (expertBoard.expertBoardData.diagnosisInfo.id == 0)
			{
				expertBoard.expertBoardData.diagnosisInfo = patient.LatestDiagnosisInfo;
			}
			ucDiagnosisInfo.Init(expertBoard.expertBoardData.diagnosisInfo);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			expertBoard.date = dtpDate.Value;
			expertBoard.expertBoardData.diagnosisInfo = ucDiagnosisInfo.DiagnosisInfo;
			using (GmConnection conn = App.CreateConnection())
			{
				expertBoard.Save(conn);
			}
		}
	}
}