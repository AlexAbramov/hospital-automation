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
	public partial class PrescriptionsOrderForm : Form
	{
		Document doc;
		DataTable dataTable = new DataTable();
		public Document Document { get { return doc; } }
        bool storekeeperMode = false;
/*		public PrescriptionsOrderForm()
		{
			InitializeComponent();
		}*/
		public PrescriptionsOrderForm(Document doc, bool storekeeperMode)
		{
			InitializeComponent();
			this.doc = doc;
            this.storekeeperMode = storekeeperMode;
            if (doc.IsNew)
            {
                gridView.Visible = false;
                base.Height -= gridView.Height;
                if (doc.documentData.patients.Count == 0 && App.Instance.UserInfo.HasWatching)
                {
                    doc.documentData.patients.AddRange(App.Instance.UserInfo.Watching.Patients);
                }
            }
            else
            {
			    gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
			FormUtils.Init(this);
		}

		private void DocumentForm_Load(object sender, EventArgs e)
		{
            if (!DesignMode)
            {
                LoadDocument();
                LoadData();
                bool canEditRows=storekeeperMode && !doc.completed;
                gridView.ReadOnly = !canEditRows;
                btnOk.Visible = doc.IsNew || canEditRows;
                chkCompleted.Enabled = storekeeperMode && !doc.completed;
            }
		}

        private void LoadDocument()
        {
            dpDate.Value = doc.date;
            nudNDays.Value = doc.nDays;
            chkCompleted.Checked = doc.completed;
            lblUser.Text += App.Instance.AppCache.GetUserName(doc.userId);
            foreach (PrescriptionType pt in App.Instance.AppCache.PrescriptionTypes)
            {
                lbPrescriptionTypes.Items.Add(pt, doc.documentData.HasPrescriptionType(pt.Id));
            }
            gbParams.Enabled = doc.IsNew;
        }

        private void SaveDocument()
        {
            doc.date = dpDate.Value;
            doc.nDays = (int)nudNDays.Value;
            doc.completed = chkCompleted.Checked;
            doc.documentData.prescriptionTypes.Clear();
            foreach (PrescriptionType prescriptionType in lbPrescriptionTypes.CheckedItems)
            {
                doc.documentData.prescriptionTypes.Add(prescriptionType.Id);
            }
        }

		void LoadData()
		{
			string cmdText="";
            if (doc.IsNew) cmdText="select top 0 * from DocumentProducts";
            else cmdText= @"
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
            if(gridView.Visible)
                gridView.DataSource = dataTable;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
            try
            {
                bool closeForm = true;
                if (doc.IsNew)
                {
                    SaveDocument();
                    int nRows = GenerateData();
                    if (nRows > 0)
                    {
                        SaveData();
                    }
                    else
                    {
                        closeForm = false;
                        MessageBox.Show("Не найдено назначений соответствующих заданным условиям.");
                    }
                }
                else
                {
                    SaveData();
                }
                if (closeForm)
                {
                    base.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
		}

		private void SaveData()
		{
			try
			{
				doc.userId = App.Instance.UserId;
			    DbTransaction trans = null;
				using (GmConnection conn = App.CreateConnection())
				{
					trans=conn.BeginTransaction();

					try
					{
						// Documents
                        if (doc.IsNew)
                        {
                            doc.Save(conn, trans);
                            foreach (DataRow dr in dataTable.Rows) dr["DocumentId"] = doc.Id;
                        }
                        else if(storekeeperMode && chkCompleted.Checked!=doc.completed)
                        {
                            doc.completed = chkCompleted.Checked;
                            doc.Save(conn, trans);
                        }

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

        private void lbPrescriptionTypes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
//            e.Index
//            lbPrescriptionTypes.CheckedIndices
            UpdateControls();
        }

        private void UpdateControls()
        {
        }

        private int GenerateData()
        {
            if (doc.documentData.patients.Count == 0 || doc.documentData.prescriptionTypes.Count == 0) return 0;
            List<Prescription> prescriptions = new List<Prescription>();
            using (GmConnection conn = App.CreateConnection())
            {
                Prescription.GetPrescriptions(conn, prescriptions, doc.documentData.patients, doc.documentData.prescriptionTypes, doc.date, doc.date.Date.AddDays(doc.nDays), false);
            }
            Dictionary<int, decimal> dict = new Dictionary<int, decimal>();
            foreach (Prescription prescription in prescriptions)
            {
                decimal d = prescription.GetCount(doc.date, doc.nDays);
                if (d > 0)
                {
                    int storeProductId=prescription.storeProductId;
                    if (dict.ContainsKey(storeProductId)) dict[storeProductId] += d;
                    else dict[storeProductId] = d;
                }
            }
            foreach (KeyValuePair<int, decimal> pair in dict)
            {
                DataRow dr=dataTable.NewRow();
                dr["StoreProductId"]=pair.Key;
                dr["Count"] = 0;
                dr["PlannedCount"]=pair.Value;
                dataTable.Rows.Add(dr);
            }
            return dict.Count;
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

/*		private void ucSelectStoreProduct_OnSelected(object sender, EventArgs e)
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
		}*/
	}
}