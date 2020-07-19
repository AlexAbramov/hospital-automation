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

namespace HospitalDepartment.Forms
{
	public partial class OutgoingDocumentForm : Form
	{
		Document doc;
		DataTable dataTable = new DataTable();
		public Document Document { get { return doc; } }
		public OutgoingDocumentForm()
		{
			InitializeComponent();
		}
		public OutgoingDocumentForm(Document doc)
		{
			InitializeComponent();
			this.doc = doc;
			FormUtils.Init(this);
			gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
		}

		private void DocumentForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
		}

		void LoadData()
		{
			string cmdText = @"
select DocumentProducts.*, StoreProducts.*, Products.Code, Products.Name
from DocumentProducts
left join StoreProducts on StoreProducts.Id=StoreProductId
left join Products on Products.Id=ProductId 
where DocumentId=@DocumentId";
			using (GmConnection conn = App.CreateConnection())
			{
				GmCommand cmd = conn.CreateCommand(cmdText);
				cmd.AddInt("DocumentId",doc.Id);
				cmd.Fill(dataTable);
			}
			gridView.DataSource = dataTable;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			DbTransaction trans = null;
			try
			{
				doc.userId = App.Instance.UserId;
				using (GmConnection conn = App.CreateConnection())
				{
					trans=conn.BeginTransaction();

					try
					{
						// Documents
						doc.Save(conn, trans);
						foreach (DataRow dr in dataTable.Rows) dr["DocumentId"] = doc.Id;

						// StoreProducts
/*						foreach (DataRow dr in dataTable.Rows)
						{
							if (dr.RowState == DataRowState.Added)
							{
								dr["CurrentCount"] = dr["Count"];
								StoreProduct sp = new StoreProduct(dr);
								sp.Save(conn, trans);
								dr["StoreProductId"] = sp.Id;
							}
						}*/

						// DocumentProducts
						DbCommandBuilder bld = conn.CreateCommandBuilder();
						bld.ConflictOption = ConflictOption.OverwriteChanges;
						DbDataAdapter dataAdapter = conn.CreateDataAdapter("select top 0 * from DocumentProducts", trans);
						bld.DataAdapter = dataAdapter;
						dataAdapter.Update(dataTable);
						trans.Commit();
					}
					catch (Exception ex)
					{
						trans.Rollback();
						throw ex;
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

/*		private void ucSelectStoreProduct_OnSelected(object sender, EventArgs e)
		{
			
			DataRow productRow = ucSelectStoreProduct.SelectedRow;
			if (productRow != null)
			{
				DataRow dr=dataTable.NewRow();
				dr["Id"] = 0;
				dr["DocumentId"] = doc.Id;
				dr["StoreProductId"] = 0;
				dr["Count"] = 1;

				dr["ProductId"] = productRow["Id"];
				dr["Price"] = 0;
				dr["CurrentCount"] = 0;
				dr["ReservedCount"] = 0;

				dr["Code"] = productRow["Code"];
				dr["Name"] = productRow["Name"];
				dataTable.Rows.Add(dr);
			}
		}*/

		private void ucSelectStoreProduct_OnSelected(object sender, EventArgs e)
		{
			DataRow productRow = ucSelectStoreProduct.SelectedRow;
			if (productRow != null)
			{
				DataRow dr = dataTable.NewRow();
				dr["Id"] = 0;
				dr["DocumentId"] = doc.Id;
				dr["StoreProductId"] = productRow["Id"];
				dr["Count"] = 1;
				dr["ExpiredDate"] = productRow["ExpiredDate"];

				dr["ProductId"] = productRow["Id"];
				dr["Price"] = productRow["Price"];
				dr["CurrentCount"] = productRow["CurrentCount"];
				dr["ReservedCount"] = productRow["ReservedCount"];

				dr["Code"] = productRow["Code"];
				dr["Name"] = productRow["ProductName"];
				//				dr["BaseUnitName"] = productRow["BaseUnitName"];
//				dr["UnitCount"] = productRow["UnitCount"];
				dataTable.Rows.Add(dr);
			}
		}
	}
}