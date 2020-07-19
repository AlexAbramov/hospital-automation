using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Geomethod.Windows.Forms;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment.Forms
{
	/// <summary>
	/// Summary description forAppConfigForm.
	/// </summary>
	public partial class AppConfigForm : System.Windows.Forms.Form
	{
		#region Fields
		AppConfig appConfig;
		bool changed = false;
		#endregion

		#region Properties
//		public string ConnectionString { get { return tbConnStr.Text; } set { tbConnStr.Text = value; } }
//		public string ProviderName { get { return cbDataProvider.Text; } set { cbDataProvider.Text = value; } }
		#endregion

		#region Construction
		public AppConfigForm()
		{
			InitializeComponent();
			appConfig = (AppConfig)App.AppConfig.Clone();
		}
		#endregion

		private void AppConfigForm_Load(object sender, System.EventArgs e)
		{
//			toolTip.SetToolTip(lblConnect, Locale.Get());
			MinimumSize=Size;
			MaximumSize = new Size(1024, MinimumSize.Height);
			LoadData();
			UpdateControls();
		}

		private void LoadData()
		{
			tbProviderName.Text = appConfig.dataProvider;
			tbConnStr.Text = appConfig.connStr;
			nudAutoBackupPeriod.Value = appConfig.autoBackupPeriod;
			tbAutoBackupPath.Text = appConfig.autoBackupPath;
			tbAutoBackupSecondPath.Text = appConfig.autoBackupSecondPath;
		}

		void UpdateControls()
		{
			btnOk.Enabled = changed;
		}

		private void toolTip_Popup(object sender, PopupEventArgs e)
		{
		}

		private void btnResetConnOptions_Click(object sender, EventArgs e)
		{
			appConfig.dataProvider = "";
			appConfig.connStr = "";
			tbProviderName.Text = "";
			tbConnStr.Text = "";
			changed = true;
			UpdateControls();
		}

		private void btnResetAutoBackupOptions_Click(object sender, EventArgs e)
		{
			appConfig.autoBackupPeriod = 0;
			appConfig.autoBackupPath = "";
			appConfig.autoBackupSecondPath = "";
			nudAutoBackupPeriod.Value = 0;
			tbAutoBackupPath.Text = "";
			tbAutoBackupSecondPath.Text = "";
			changed = true;
			UpdateControls();
		}

		private void btnAutoBackupPath_Click(object sender, EventArgs e)
		{
			if(appConfig.autoBackupPath.Length>0) dlgFolderBrowser.SelectedPath=appConfig.autoBackupPath;
			if (dlgFolderBrowser.ShowDialog() == DialogResult.OK)
			{
				tbAutoBackupPath.Text = dlgFolderBrowser.SelectedPath;
				appConfig.autoBackupPath = dlgFolderBrowser.SelectedPath;
				changed = true;
				UpdateControls();
			}
		}

		private void btnAutoBackupSecondPath_Click(object sender, EventArgs e)
		{
			if (appConfig.autoBackupSecondPath.Length > 0) dlgFolderBrowser.SelectedPath = appConfig.autoBackupSecondPath;
			if (dlgFolderBrowser.ShowDialog() == DialogResult.OK)
			{
				tbAutoBackupSecondPath.Text = dlgFolderBrowser.SelectedPath;
				appConfig.autoBackupSecondPath = dlgFolderBrowser.SelectedPath;
				changed = true;
				UpdateControls();
			}
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					App.AppConfig.Serialize(AppConfig.FilePath + ".bak");
					appConfig.Serialize(AppConfig.FilePath);
				}
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void nudAutoBackupPeriod_ValueChanged(object sender, EventArgs e)
		{
			appConfig.autoBackupPeriod = (int)nudAutoBackupPeriod.Value;
			changed = true;
			UpdateControls();
		}

	}
}
