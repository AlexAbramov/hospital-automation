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
using Geomethod.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class AnalysisTypesForm : Form
	{
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
//		HandbookRecord SelectedHandbook { get { DataRow dr = SelectedRow; return dr!=null? new HandbookRecord(dr): null; } }

		public AnalysisTypesForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
		}

		private void AnalysisTypesForm_Load(object sender, EventArgs e)
		{
			try
			{
				LoadData();
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}

		}

		void LoadData()
		{
			ComboBoxUtils.Fill(colHandbookGroupId, App.Config.GetHandbookGroups("analysis"));
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter("select * from AnalysisTypes");
				dataAdapter.Fill(dataTable);
			}
			dataTable.DefaultView.Sort = "Name";
			gridView.DataSource = dataTable;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Save();
			Close();
		}

		private void Save()
		{
			try
			{
				using (GmConnection conn = App.CreateConnection())
				{
					DbCommandBuilder bld = conn.CreateCommandBuilder();
					bld.DataAdapter = dataAdapter;
					dataAdapter.Update(dataTable);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
//			Open();
		}

		private void Open()
		{
/*			try
			{
				HandbookRecord hr = SelectedHandbook;
				if (hr != null)
				{
					HandbookForm form = new HandbookForm(hr);
					if (form.ShowDialog() == DialogResult.OK)
					{
						DataRow dr = SelectedRow;
						if (dr != null)
						{ 
							dr["Name"]=hr.name;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}*/
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void gridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			Log.Exception(e.Exception);
		}

	}
}