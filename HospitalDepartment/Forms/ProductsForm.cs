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
	public partial class ProductsForm : Form
	{
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public ProductsForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
		}

		private void ProductsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
		}

		void LoadData()
		{
			string cmdText= @"
select Products.*, Medicaments.Name as MedicamentName, BaseUnits.Name as BaseUnitName
from Products 
left join Medicaments on Medicaments.Id=MedicamentId
left join BaseUnits on BaseUnits.Id=BaseUnitId
";
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter(cmdText);
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
					Product product = null;
					using (GmConnection conn = App.CreateConnection())
					{
						product = Product.GetProduct(conn, id);
					}
					if (product != null)
					{
						ProductForm form = new ProductForm(product);
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

		private void UpdateRow(DataRow dr, ProductForm form)
		{
			if (dr != null)
			{
				Product product = form.Product;
				dr["Id"] = product.Id;
				dr["Code"] = product.code;
				dr["Name"] = product.name;
				dr["PackedNumber"] = product.packedNumber;
				dr["MedicamentId"] = product.medicamentId;
				dr["MedicamentName"] = form.MedicamentName;
				dr["Maker"] = product.maker;
				dr["BaseUnitId"] = product.baseUnitId;
				dr["BaseUnitName"] = form.BaseUnitName;
				dr["UnitCount"] = product.unitCount;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				Product user = new Product();
				ProductForm form = new ProductForm(user);
				if (form.ShowDialog() == DialogResult.OK)
				{
					DataRow newRow = dataTable.NewRow();
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