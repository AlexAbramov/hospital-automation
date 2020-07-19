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
using Geomethod.Windows.Forms;
using HospitalDepartment.Reports;

namespace HospitalDepartment.Forms
{
	public partial class ObservationsForm : Form
	{
		Patient patient;
		string patientName = "";
		DataTable dataTable = new DataTable();
		Dictionary<ObservationTypeId, string> observationTypes = new Dictionary<ObservationTypeId, string>();
        bool nurseMode = false;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public ObservationsForm(Patient patient, bool nurseMode)
		{
			InitializeComponent(); 
			this.patient = patient;
			FormUtils.Init(this);
            this.nurseMode = nurseMode;
		}

		private void ObservationsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
            if (nurseMode)
            {
                Control[] controls ={ btnAdd, btnDoctorRound, btnChiefRound, ucSelectReport };
                foreach(Control ctl in controls) ctl.Visible=false;
            }
			LoadData();
		}

		void LoadData()
		{
			using (WaitCursor wc = new WaitCursor())
			{
				string cmdText = @"select Observations.*, Users.Name as DoctorName, ObservationTypes.Name as ObservationTypeName from Observations 
left join Users on Users.Id=DoctorId 
left join ObservationTypes on ObservationTypes.Id=ObservationTypeId
where PatientId=" + patient.Id;
                if (nurseMode) cmdText += " and ObservationTypeId=" + (int)ObservationTypeId.TemperatureCard;
				using (GmConnection conn = App.CreateConnection())
				{
					conn.Fill(dataTable, cmdText);
					patientName = patient.GetPatientName(conn);

					using(DbDataReader dr=conn.ExecuteReader("select Id, Name from ObservationTypes"))
					{
						while(dr.Read())
							observationTypes.Add((ObservationTypeId)dr.GetInt32(0),dr.GetString(1));
					}
				}
				if (patientName.Trim().Length > 0) base.Text += " - " + patientName;
				dataTable.DefaultView.Sort = "Time";
				gridView.DataSource = dataTable;
			}
			List<ReportBuilderId> list = new List<ReportBuilderId>();
			list.Add(ReportBuilderId.Observations);
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
				using (WaitCursor wc = new WaitCursor())
				{
					int id = SelectedId;
					if (id != 0)
					{
						Observation observation = null;
						using (GmConnection conn = App.CreateConnection())
						{
							observation = Observation.GetObservation(conn, id);
						}
						if (observation != null)
						{
//							string observationTypeName = (string)SelectedRow["ObservationTypeName"];
							ObservationForm form = new ObservationForm(observation, patientName);
							if (form.ShowDialog() == DialogResult.OK)
							{
								UpdateRow(SelectedRow,observation);
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

		private void UpdateRow(DataRow dr, Observation observation)
		{
			dr["Id"] = observation.Id;
			dr["Time"] = observation.time;
			dr["Description"] = observation.description.GetXmlString();
			dr["DoctorName"] = App.Instance.UserInfo.UserName;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Add(ObservationTypeId.Diary);
		}


		private void btnDoctorRound_Click(object sender, EventArgs e)
		{
			Add(ObservationTypeId.DoctorRound);
		}

		private void btnChiefRound_Click(object sender, EventArgs e)
		{
			Add(ObservationTypeId.ChiefRound);
		}

		private void Add(ObservationTypeId observationTypeId)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					DataRow dr=GetPrevObservationRow(observationTypeId);
					DateTime prevTime = dr != null ? (DateTime) dr["Time"] : patient.admissionDate;
                    DateTime dt = App.DepartmentConfig.GetNextObservationTime(observationTypeId, patient.patientTypeId, prevTime, dr == null);

					if (patient.dischargeDate != DateTime.MinValue && dt>patient.dischargeDate)
					{
						FormUtils.MessageExcl("Время наблюдения не должно быть позднее времени выписки.");
						return;
					}
                    
                    Observation observation = new Observation(observationTypeId);
                    HandbookGroupId hgId = Observation.GetHandbookGroupId(observationTypeId);
					if (dr != null) observation.description = ObservationData.Create(dr["Description"] as string);
                    else observation.description.Init(App.Config[hgId], patient.patientDescription);
					observation.time=dt;
					observation.patientId = patient.Id;
					observation.doctorId = App.Instance.UserId;
					ObservationForm form = new ObservationForm(observation, patientName);
					if (form.ShowDialog() == DialogResult.OK)
					{
						DataRow newRow = dataTable.NewRow();
						dataTable.Rows.Add(newRow);
						UpdateRow(newRow, observation);
						newRow["ObservationTypeId"] = (int)observationTypeId;
						newRow["ObservationTypeName"] = observationTypes[observationTypeId];
						GridViewUtils.SetCurrentRow(gridView, newRow);
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private DataRow GetPrevObservationRow(ObservationTypeId observationTypeId)
		{
			DataRow[] rows = dataTable.Select("ObservationTypeId=" + (int)observationTypeId, "Time");
			return rows.Length>0? rows[rows.Length-1] : null;
		}

		private void ucSelectReport_OnShowReport(object sender, HospitalDepartment.UserControls.SelectReportEventArgs e)
		{
			if (patient != null)
			{
				switch (BaseReportBuilder.GetReportBuilderId(e.Report.ReportBuilderId))
				{
					case ReportBuilderId.Observations:
						e.ReportBuilder = new ObservationsReportBuilder(App.ConnectionFactory, App.Config, patient);
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
					int id=(int)selRow[0];
					using (GmConnection conn = App.CreateConnection())
					{
						Observation.Remove(conn, id);
					}
					dataTable.Rows.Remove(selRow);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void ucSelectReport_Load(object sender, EventArgs e)
		{

		}

		private void btnTemperature_Click(object sender, EventArgs e)
		{
			Add(ObservationTypeId.TemperatureCard);
		}
	}
}