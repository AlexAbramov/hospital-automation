namespace HospitalDepartment.Forms
{
	partial class DischargeForm
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
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpDischargeDate = new System.Windows.Forms.DateTimePicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbDischargeType = new System.Windows.Forms.ComboBox();
			this.ucHandbooksInfo = new HospitalDepartment.UserControls.HandbooksInfoUserControl();
			this.ucSelectReport = new HospitalDepartment.UserControls.SelectReportUserControl();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(352, 198);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(100, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "Сохранить";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(352, 227);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Дата выписки:";
			// 
			// dtpDischargeDate
			// 
			this.dtpDischargeDate.CustomFormat = "  dd.MM.yy";
			this.dtpDischargeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDischargeDate.Location = new System.Drawing.Point(133, 38);
			this.dtpDischargeDate.Name = "dtpDischargeDate";
			this.dtpDischargeDate.ShowCheckBox = true;
			this.dtpDischargeDate.Size = new System.Drawing.Size(121, 20);
			this.dtpDischargeDate.TabIndex = 12;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbDischargeType);
			this.panel1.Controls.Add(this.ucHandbooksInfo);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.dtpDischargeDate);
			this.panel1.Location = new System.Drawing.Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(344, 249);
			this.panel1.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Тип выписки:";
			// 
			// cbDischargeType
			// 
			this.cbDischargeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDischargeType.FormattingEnabled = true;
			this.cbDischargeType.Location = new System.Drawing.Point(133, 11);
			this.cbDischargeType.Name = "cbDischargeType";
			this.cbDischargeType.Size = new System.Drawing.Size(121, 21);
			this.cbDischargeType.TabIndex = 15;
			this.cbDischargeType.SelectedIndexChanged += new System.EventHandler(this.cbDischargeType_SelectedIndexChanged);
			// 
			// ucHandbooksInfo
			// 
			this.ucHandbooksInfo.AutoSize = true;
			this.ucHandbooksInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ucHandbooksInfo.Location = new System.Drawing.Point(10, 64);
			this.ucHandbooksInfo.Name = "ucHandbooksInfo";
			this.ucHandbooksInfo.Size = new System.Drawing.Size(323, 113);
			this.ucHandbooksInfo.TabIndex = 14;
			// 
			// ucSelectReport
			// 
			this.ucSelectReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectReport.Location = new System.Drawing.Point(352, 1);
			this.ucSelectReport.Name = "ucSelectReport";
			this.ucSelectReport.Size = new System.Drawing.Size(100, 127);
			this.ucSelectReport.TabIndex = 17;
			this.ucSelectReport.OnShowReport += new System.EventHandler<HospitalDepartment.UserControls.SelectReportEventArgs>(this.ucSelectReport_OnShowReport);
			// 
			// DischargeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 262);
			this.Controls.Add(this.ucSelectReport);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Name = "DischargeForm";
			this.Text = "Выписка";
			this.Load += new System.EventHandler(this.DischargeForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpDischargeDate;
		private System.Windows.Forms.Panel panel1;
		private HospitalDepartment.UserControls.HandbooksInfoUserControl ucHandbooksInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbDischargeType;
		private HospitalDepartment.UserControls.SelectReportUserControl ucSelectReport;
	}
}