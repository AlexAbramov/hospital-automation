using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
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
	public partial class ExportTablesForm : Form
	{
		ExportTable SelectedExportTable { get { return GridViewUtils.GetSelectedItem(gridView) as ExportTable; } }

		public ExportTablesForm()
		{
			InitializeComponent();
		}

		private void ExportTablesForm_Load(object sender, EventArgs e)
		{
			FormUtils.Init(this);
			LoadData();
			dlgOpenFile.InitialDirectory = PathUtils.BaseDirectory;
		}

		private void LoadData()
		{
			gridView.DataSource = App.Config.exportTables;
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			Import();
		}

		private void Import()
		{
			try
			{
				ExportTable et = SelectedExportTable;
				if (et != null)
				{
					if (dlgOpenFile.ShowDialog() == DialogResult.OK)
					{
						using (WaitCursor wc = new WaitCursor())
						{
							Import(et, dlgOpenFile.FileName);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void Import(ExportTable et, string filePath)
		{
			DbDataAdapter da;
			DataTable dt=new DataTable();
			using (GmConnection conn = App.CreateConnection())
			{
				da = conn.CreateDataAdapter("select top 0 * from "+et.name);
				da.Fill(dt);
			}
			CsvConverter cc = new CsvConverter();
			int lineCount=0;
			using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
			{
				List<string> sc = new List<string>();
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					lineCount++;
					if (lineCount >= 4)
					{
						cc.Parse(line, sc);						
						DataRow dr=dt.NewRow();
						dr[1] = sc[0];//code
						dr[7] = sc[1];//mkb
						dr[2] = sc[2];//name
						dr[3] = GetInt(sc[3]);
						dr[4] = GetInt(sc[4]);
						dr[5] = GetInt(sc[5]);
						dr[6] = GetInt(sc[6]);
						dt.Rows.Add(dr);
					}
				}
			}
			using (GmConnection conn = App.CreateConnection())
			{
				DbCommandBuilder bld = conn.CreateCommandBuilder();
				bld.DataAdapter = da;
				da.Update(dt);
			}
			MessageBox.Show("Импортировано записей: " + lineCount);
		}

		private object GetInt(string p)
		{
			if (p.Trim().Length == 0) return 0;
			return int.Parse(p);
		}
	}
}