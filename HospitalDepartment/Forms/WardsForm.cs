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
	public partial class WardsForm : Form
	{
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public WardsForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
		}

		private void WardsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
		}

		void LoadData()
		{
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter("select Wards.Id, Number, Name as WardTypeName, NumberOfBeds from Wards left join WardTypes on WardTypes.Id=WardTypeId");
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
				int id = SelectedId;
				if (id != 0)
				{
					Ward ward = null;
					using (GmConnection conn = App.CreateConnection())
					{
						ward = Ward.GetWard(conn, id);
					}
					if (ward != null)
					{
						WardForm form = new WardForm(ward);
						if (form.ShowDialog() == DialogResult.OK)
						{
							UpdateRow(SelectedRow,form);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void UpdateRow(DataRow dr, WardForm form)
		{
			Ward ward = form.Ward;
			dr["Id"] = ward.Id;
			dr["Number"] = ward.number;
			dr["NumberOfBeds"] = ward.numberOfBeds;
			dr["WardTypeName"] = form.WardTypeName;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				Ward ward = new Ward();
				WardForm form = new WardForm(ward);
				if (form.ShowDialog() == DialogResult.OK)
				{
					DataRow newRow=dataTable.NewRow();
					dataTable.Rows.Add(newRow);
					UpdateRow(newRow, form);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}
	}
}