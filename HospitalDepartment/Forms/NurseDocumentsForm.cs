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
using HospitalDepartment.Reports;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.Forms
{
	public partial class NurseDocumentsForm : Form
	{
		DataTable dataTable = new DataTable();

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public NurseDocumentsForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
		}

		private void NurseDocumentsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
            List<ReportBuilderId> list = new List<ReportBuilderId>();
            list.Add(ReportBuilderId.PrescriptionsOrder);
            ucSelectReport.Init(list);
        }

		void LoadData()
		{
			string cmdText= @"
select Documents.*, Users.Name as UserName
from Documents 
left join Users on Users.Id=UserId
where Documents.DocumentTypeId=@DocumentTypeId";
			using (GmConnection conn = App.CreateConnection())
			{
                GmCommand cmd = conn.CreateCommand(cmdText);
                cmd.AddInt("DocumentTypeId", (int)DocumentTypeId.PrescriptionsOrder);
				conn.Fill(dataTable, cmd);
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
					Document doc = null;
					using (GmConnection conn = App.CreateConnection())
					{
						doc = Document.GetDocument(conn, id);
					}
					if (doc != null)
					{
						if (OpenDocument(doc))
						{
//							UpdateRow(SelectedRow,doc);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

/*		private void UpdateRow(DataRow dr, Document doc)
		{
			if (dr != null)
			{
				Document product = form.Document;
				dr["Id"] = product.Id;
				dr["Code"] = product.code;
				dr["Name"] = product.name;
				dr["PackedNumber"] = product.packedNumber;
				dr["MedicamentId"] = product.medicamentId;
				dr["Maker"] = product.maker;
				dr["MedicamentName"] = form.MedicamentName;
			}
		}*/

		public static bool OpenDocument(Document doc)
		{
			Form form = null;
			switch (doc.documentTypeId)
			{
				case DocumentTypeId.PrescriptionsOrder:
					form = new PrescriptionsOrderForm(doc,false);
					break;
			}
			if (form != null)
			{
				return form.ShowDialog() == DialogResult.OK;
			}
			return false;
		}

		public static Document CreateDocument(DocumentTypeId documentTypeId)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					Document doc = new Document(documentTypeId);
                    doc.userId = App.Instance.UserId;
					if (OpenDocument(doc)) return doc;
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
			return null;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow selRow = SelectedRow;
				if (selRow != null)
				{
					bool completed = (bool)selRow["Completed"];
					if (completed)
					{
						FormUtils.Message("”комплектованный документ не может быть удален.");
						return;
					}
					int id = (int)selRow[0];
					using (GmConnection conn = App.CreateConnection())
					{
						Document.Remove(conn, id);
                        Document.RemoveDocumentProducts(conn, id);
					}
					dataTable.Rows.Remove(selRow);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Document doc=CreateDocument(DocumentTypeId.PrescriptionsOrder);
            if (doc != null && doc.Id != 0)
            {
                dataTable.Clear();
                dataTable.Constraints.Clear();
                dataTable.Columns.Clear();
                LoadData();
            }
        }

        private void ucSelectReport_OnShowReport(object sender, HospitalDepartment.UserControls.SelectReportEventArgs e)
        {
            int id = SelectedId;
            if (id != 0)
            {
                Document doc = null;
                using (GmConnection conn = App.CreateConnection())
                {
                    doc = Document.GetDocument(conn, id);
                }
                if (doc != null)
                {
                    switch (BaseReportBuilder.GetReportBuilderId(e.Report.ReportBuilderId))
                    {
                        case ReportBuilderId.PrescriptionsOrder:
                            e.ReportBuilder = new PrescriptionsOrderReportBuilder(App.ConnectionFactory, App.Config, doc);
                            break;
                    }
                }
            }
        }

	}
}