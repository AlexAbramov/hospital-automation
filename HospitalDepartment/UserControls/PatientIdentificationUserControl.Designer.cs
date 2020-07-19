namespace HospitalDepartment.UserControls
{
	partial class PatientIdentificationUserControl
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
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.cbGender = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbMiddleName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.ucHandbooksInfo = new HospitalDepartment.UserControls.HandbooksInfoUserControl();
			this.SuspendLayout();
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Location = new System.Drawing.Point(173, 108);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.ShowCheckBox = true;
			this.dtpBirthday.Size = new System.Drawing.Size(161, 20);
			this.dtpBirthday.TabIndex = 27;
			// 
			// cbGender
			// 
			this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGender.FormattingEnabled = true;
			this.cbGender.Location = new System.Drawing.Point(173, 81);
			this.cbGender.Name = "cbGender";
			this.cbGender.Size = new System.Drawing.Size(161, 21);
			this.cbGender.TabIndex = 25;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Фамилия:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Имя:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "Отчество:";
			// 
			// tbMiddleName
			// 
			this.tbMiddleName.Location = new System.Drawing.Point(173, 55);
			this.tbMiddleName.Name = "tbMiddleName";
			this.tbMiddleName.Size = new System.Drawing.Size(200, 20);
			this.tbMiddleName.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 84);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 24;
			this.label8.Text = "Пол:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(173, 29);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(200, 20);
			this.tbName.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 13);
			this.label9.TabIndex = 26;
			this.label9.Text = "Дата рождения:";
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(173, 3);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(200, 20);
			this.tbSurname.TabIndex = 19;
			// 
			// ucHandbooksInfo
			// 
			this.ucHandbooksInfo.AutoSize = true;
			this.ucHandbooksInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ucHandbooksInfo.Location = new System.Drawing.Point(3, 134);
			this.ucHandbooksInfo.Name = "ucHandbooksInfo";
			this.ucHandbooksInfo.Size = new System.Drawing.Size(323, 113);
			this.ucHandbooksInfo.TabIndex = 28;
			// 
			// PatientIdentificationUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ucHandbooksInfo);
			this.Controls.Add(this.dtpBirthday);
			this.Controls.Add(this.cbGender);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbMiddleName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbSurname);
			this.Name = "PatientIdentificationUserControl";
			this.Size = new System.Drawing.Size(473, 328);
			this.Load += new System.EventHandler(this.PatientIdentificationUserControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.ComboBox cbGender;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbMiddleName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbSurname;
		private HandbooksInfoUserControl ucHandbooksInfo;

	}
}
