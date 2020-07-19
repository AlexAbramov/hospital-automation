using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Utils;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.Forms
{
	public partial class ConfigForm : Form
	{
		bool ignoreClosing = false;
        ConfigRecord configRecord;
		Config config;
		bool readOnly;
		public ConfigForm(ConfigRecord configRecord, bool readOnly)
		{
			InitializeComponent();
			this.readOnly = readOnly;
            this.configRecord = configRecord;
            config = (Config)configRecord.config.Clone();
			ucReports.Init(config);
			ucGuiConfig.Init(config);
			ucHandbookGroups.Init(config);
			ucDepartmentConfig.Init(config);
			ucConfigRecord.Init(configRecord, readOnly);
			FormUtils.Init(this);
			if (readOnly)
			{
				btnSave.Text = "Закрыть";
				btnCancel.Visible = !readOnly;
			}
		}

		private void ConfigForm_Load(object sender, EventArgs e)
		{
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			if (!readOnly)
			{
				using (WaitCursor wc = new WaitCursor())
				{
					ucDepartmentConfig.Save();
					//				App.Config.SaveAs(Config.PrevFilePath);
					App.Instance.SetConfig(config,ucConfigRecord.Comment, 0);
				}
			}
			ignoreClosing = true;
		}

		private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!readOnly && !ignoreClosing && FormUtils.Ask("Cохранить изменения?")) Save();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ignoreClosing = true;
		}
	}
}