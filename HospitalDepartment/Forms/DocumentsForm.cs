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
using Geomethod.Windows.Forms;

namespace HospitalDepartment.Forms
{
	public partial class DocumentsForm : Form
	{
		DataTable dataTable = new DataTable();

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public DocumentsForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
		}

		private void DocumentsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
		}

		void LoadData()
		{
			string cmdText= @"
select Documents.*, Users.Name as UserName, DocumentTypes.Name as DocumentTypeName
from Documents 
left join Users on Users.Id=UserId
left join DocumentTypes on DocumentTypes.Id=DocumentTypeId";
			using (GmConnection conn = App.CreateConnection())
			{
				conn.Fill(dataTable,cmdText);
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
							UpdateRow(SelectedRow,doc);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void UpdateRow(DataRow dr, Document doc)
		{
			if (dr != null)
			{
				dr["Completed"] = doc.completed;
			}
		}

		private void btnCreateIncomingDocument_Click(object sender, EventArgs e)
		{
			CreateDocumentInst(DocumentTypeId.Incoming);
		}

		private void btnCreateOutgoingDocument_Click(object sender, EventArgs e)
		{
			CreateDocumentInst(DocumentTypeId.Outgoing);
		}

		private void CreateDocumentInst(DocumentTypeId documentTypeId)
		{
/*			Document doc=CreateDocument(documentTypeId);
			if(doc!=null)
			{
			}*/
		}

		public static bool OpenDocument(Document doc)
		{
			Form form = null;
			switch (doc.documentTypeId)
			{
				case DocumentTypeId.Incoming:
					form = new IncomingDocumentForm(doc);
					break;
				case DocumentTypeId.Outgoing:
					form = new OutgoingDocumentForm(doc);
					break;
                case DocumentTypeId.PrescriptionsOrder:
                    form = new PrescriptionsOrderForm(doc, true);
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
                        //!!! doc products & store products
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