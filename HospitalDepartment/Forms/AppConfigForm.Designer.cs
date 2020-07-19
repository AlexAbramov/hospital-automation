using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HospitalDepartment.Forms
{
	/// <summary>
	/// Summary description for AppConfigForm.
	/// </summary>
	partial class AppConfigForm
	{
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbConnStr = new System.Windows.Forms.TextBox();
			this.lblConnect = new System.Windows.Forms.Label();
			this.btnHelp = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.lblDataProvider = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbProviderName = new System.Windows.Forms.TextBox();
			this.btnResetConnOptions = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAutoBackupSecondPath = new System.Windows.Forms.Button();
			this.btnAutoBackupPath = new System.Windows.Forms.Button();
			this.btnResetAutoBackupOptions = new System.Windows.Forms.Button();
			this.tbAutoBackupSecondPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbAutoBackupPath = new System.Windows.Forms.TextBox();
			this.nudAutoBackupPeriod = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.dlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAutoBackupPeriod)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Location = new System.Drawing.Point(198, 259);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 9;
			this.btnOk.Text = "Сохранить";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(279, 259);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Отмена";
			// 
			// tbConnStr
			// 
			this.tbConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbConnStr.Location = new System.Drawing.Point(168, 46);
			this.tbConnStr.Name = "tbConnStr";
			this.tbConnStr.ReadOnly = true;
			this.tbConnStr.Size = new System.Drawing.Size(249, 20);
			this.tbConnStr.TabIndex = 6;
			// 
			// lblConnect
			// 
			this.lblConnect.AutoSize = true;
			this.lblConnect.Location = new System.Drawing.Point(11, 49);
			this.lblConnect.Name = "lblConnect";
			this.lblConnect.Size = new System.Drawing.Size(10, 13);
			this.lblConnect.TabIndex = 0;
			this.lblConnect.Text = " ";
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnHelp.Location = new System.Drawing.Point(360, 259);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(75, 23);
			this.btnHelp.TabIndex = 20;
			this.btnHelp.Text = "Справка";
			this.btnHelp.Visible = false;
			// 
			// toolTip
			// 
			this.toolTip.Active = false;
			this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 13);
			this.label4.TabIndex = 28;
			this.label4.Text = "Запасной каталог:";
			this.toolTip.SetToolTip(this.label4, "Запасной ");
			// 
			// lblDataProvider
			// 
			this.lblDataProvider.AutoSize = true;
			this.lblDataProvider.Location = new System.Drawing.Point(6, 22);
			this.lblDataProvider.Name = "lblDataProvider";
			this.lblDataProvider.Size = new System.Drawing.Size(108, 13);
			this.lblDataProvider.TabIndex = 22;
			this.lblDataProvider.Text = "Поставщик данных:";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tbProviderName);
			this.groupBox1.Controls.Add(this.btnResetConnOptions);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblDataProvider);
			this.groupBox1.Controls.Add(this.lblConnect);
			this.groupBox1.Controls.Add(this.tbConnStr);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(423, 105);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Соединение с базой данных";
			// 
			// tbProviderName
			// 
			this.tbProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbProviderName.Location = new System.Drawing.Point(168, 19);
			this.tbProviderName.Name = "tbProviderName";
			this.tbProviderName.ReadOnly = true;
			this.tbProviderName.Size = new System.Drawing.Size(249, 20);
			this.tbProviderName.TabIndex = 25;
			// 
			// btnResetConnOptions
			// 
			this.btnResetConnOptions.Location = new System.Drawing.Point(168, 72);
			this.btnResetConnOptions.Name = "btnResetConnOptions";
			this.btnResetConnOptions.Size = new System.Drawing.Size(75, 23);
			this.btnResetConnOptions.TabIndex = 24;
			this.btnResetConnOptions.Text = "Сброс";
			this.btnResetConnOptions.UseVisualStyleBackColor = true;
			this.btnResetConnOptions.Click += new System.EventHandler(this.btnResetConnOptions_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "Строка соединени с БД:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.btnAutoBackupSecondPath);
			this.groupBox2.Controls.Add(this.btnAutoBackupPath);
			this.groupBox2.Controls.Add(this.btnResetAutoBackupOptions);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.tbAutoBackupSecondPath);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tbAutoBackupPath);
			this.groupBox2.Controls.Add(this.nudAutoBackupPeriod);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 123);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(423, 130);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Автосохранение БД";
			// 
			// btnAutoBackupSecondPath
			// 
			this.btnAutoBackupSecondPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAutoBackupSecondPath.Location = new System.Drawing.Point(391, 69);
			this.btnAutoBackupSecondPath.Name = "btnAutoBackupSecondPath";
			this.btnAutoBackupSecondPath.Size = new System.Drawing.Size(26, 23);
			this.btnAutoBackupSecondPath.TabIndex = 31;
			this.btnAutoBackupSecondPath.Text = "...";
			this.btnAutoBackupSecondPath.UseVisualStyleBackColor = true;
			this.btnAutoBackupSecondPath.Click += new System.EventHandler(this.btnAutoBackupSecondPath_Click);
			// 
			// btnAutoBackupPath
			// 
			this.btnAutoBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAutoBackupPath.Location = new System.Drawing.Point(391, 43);
			this.btnAutoBackupPath.Name = "btnAutoBackupPath";
			this.btnAutoBackupPath.Size = new System.Drawing.Size(26, 23);
			this.btnAutoBackupPath.TabIndex = 30;
			this.btnAutoBackupPath.Text = "...";
			this.btnAutoBackupPath.UseVisualStyleBackColor = true;
			this.btnAutoBackupPath.Click += new System.EventHandler(this.btnAutoBackupPath_Click);
			// 
			// btnResetAutoBackupOptions
			// 
			this.btnResetAutoBackupOptions.Location = new System.Drawing.Point(168, 97);
			this.btnResetAutoBackupOptions.Name = "btnResetAutoBackupOptions";
			this.btnResetAutoBackupOptions.Size = new System.Drawing.Size(75, 23);
			this.btnResetAutoBackupOptions.TabIndex = 29;
			this.btnResetAutoBackupOptions.Text = "Сброс";
			this.btnResetAutoBackupOptions.UseVisualStyleBackColor = true;
			this.btnResetAutoBackupOptions.Click += new System.EventHandler(this.btnResetAutoBackupOptions_Click);
			// 
			// tbAutoBackupSecondPath
			// 
			this.tbAutoBackupSecondPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbAutoBackupSecondPath.Location = new System.Drawing.Point(168, 71);
			this.tbAutoBackupSecondPath.Name = "tbAutoBackupSecondPath";
			this.tbAutoBackupSecondPath.ReadOnly = true;
			this.tbAutoBackupSecondPath.Size = new System.Drawing.Size(217, 20);
			this.tbAutoBackupSecondPath.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "Каталог:";
			// 
			// tbAutoBackupPath
			// 
			this.tbAutoBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbAutoBackupPath.Location = new System.Drawing.Point(168, 45);
			this.tbAutoBackupPath.Name = "tbAutoBackupPath";
			this.tbAutoBackupPath.ReadOnly = true;
			this.tbAutoBackupPath.Size = new System.Drawing.Size(217, 20);
			this.tbAutoBackupPath.TabIndex = 25;
			// 
			// nudAutoBackupPeriod
			// 
			this.nudAutoBackupPeriod.Location = new System.Drawing.Point(168, 19);
			this.nudAutoBackupPeriod.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.nudAutoBackupPeriod.Name = "nudAutoBackupPeriod";
			this.nudAutoBackupPeriod.Size = new System.Drawing.Size(46, 20);
			this.nudAutoBackupPeriod.TabIndex = 24;
			this.nudAutoBackupPeriod.ValueChanged += new System.EventHandler(this.nudAutoBackupPeriod_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Период (в часах):";
			// 
			// AppConfigForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(447, 294);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AppConfigForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Настройки приложения";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.AppConfigForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAutoBackupPeriod)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox tbConnStr;
		private System.Windows.Forms.Label lblConnect;
		private System.Windows.Forms.Button btnCancel;
		private Button btnHelp;
		private IContainer components;
		private ToolTip toolTip;
		private Label lblDataProvider;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Button btnResetConnOptions;
		private Label label1;
		private Label label2;
		private Button btnResetAutoBackupOptions;
		private Label label4;
		private TextBox tbAutoBackupSecondPath;
		private Label label3;
		private TextBox tbAutoBackupPath;
		private NumericUpDown nudAutoBackupPeriod;
		private Button btnAutoBackupSecondPath;
		private Button btnAutoBackupPath;
		private TextBox tbProviderName;
		private FolderBrowserDialog dlgFolderBrowser;
	}
}