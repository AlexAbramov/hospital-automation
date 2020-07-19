namespace HospitalDepartment.UserControls
{
	partial class PatientDataUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label7 = new System.Windows.Forms.Label();
			this.dtpAdmissionDate = new System.Windows.Forms.DateTimePicker();
			this.dtpDescriptionTime = new System.Windows.Forms.DateTimePicker();
			this.label27 = new System.Windows.Forms.Label();
			this.cbWard = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cbPatientType = new System.Windows.Forms.ComboBox();
			this.dtpSickListStartDate = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.ucHandbooksInfo = new HospitalDepartment.UserControls.HandbooksInfoUserControl();
			this.cbDiet = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPatientWardHistory = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Когда поступил:";
			// 
			// dtpAdmissionDate
			// 
			this.dtpAdmissionDate.CustomFormat = "dd.MM.yy HH:mm";
			this.dtpAdmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpAdmissionDate.Location = new System.Drawing.Point(200, 29);
			this.dtpAdmissionDate.Name = "dtpAdmissionDate";
			this.dtpAdmissionDate.Size = new System.Drawing.Size(200, 20);
			this.dtpAdmissionDate.TabIndex = 13;
			this.dtpAdmissionDate.ValueChanged += new System.EventHandler(this.dtpAdmissionDate_ValueChanged);
			// 
			// dtpDescriptionTime
			// 
			this.dtpDescriptionTime.CustomFormat = "dd.MM.yy HH:mm";
			this.dtpDescriptionTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDescriptionTime.Location = new System.Drawing.Point(200, 55);
			this.dtpDescriptionTime.Name = "dtpDescriptionTime";
			this.dtpDescriptionTime.Size = new System.Drawing.Size(200, 20);
			this.dtpDescriptionTime.TabIndex = 108;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(3, 59);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(181, 13);
			this.label27.TabIndex = 107;
			this.label27.Text = "Дата и время описания больного:";
			// 
			// cbWard
			// 
			this.cbWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbWard.FormattingEnabled = true;
			this.cbWard.Location = new System.Drawing.Point(200, 108);
			this.cbWard.Name = "cbWard";
			this.cbWard.Size = new System.Drawing.Size(200, 21);
			this.cbWard.TabIndex = 113;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 111);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 112;
			this.label9.Text = "Палата:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 84);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(79, 13);
			this.label11.TabIndex = 118;
			this.label11.Text = "Тип больного:";
			// 
			// cbPatientType
			// 
			this.cbPatientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPatientType.FormattingEnabled = true;
			this.cbPatientType.Location = new System.Drawing.Point(200, 81);
			this.cbPatientType.Name = "cbPatientType";
			this.cbPatientType.Size = new System.Drawing.Size(200, 21);
			this.cbPatientType.TabIndex = 119;
			// 
			// dtpSickListStartDate
			// 
			this.dtpSickListStartDate.CustomFormat = "dd MM yy";
			this.dtpSickListStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSickListStartDate.Location = new System.Drawing.Point(200, 3);
			this.dtpSickListStartDate.Name = "dtpSickListStartDate";
			this.dtpSickListStartDate.Size = new System.Drawing.Size(200, 20);
			this.dtpSickListStartDate.TabIndex = 123;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 7);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(114, 13);
			this.label13.TabIndex = 122;
			this.label13.Text = "Начало больничного:";
			// 
			// ucHandbooksInfo
			// 
			this.ucHandbooksInfo.AutoSize = true;
			this.ucHandbooksInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ucHandbooksInfo.Location = new System.Drawing.Point(6, 162);
			this.ucHandbooksInfo.Name = "ucHandbooksInfo";
			this.ucHandbooksInfo.Size = new System.Drawing.Size(323, 113);
			this.ucHandbooksInfo.TabIndex = 127;
			this.ucHandbooksInfo.Load += new System.EventHandler(this.ucHandbooksInfo_Load);
			// 
			// cbDiet
			// 
			this.cbDiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDiet.FormattingEnabled = true;
			this.cbDiet.Location = new System.Drawing.Point(200, 135);
			this.cbDiet.Name = "cbDiet";
			this.cbDiet.Size = new System.Drawing.Size(200, 21);
			this.cbDiet.Sorted = true;
			this.cbDiet.TabIndex = 129;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 128;
			this.label1.Text = "Диета:";
			// 
			// btnPatientWardHistory
			// 
			this.btnPatientWardHistory.Location = new System.Drawing.Point(406, 106);
			this.btnPatientWardHistory.Name = "btnPatientWardHistory";
			this.btnPatientWardHistory.Size = new System.Drawing.Size(75, 23);
			this.btnPatientWardHistory.TabIndex = 130;
			this.btnPatientWardHistory.Text = "переводы";
			this.btnPatientWardHistory.UseVisualStyleBackColor = true;
			this.btnPatientWardHistory.Click += new System.EventHandler(this.btnPatientWardHistory_Click);
			// 
			// PatientDataUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnPatientWardHistory);
			this.Controls.Add(this.cbDiet);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ucHandbooksInfo);
			this.Controls.Add(this.dtpSickListStartDate);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.cbPatientType);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cbWard);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dtpDescriptionTime);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.dtpAdmissionDate);
			this.Controls.Add(this.label7);
			this.Name = "PatientDataUserControl";
			this.Size = new System.Drawing.Size(533, 300);
			this.Load += new System.EventHandler(this.PatientUserControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpAdmissionDate;
		private System.Windows.Forms.DateTimePicker dtpDescriptionTime;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.ComboBox cbWard;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbPatientType;
		private System.Windows.Forms.DateTimePicker dtpSickListStartDate;
		private System.Windows.Forms.Label label13;
		private HandbooksInfoUserControl ucHandbooksInfo;
		private System.Windows.Forms.ComboBox cbDiet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPatientWardHistory;
	}
}
