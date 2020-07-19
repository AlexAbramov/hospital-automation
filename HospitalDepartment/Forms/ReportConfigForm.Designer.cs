namespace HospitalDepartment.Forms
{
	partial class ReportConfigForm
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
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkVisible = new System.Windows.Forms.CheckBox();
			this.tbEmbeddedResource = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbReportType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(174, 157);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Имя:";
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(151, 10);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(179, 20);
			this.tbName.TabIndex = 5;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 157);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// tbPath
			// 
			this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPath.Location = new System.Drawing.Point(151, 89);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(179, 20);
			this.tbPath.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Файл:";
			// 
			// chkVisible
			// 
			this.chkVisible.AutoSize = true;
			this.chkVisible.Location = new System.Drawing.Point(15, 119);
			this.chkVisible.Name = "chkVisible";
			this.chkVisible.Size = new System.Drawing.Size(73, 17);
			this.chkVisible.TabIndex = 10;
			this.chkVisible.Text = "Видимый";
			this.chkVisible.UseVisualStyleBackColor = true;
			// 
			// tbEmbeddedResource
			// 
			this.tbEmbeddedResource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbEmbeddedResource.Location = new System.Drawing.Point(151, 63);
			this.tbEmbeddedResource.Name = "tbEmbeddedResource";
			this.tbEmbeddedResource.ReadOnly = true;
			this.tbEmbeddedResource.Size = new System.Drawing.Size(179, 20);
			this.tbEmbeddedResource.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Ресурс:";
			// 
			// cbReportType
			// 
			this.cbReportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbReportType.FormattingEnabled = true;
			this.cbReportType.Location = new System.Drawing.Point(151, 36);
			this.cbReportType.Name = "cbReportType";
			this.cbReportType.Size = new System.Drawing.Size(179, 21);
			this.cbReportType.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Тип отчета:";
			// 
			// ReportConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 192);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbReportType);
			this.Controls.Add(this.tbEmbeddedResource);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.chkVisible);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSave);
			this.Name = "ReportConfigForm";
			this.Text = "Отчет";
			this.Load += new System.EventHandler(this.ReportConfigForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkVisible;
		private System.Windows.Forms.TextBox tbEmbeddedResource;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbReportType;
		private System.Windows.Forms.Label label4;
	}
}