namespace HospitalDepartment.Forms
{
	partial class PrescriptionForm
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
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbPrescriptionType = new System.Windows.Forms.ComboBox();
			this.nudDuration = new System.Windows.Forms.NumericUpDown();
			this.nudMultiplicity = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.nudDose = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.lblMedicament = new System.Windows.Forms.Label();
			this.lblUnit = new System.Windows.Forms.Label();
			this.tbMedicament = new System.Windows.Forms.TextBox();
			this.lblDurationUnit = new System.Windows.Forms.Label();
			this.chkReanimation = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMultiplicity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDose)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(12, 224);
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
			this.btnCancel.Location = new System.Drawing.Point(93, 224);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 19;
			this.label4.Text = "Начало:";
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.CustomFormat = "dd.MM.yy HH:mm";
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartDate.Location = new System.Drawing.Point(164, 65);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.ShowUpDown = true;
			this.dtpStartDate.Size = new System.Drawing.Size(121, 20);
			this.dtpStartDate.TabIndex = 20;
			this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "colEndDate:";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.CustomFormat = "dd.MM.yy HH:mm";
			this.dtpEndDate.Enabled = false;
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEndDate.Location = new System.Drawing.Point(164, 117);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.ShowUpDown = true;
			this.dtpEndDate.Size = new System.Drawing.Size(121, 20);
			this.dtpEndDate.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "Продолжительность:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Тип ввода:";
			// 
			// cbPrescriptionType
			// 
			this.cbPrescriptionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cbPrescriptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPrescriptionType.FormattingEnabled = true;
			this.cbPrescriptionType.Location = new System.Drawing.Point(164, 38);
			this.cbPrescriptionType.Name = "cbPrescriptionType";
			this.cbPrescriptionType.Size = new System.Drawing.Size(305, 21);
			this.cbPrescriptionType.TabIndex = 26;
			// 
			// nudDuration
			// 
			this.nudDuration.Location = new System.Drawing.Point(164, 91);
			this.nudDuration.Name = "nudDuration";
			this.nudDuration.Size = new System.Drawing.Size(120, 20);
			this.nudDuration.TabIndex = 27;
			this.nudDuration.ValueChanged += new System.EventHandler(this.nudDuration_ValueChanged);
			// 
			// nudMultiplicity
			// 
			this.nudMultiplicity.Location = new System.Drawing.Point(164, 169);
			this.nudMultiplicity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMultiplicity.Name = "nudMultiplicity";
			this.nudMultiplicity.Size = new System.Drawing.Size(120, 20);
			this.nudMultiplicity.TabIndex = 29;
			this.nudMultiplicity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 28;
			this.label5.Text = "Кратность:";
			// 
			// nudDose
			// 
			this.nudDose.DecimalPlaces = 3;
			this.nudDose.Location = new System.Drawing.Point(164, 143);
			this.nudDose.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudDose.Name = "nudDose";
			this.nudDose.Size = new System.Drawing.Size(120, 20);
			this.nudDose.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 30;
			this.label6.Text = "Доза:";
			// 
			// lblMedicament
			// 
			this.lblMedicament.AutoSize = true;
			this.lblMedicament.Location = new System.Drawing.Point(12, 15);
			this.lblMedicament.Name = "lblMedicament";
			this.lblMedicament.Size = new System.Drawing.Size(74, 13);
			this.lblMedicament.TabIndex = 32;
			this.lblMedicament.Text = "Медикамент:";
			// 
			// lblUnit
			// 
			this.lblUnit.AutoSize = true;
			this.lblUnit.Location = new System.Drawing.Point(290, 145);
			this.lblUnit.Name = "lblUnit";
			this.lblUnit.Size = new System.Drawing.Size(48, 13);
			this.lblUnit.TabIndex = 34;
			this.lblUnit.Text = "ед. изм.";
			// 
			// tbMedicament
			// 
			this.tbMedicament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbMedicament.Location = new System.Drawing.Point(164, 12);
			this.tbMedicament.Name = "tbMedicament";
			this.tbMedicament.ReadOnly = true;
			this.tbMedicament.Size = new System.Drawing.Size(305, 20);
			this.tbMedicament.TabIndex = 35;
			// 
			// lblDurationUnit
			// 
			this.lblDurationUnit.AutoSize = true;
			this.lblDurationUnit.Location = new System.Drawing.Point(290, 93);
			this.lblDurationUnit.Name = "lblDurationUnit";
			this.lblDurationUnit.Size = new System.Drawing.Size(31, 13);
			this.lblDurationUnit.TabIndex = 36;
			this.lblDurationUnit.Text = "дней";
			// 
			// chkReanimation
			// 
			this.chkReanimation.AutoSize = true;
			this.chkReanimation.Location = new System.Drawing.Point(294, 68);
			this.chkReanimation.Name = "chkReanimation";
			this.chkReanimation.Size = new System.Drawing.Size(106, 17);
			this.chkReanimation.TabIndex = 37;
			this.chkReanimation.Text = "реанимационое";
			this.chkReanimation.UseVisualStyleBackColor = true;
			this.chkReanimation.CheckedChanged += new System.EventHandler(this.chkReanimation_CheckedChanged);
			// 
			// PrescriptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 259);
			this.Controls.Add(this.chkReanimation);
			this.Controls.Add(this.lblDurationUnit);
			this.Controls.Add(this.tbMedicament);
			this.Controls.Add(this.lblUnit);
			this.Controls.Add(this.lblMedicament);
			this.Controls.Add(this.nudDose);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nudMultiplicity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nudDuration);
			this.Controls.Add(this.cbPrescriptionType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.btnOk);
			this.Name = "PrescriptionForm";
			this.Text = "Назначение";
			this.Load += new System.EventHandler(this.PrescriptionForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMultiplicity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbPrescriptionType;
		private System.Windows.Forms.NumericUpDown nudDuration;
		private System.Windows.Forms.NumericUpDown nudMultiplicity;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nudDose;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblMedicament;
		private System.Windows.Forms.Label lblUnit;
		private System.Windows.Forms.TextBox tbMedicament;
		private System.Windows.Forms.Label lblDurationUnit;
		private System.Windows.Forms.CheckBox chkReanimation;
	}
}