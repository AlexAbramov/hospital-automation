namespace HospitalDepartment.Forms
{
	partial class AnalisisForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpExecutionDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucHandbooksInfo = new HospitalDepartment.UserControls.HandbooksInfoUserControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 332);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Сохранить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата подачи заявки:";
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.CustomFormat = "  dd.MM.yy";
            this.dtpRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequestDate.Location = new System.Drawing.Point(122, 8);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(121, 20);
            this.dtpRequestDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Дата проведения:";
            // 
            // dtpExecutionDate
            // 
            this.dtpExecutionDate.CustomFormat = "  dd.MM.yy";
            this.dtpExecutionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExecutionDate.Location = new System.Drawing.Point(122, 34);
            this.dtpExecutionDate.Name = "dtpExecutionDate";
            this.dtpExecutionDate.ShowCheckBox = true;
            this.dtpExecutionDate.Size = new System.Drawing.Size(121, 20);
            this.dtpExecutionDate.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ucHandbooksInfo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpRequestDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpExecutionDate);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 314);
            this.panel1.TabIndex = 24;
            // 
            // ucHandbooksInfo
            // 
            this.ucHandbooksInfo.AutoSize = true;
            this.ucHandbooksInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucHandbooksInfo.Location = new System.Drawing.Point(3, 60);
            this.ucHandbooksInfo.Name = "ucHandbooksInfo";
            this.ucHandbooksInfo.Size = new System.Drawing.Size(323, 113);
            this.ucHandbooksInfo.TabIndex = 23;
            // 
            // AnalisisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "AnalisisForm";
            this.Text = "Анализ";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpRequestDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpExecutionDate;
//		private HospitalDepartment.UserControls.HandbooksInfoUserControl ucHandbooksInfo;
		private System.Windows.Forms.Panel panel1;
		private HospitalDepartment.UserControls.HandbooksInfoUserControl ucHandbooksInfo;
	}
}