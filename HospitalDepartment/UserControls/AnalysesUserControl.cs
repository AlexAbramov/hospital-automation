using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using Geomethod.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;
using HospitalDepartment.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class AnalysesUserControl : UserControl, IPatientAdmissionControl
	{
		bool loaded = false;
		Patient patient;
        int patientId=0;
		DataTable dataTable=new DataTable();

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
//		int SelectedId { get { DataRow dr = SelectedRow; return dr != null ? (int)dr[0] : 0; } }

		public void Init(Patient patient)
		{
			this.patient=patient;
            patientId = patient.Id;
		}
		public AnalysesUserControl()
		{
			InitializeComponent();
		}

		private void AnalysesUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
            string cmdText = @"
select Analyses.*, AnalysisTypes.Name as AnalysisTypeName
from Analyses 
left join AnalysisTypes on AnalysisTypes.Id=AnalysisTypeId
";
            using (GmConnection conn = App.CreateConnection())
            {
                conn.Fill(dataTable, cmdText + " where PatientId=" + (patientId == 0 ? -1 : patientId));
            }
			gridView.DataError += new DataGridViewDataErrorEventHandler(gridView_DataError);
			gridView.DataSource = dataTable;
//			gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			loaded = true;
		}

		void gridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			Log.Exception(e.Exception);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Add();
		}

		internal void Save(GmConnection conn)
		{
			if (!loaded) return;
            if (patientId == 0)
            {
                patientId = patient.Id;
                foreach (DataRow dr in dataTable.Rows) dr["PatientId"] = patientId;
            }
            if (patientId > 0)
            {
                //			foreach (DataRow dr in dataTable.Rows) if (dr.RowState == DataRowState.Added) dr["CurrentCount"] = dr["Count"];
                DbCommandBuilder bld = conn.CreateCommandBuilder();
                bld.ConflictOption = ConflictOption.OverwriteChanges;
                DbDataAdapter dataAdapter = conn.CreateDataAdapter("select top 0 * from Analyses");
                bld.DataAdapter = dataAdapter;
                dataAdapter.Update(dataTable);
            }
            else Log.Error("AnalysesUserControl.Save patientId=0");
        }

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			Generate();
		}

		private void Generate()
		{

		}

		#region IPatientAdmissionControl Members

		public void OnSelected()
		{
		}

		#endregion

		private void ucSelectAnalysisType_OnSelected(object sender, EventArgs e)
		{
			Add();
		}

		private void Add()
		{
			DataRow selRow = ucSelectAnalysisType.SelectedRow;
			if (selRow != null)
			{
				DataRow dr = dataTable.NewRow();
				dataTable.Rows.Add(dr);
				dr["PatientId"] = patient.Id;
				dr["AnalysisTypeId"] = selRow["Id"];
				dr["RequestDate"] = DateTime.Now;
				dr["ExecutionDate"] = DBNull.Value;
				dr["AnalysisData"] = (new AnalysisData()).GetXmlString();
				dr["AnalysisTypeName"] = selRow["Name"];
			}
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Open();
		}

		private void Open()
		{
			try
			{
				Analysis analysis = GetAnalysis();
				if (analysis != null)
				{
					AnalisisForm form = new AnalisisForm(analysis, patient);
					if (form.ShowDialog() == DialogResult.OK)
					{
						UpdateRow(SelectedRow, analysis);
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void UpdateRow(DataRow dr, Analysis analysis)
		{
			dr["Id"] = analysis.Id;
			dr["RequestDate"] = analysis.requestDate;
			dr["ExecutionDate"] = DateTimeUtils.GetNullableTime(analysis.executionDate);
			dr["AnalysisData"] = analysis.analysisData.GetXmlString();
		}

		private Analysis GetAnalysis()
		{			
			DataRow dr=SelectedRow;
			if (dr != null)
			{
				return new Analysis(dr);// (DataTableUtils.CreateDataReader(dataTable, dr));
			}
			return null;
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			Remove();
		}

		private void Remove()
		{
			try
			{
				DataRow selRow = SelectedRow;
				if (selRow != null)
				{
					object obj=selRow[0];
					if(obj is int)
					{
						int id = (int)obj;
						using (GmConnection conn = App.CreateConnection())
						{
							Analysis.Remove(conn, id);
						}
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
