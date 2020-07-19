using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class DiagnosesForm : Form
	{
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public DiagnosesForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
			LoadData();
		}

		private void DiagnosesForm_Load(object sender, EventArgs e)
		{
		}

		void LoadData()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter("select * from Diagnoses");
				dataAdapter.Fill(dataTable);
			}
			gridView.DataSource = dataTable;
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
						Diagnosis diagnosis = null;
						using (GmConnection conn = App.CreateConnection())
						{
							diagnosis = Diagnosis.GetDiagnosis(conn, id);
						}
						if (diagnosis != null)
						{
							DiagnosisForm form = new DiagnosisForm(diagnosis);
							if (form.ShowDialog() == DialogResult.OK)
							{
								DataRow dr = SelectedRow;
								if (dr != null)
								{
									dr["Name"] = diagnosis.name;
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

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					Diagnosis diagnosis = new Diagnosis();
					DiagnosisForm form = new DiagnosisForm(diagnosis);
					if (form.ShowDialog() == DialogResult.OK)
					{
						DataRow newRow = dataTable.NewRow();
						dataTable.Rows.Add(newRow);
						newRow["Id"] = diagnosis.Id;
						newRow["Name"] = diagnosis.name;
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}
	}
}