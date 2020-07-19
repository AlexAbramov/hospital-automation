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
	public interface IConfigRecordContainer
	{
		bool SetConfig(Config config, string comment, int restoredId);
	}

	public partial class ConfigRecordsForm : Form
	{
		int maxId = 0;
		DataTable dataTable;
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public ConfigRecordsForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
		}

		private void ConfigRecordsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
			UpdateControls();
		}

		private void UpdateControls()
		{
			int selId=SelectedId;
			btnRestore.Enabled = selId > 0 && selId < maxId;
		}

		void LoadData()
		{
			dataTable = new DataTable();
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter("select ConfigRecords.Id, RestoredId, Name, Version, Time from ConfigRecords left join Users on Users.Id=UserId");
				dataAdapter.Fill(dataTable);
			}
			foreach (DataRow dr in dataTable.Rows)
			{
				int id = (int)dr[0];
				if (maxId < id) maxId = id;
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
					ConfigRecord configRecord = null;
					using (GmConnection conn = App.CreateConnection())
					{
						configRecord = ConfigRecord.GetConfigRecord(conn, id);
					}
					if (configRecord != null)
					{
						ConfigForm form = new ConfigForm(configRecord,true);
						if (form.ShowDialog() == DialogResult.OK)
						{
//							UpdateRow(SelectedRow,form);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

/*		private void UpdateRow(DataRow dr, ConfigRecordForm form)
		{
			ConfigRecord configRecord = form.ConfigRecord;
			dr["Id"] = configRecord.Id;
			dr["Number"] = configRecord.number;
			dr["NumberOfBeds"] = configRecord.numberOfBeds;
			dr["ConfigRecordTypeName"] = form.ConfigRecordTypeName;
		}*/

		private void btnRestore_Click(object sender, EventArgs e)
		{
			try
			{
				if (maxId == App.ConfigRecord.Id)
				{
					int selId = SelectedId;
					//				btnRestore.Enabled = selId > 0 && selId < maxId;
					string s = string.Format("Вы уверены, что хотите восстановить конфигурацию {0} и отменить конфигурацию {1}?", selId, maxId);
					if (MessageBoxUtils.Ask(s))
					{
						using (WaitCursor wc = new WaitCursor())
						{
							ConfigRecord configRecord = null;
							using (GmConnection conn = App.CreateConnection())
							{
								configRecord = ConfigRecord.GetConfigRecord(conn, selId);
							}
							ConfigUpdate.CheckUpdate(configRecord.config);
							App.Instance.SetConfig(configRecord.config, "Конфигурация восстановлена.", configRecord.Id);
							LoadData();
							UpdateControls();
						}
						MessageBox.Show("Конфигурация успешно восстановлена.");
					}
				}
				else MessageBox.Show("В базе данных обнаружена новая конфигурация. Для восстановления старой конфигурации перезапустите программу.");
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void gridView_SelectionChanged(object sender, EventArgs e)
		{
			UpdateControls();
		}

		private void btnExportToXML_Click(object sender, EventArgs e)
		{
			try
			{
				int id = SelectedId;
				if (id != 0)
				{
					dlgSaveFile.FileName = string.Format("HosDepConfig{0}.xml", id);
					if (dlgSaveFile.ShowDialog() == DialogResult.OK)
					{
						using (WaitCursor wc = new WaitCursor())
						{
							ConfigRecord configRecord = null;
							using (GmConnection conn = App.CreateConnection())
							{
								configRecord = ConfigRecord.GetConfigRecord(conn, id);
							}
							if (configRecord != null)
							{
								configRecord.config.Serialize(dlgSaveFile.FileName);
							}
						}
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