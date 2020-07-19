namespace HospitalDepartment.UserControls
{
	partial class PassportUserControl
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbDepartmentCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbMiddleName = new System.Windows.Forms.TextBox();
			this.tbBirthPlace = new System.Windows.Forms.TextBox();
			this.tbSerialNumber = new System.Windows.Forms.TextBox();
			this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.cbGender = new System.Windows.Forms.ComboBox();
			this.tbRegistration = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.ucIssueDepartment = new HospitalDepartment.UserControls.MultilineComboUserControl();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Серия, номер:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Паспорт выдан:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Дата выдачи:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Код подразделения:";
			// 
			// tbDepartmentCode
			// 
			this.tbDepartmentCode.Location = new System.Drawing.Point(169, 102);
			this.tbDepartmentCode.Name = "tbDepartmentCode";
			this.tbDepartmentCode.Size = new System.Drawing.Size(200, 20);
			this.tbDepartmentCode.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Фамилия:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 157);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Имя:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 183);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Отчество:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 209);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Пол:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 237);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Дата рождения:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 262);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(95, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Место рождения:";
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(169, 128);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(200, 20);
			this.tbSurname.TabIndex = 9;
			this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(169, 154);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(200, 20);
			this.tbName.TabIndex = 11;
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// tbMiddleName
			// 
			this.tbMiddleName.Location = new System.Drawing.Point(169, 180);
			this.tbMiddleName.Name = "tbMiddleName";
			this.tbMiddleName.Size = new System.Drawing.Size(200, 20);
			this.tbMiddleName.TabIndex = 13;
			this.tbMiddleName.TextChanged += new System.EventHandler(this.tbMiddleName_TextChanged);
			// 
			// tbBirthPlace
			// 
			this.tbBirthPlace.Location = new System.Drawing.Point(169, 259);
			this.tbBirthPlace.Multiline = true;
			this.tbBirthPlace.Name = "tbBirthPlace";
			this.tbBirthPlace.Size = new System.Drawing.Size(200, 40);
			this.tbBirthPlace.TabIndex = 19;
			// 
			// tbSerialNumber
			// 
			this.tbSerialNumber.Location = new System.Drawing.Point(169, 4);
			this.tbSerialNumber.Name = "tbSerialNumber";
			this.tbSerialNumber.Size = new System.Drawing.Size(200, 20);
			this.tbSerialNumber.TabIndex = 1;
			// 
			// dtpIssueDate
			// 
			this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIssueDate.Location = new System.Drawing.Point(169, 76);
			this.dtpIssueDate.Name = "dtpIssueDate";
			this.dtpIssueDate.Size = new System.Drawing.Size(200, 20);
			this.dtpIssueDate.TabIndex = 5;
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthday.Location = new System.Drawing.Point(169, 233);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthday.TabIndex = 17;
			// 
			// cbGender
			// 
			this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGender.FormattingEnabled = true;
			this.cbGender.Location = new System.Drawing.Point(169, 206);
			this.cbGender.Name = "cbGender";
			this.cbGender.Size = new System.Drawing.Size(200, 21);
			this.cbGender.TabIndex = 15;
			// 
			// tbRegistration
			// 
			this.tbRegistration.Location = new System.Drawing.Point(169, 305);
			this.tbRegistration.Multiline = true;
			this.tbRegistration.Name = "tbRegistration";
			this.tbRegistration.Size = new System.Drawing.Size(200, 40);
			this.tbRegistration.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 308);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 13);
			this.label11.TabIndex = 20;
			this.label11.Text = "Регистрация:";
			// 
			// ucIssueDepartment
			// 
			this.ucIssueDepartment.Additive = false;
			this.ucIssueDepartment.DataSource = null;
			this.ucIssueDepartment.LineCount = 0;
			this.ucIssueDepartment.Location = new System.Drawing.Point(169, 31);
			this.ucIssueDepartment.Name = "ucIssueDepartment";
			this.ucIssueDepartment.Size = new System.Drawing.Size(200, 39);
			this.ucIssueDepartment.TabIndex = 22;
			// 
			// PassportUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ucIssueDepartment);
			this.Controls.Add(this.dtpBirthday);
			this.Controls.Add(this.tbRegistration);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbSerialNumber);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpIssueDate);
			this.Controls.Add(this.tbDepartmentCode);
			this.Controls.Add(this.cbGender);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbBirthPlace);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbMiddleName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.label10);
			this.Name = "PassportUserControl";
			this.Size = new System.Drawing.Size(387, 358);
			this.Load += new System.EventHandler(this.PassportUserControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbDepartmentCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbMiddleName;
		private System.Windows.Forms.TextBox tbSerialNumber;
		private System.Windows.Forms.TextBox tbBirthPlace;
		private System.Windows.Forms.DateTimePicker dtpIssueDate;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.ComboBox cbGender;
		private System.Windows.Forms.TextBox tbRegistration;
		private System.Windows.Forms.Label label11;
		private MultilineComboUserControl ucIssueDepartment;

	}
}
