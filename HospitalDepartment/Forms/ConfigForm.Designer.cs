namespace HospitalDepartment.Forms
{
	partial class ConfigForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
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
			this.tcHandbooks = new System.Windows.Forms.TabControl();
			this.tpVersion = new System.Windows.Forms.TabPage();
			this.tpDepartment = new System.Windows.Forms.TabPage();
			this.ucDepartmentConfig = new HospitalDepartment.UserControls.DepartmentConfigUserControl();
			this.tpHandbooks = new System.Windows.Forms.TabPage();
			this.ucHandbookGroups = new HospitalDepartment.UserControls.HandbookGroupsUserControl();
			this.tpReports = new System.Windows.Forms.TabPage();
			this.ucReports = new HospitalDepartment.UserControls.ReportsUserControl();
			this.tpGui = new System.Windows.Forms.TabPage();
			this.ucGuiConfig = new HospitalDepartment.UserControls.GuiConfigUserControl();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.ucConfigRecord = new HospitalDepartment.UserControls.ConfigRecordUserControl();
			this.tcHandbooks.SuspendLayout();
			this.tpVersion.SuspendLayout();
			this.tpDepartment.SuspendLayout();
			this.tpHandbooks.SuspendLayout();
			this.tpReports.SuspendLayout();
			this.tpGui.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcHandbooks
			// 
			this.tcHandbooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcHandbooks.Controls.Add(this.tpVersion);
			this.tcHandbooks.Controls.Add(this.tpDepartment);
			this.tcHandbooks.Controls.Add(this.tpHandbooks);
			this.tcHandbooks.Controls.Add(this.tpReports);
			this.tcHandbooks.Controls.Add(this.tpGui);
			this.tcHandbooks.Location = new System.Drawing.Point(12, 12);
			this.tcHandbooks.Name = "tcHandbooks";
			this.tcHandbooks.SelectedIndex = 0;
			this.tcHandbooks.Size = new System.Drawing.Size(571, 429);
			this.tcHandbooks.TabIndex = 0;
			// 
			// tpVersion
			// 
			this.tpVersion.Controls.Add(this.ucConfigRecord);
			this.tpVersion.Location = new System.Drawing.Point(4, 22);
			this.tpVersion.Name = "tpVersion";
			this.tpVersion.Padding = new System.Windows.Forms.Padding(3);
			this.tpVersion.Size = new System.Drawing.Size(563, 403);
			this.tpVersion.TabIndex = 4;
			this.tpVersion.Text = "Версия";
			this.tpVersion.UseVisualStyleBackColor = true;
			// 
			// tpDepartment
			// 
			this.tpDepartment.Controls.Add(this.ucDepartmentConfig);
			this.tpDepartment.Location = new System.Drawing.Point(4, 22);
			this.tpDepartment.Name = "tpDepartment";
			this.tpDepartment.Padding = new System.Windows.Forms.Padding(3);
			this.tpDepartment.Size = new System.Drawing.Size(563, 403);
			this.tpDepartment.TabIndex = 3;
			this.tpDepartment.Text = "Отделение";
			this.tpDepartment.UseVisualStyleBackColor = true;
			// 
			// ucDepartmentConfig
			// 
			this.ucDepartmentConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucDepartmentConfig.Location = new System.Drawing.Point(3, 3);
			this.ucDepartmentConfig.Name = "ucDepartmentConfig";
			this.ucDepartmentConfig.Size = new System.Drawing.Size(557, 397);
			this.ucDepartmentConfig.TabIndex = 0;
			// 
			// tpHandbooks
			// 
			this.tpHandbooks.Controls.Add(this.ucHandbookGroups);
			this.tpHandbooks.Location = new System.Drawing.Point(4, 22);
			this.tpHandbooks.Name = "tpHandbooks";
			this.tpHandbooks.Padding = new System.Windows.Forms.Padding(3);
			this.tpHandbooks.Size = new System.Drawing.Size(563, 403);
			this.tpHandbooks.TabIndex = 0;
			this.tpHandbooks.Text = "Справочники";
			this.tpHandbooks.UseVisualStyleBackColor = true;
			// 
			// ucHandbookGroups
			// 
			this.ucHandbookGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucHandbookGroups.Location = new System.Drawing.Point(3, 3);
			this.ucHandbookGroups.Name = "ucHandbookGroups";
			this.ucHandbookGroups.Size = new System.Drawing.Size(557, 397);
			this.ucHandbookGroups.TabIndex = 0;
			// 
			// tpReports
			// 
			this.tpReports.Controls.Add(this.ucReports);
			this.tpReports.Location = new System.Drawing.Point(4, 22);
			this.tpReports.Name = "tpReports";
			this.tpReports.Padding = new System.Windows.Forms.Padding(3);
			this.tpReports.Size = new System.Drawing.Size(563, 403);
			this.tpReports.TabIndex = 1;
			this.tpReports.Text = "Отчеты";
			this.tpReports.UseVisualStyleBackColor = true;
			// 
			// ucReports
			// 
			this.ucReports.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucReports.Location = new System.Drawing.Point(3, 3);
			this.ucReports.Name = "ucReports";
			this.ucReports.Size = new System.Drawing.Size(557, 397);
			this.ucReports.TabIndex = 0;
			// 
			// tpGui
			// 
			this.tpGui.Controls.Add(this.ucGuiConfig);
			this.tpGui.Location = new System.Drawing.Point(4, 22);
			this.tpGui.Name = "tpGui";
			this.tpGui.Padding = new System.Windows.Forms.Padding(3);
			this.tpGui.Size = new System.Drawing.Size(563, 403);
			this.tpGui.TabIndex = 2;
			this.tpGui.Text = "Графический интефейс";
			this.tpGui.UseVisualStyleBackColor = true;
			// 
			// ucGuiConfig
			// 
			this.ucGuiConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucGuiConfig.Location = new System.Drawing.Point(3, 3);
			this.ucGuiConfig.Name = "ucGuiConfig";
			this.ucGuiConfig.Size = new System.Drawing.Size(557, 397);
			this.ucGuiConfig.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(93, 447);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(12, 447);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// ucConfigRecord
			// 
			this.ucConfigRecord.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucConfigRecord.Location = new System.Drawing.Point(3, 3);
			this.ucConfigRecord.Name = "ucConfigRecord";
			this.ucConfigRecord.Size = new System.Drawing.Size(557, 397);
			this.ucConfigRecord.TabIndex = 0;
			// 
			// ConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 482);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tcHandbooks);
			this.Name = "ConfigForm";
			this.Text = "Конфигурация";
			this.Load += new System.EventHandler(this.ConfigForm_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
			this.tcHandbooks.ResumeLayout(false);
			this.tpVersion.ResumeLayout(false);
			this.tpDepartment.ResumeLayout(false);
			this.tpHandbooks.ResumeLayout(false);
			this.tpReports.ResumeLayout(false);
			this.tpGui.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcHandbooks;
		private System.Windows.Forms.TabPage tpHandbooks;
		private System.Windows.Forms.TabPage tpReports;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TabPage tpGui;
		private HospitalDepartment.UserControls.GuiConfigUserControl ucGuiConfig;
		private HospitalDepartment.UserControls.ReportsUserControl ucReports;
		private HospitalDepartment.UserControls.HandbookGroupsUserControl ucHandbookGroups;
		private System.Windows.Forms.TabPage tpDepartment;
		private HospitalDepartment.UserControls.DepartmentConfigUserControl ucDepartmentConfig;
        private System.Windows.Forms.TabPage tpVersion;
		private HospitalDepartment.UserControls.ConfigRecordUserControl ucConfigRecord;
	}
}