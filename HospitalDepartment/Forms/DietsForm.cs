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
using CardiologyDepartment.Utils;

namespace CardiologyDepartment.Forms
{
	public partial class DietsForm : Form
	{
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
//		HandbookRecord SelectedHandbook { get { DataRow dr = SelectedRow; return dr!=null? new HandbookRecord(dr): null; } }

		public DietsForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
			LoadData();
		}

		private void DietsForm_Load(object sender, EventArgs e)
		{
		}

		void LoadData()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter("select * from Diets");
				dataAdapter.Fill(dataTable);
			}
			dataTable.DefaultView.Sort = "Number";
			gridView.DataSource = dataTable;
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
	}
}