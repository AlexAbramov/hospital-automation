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
	public partial class IncomingDocumentForm : Form
	{
		Document doc;
		DataTable dataTable = new DataTable();
        DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
//        int SelectedId { get { DataRow dr = SelectedRow; return dr != null ? (int)dr[0] : 0; } }
        public Document Document { get { return doc; } }
		public IncomingDocumentForm()
		{
			InitializeComponent();
		}
		public IncomingDocumentForm(Document doc)
		{
			InitializeComponent();
			this.doc = doc;
			FormUtils.Init(this);
		}

		private void DocumentForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
            UpdateControls();
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
            chkCompleted.Checked = doc.completed;
            if (doc.completed)
            {
                Control[] controls ={btnAdd,btnRemove,btnOk,dpDate};
                foreach (Control ctl in controls) ctl.Enabled = false;
                chkCompleted.Enabled = false;
                ucSelectProduct.Enabled = false;
            }
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
                doc.completed = chkCompleted.Checked;
                using (GmConnection conn = App.CreateConnection())
				{
					trans=conn.BeginTransaction();

					try
					{
						// Documents
						doc.Save(conn, trans);
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            if (dr.RowState != DataRowState.Deleted)
                            {
                                dr["DocumentId"] = doc.Id;
                            }
                        }

						// StoreProducts
						foreach (DataRow dr in dataTable.Rows)
						{
                            switch(dr.RowState)
                            {
                                case DataRowState.Added:
                                    dr["CurrentCount"] = dr["Count"];
                                    StoreProduct sp = new StoreProduct(dr);
                                    sp.Save(conn, trans);
                                    dr["StoreProductId"] = sp.Id;
                                    break;
                                case DataRowState.Modified:
                                    StoreProduct sp2 = new StoreProduct(dr);
                                    sp2.Save(conn, trans);
                                    break;
 /*                               case DataRowState.Deleted:
                                    int id=(int)dr["StoreProductId"];
                                    StoreProduct.Remove(conn,id,trans);
                                    break;*/
                            }
						}

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

		private void ucSelectProduct_OnSelected(object sender, EventArgs e)
		{
            AddStoreProduct();
		}

        private void AddStoreProduct()
        {
            try
            {
                DataRow productRow = ucSelectProduct.SelectedRow;
                if (productRow != null)
                {
                    DataRow dr = dataTable.NewRow();
                    dr["Id"] = 0;
                    dr["DocumentId"] = doc.Id;
                    dr["StoreProductId"] = 0;
                    dr["Count"] = 1;

                    dr["ProductId"] = productRow["Id"];
                    dr["Price"] = 0;
                    dr["CurrentCount"] = 0;
                    dr["ReservedCount"] = 0;
                    dr["Series"] = "";
                    dr["ExpiredDate"] = DBNull.Value;

                    dr["Code"] = productRow["Code"];
                    dr["Name"] = productRow["Name"];

                    StoreProductForm form = new StoreProductForm(dr,doc.completed);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dataTable.Rows.Add(dr);
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
            AddStoreProduct();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void Remove()
        {
            try
            {
                DataRow dr = SelectedRow;
                if (dr != null)
                {
                    //                    int id = (int)dr["Id"];
                    dataTable.Rows.Remove(dr);
                    //                    dr["Status"] = (int)Status.Removed;
                    /*                    using (GmConnection conn = App.CreateConnection())
                                        {
                                            Medicament.SetStatus(conn, id, Status.Removed);
                                        }*/
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

        void UpdateControls()
        {
            if (!doc.completed)
            {
                bool rowSelected = gridView.SelectedRows.Count > 0;
                btnEdit.Enabled = rowSelected;
                btnRemove.Enabled = rowSelected;
            }
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            try
            {
                DataRow dataRow = SelectedRow;
                if (dataRow != null)
                {
                    StoreProductForm form = new StoreProductForm(dataRow,doc.completed);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
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