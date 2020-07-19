namespace HospitalDepartment.Forms
{
	partial class DiagnosisForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.ucMedicamentGroups = new HospitalDepartment.UserControls.MedicamentGroupsUserControl();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbCode = new System.Windows.Forms.TextBox();
			this.nudHigh = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.nudFirst = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.nudSecond = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.nudDay = new System.Windows.Forms.NumericUpDown();
			this.tbMCode = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudHigh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFirst)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(12, 404);
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
			this.btnCancel.Location = new System.Drawing.Point(93, 404);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Название:";
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(102, 64);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(366, 20);
			this.tbName.TabIndex = 6;
			// 
			// ucMedicamentGroups
			// 
			this.ucMedicamentGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.ucMedicamentGroups.Location = new System.Drawing.Point(13, 238);
			this.ucMedicamentGroups.Name = "ucMedicamentGroups";
			this.ucMedicamentGroups.Size = new System.Drawing.Size(455, 160);
			this.ucMedicamentGroups.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 222);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Группы:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Код КСГ:";
			// 
			// tbCode
			// 
			this.tbCode.Location = new System.Drawing.Point(102, 12);
			this.tbCode.Name = "tbCode";
			this.tbCode.Size = new System.Drawing.Size(150, 20);
			this.tbCode.TabIndex = 11;
			// 
			// nudHigh
			// 
			this.nudHigh.Location = new System.Drawing.Point(120, 19);
			this.nudHigh.Name = "nudHigh";
			this.nudHigh.Size = new System.Drawing.Size(50, 20);
			this.nudHigh.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Высшая:";
			// 
			// nudFirst
			// 
			this.nudFirst.Location = new System.Drawing.Point(120, 45);
			this.nudFirst.Name = "nudFirst";
			this.nudFirst.Size = new System.Drawing.Size(50, 20);
			this.nudFirst.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Первая:";
			// 
			// nudSecond
			// 
			this.nudSecond.Location = new System.Drawing.Point(120, 71);
			this.nudSecond.Name = "nudSecond";
			this.nudSecond.Size = new System.Drawing.Size(50, 20);
			this.nudSecond.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Вторая:";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.nudDay);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.nudSecond);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.nudFirst);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.nudHigh);
			this.groupBox1.Location = new System.Drawing.Point(12, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 129);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Нормативная длительность пребывания больного по категориям";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 99);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "ДС:";
			// 
			// nudDay
			// 
			this.nudDay.Location = new System.Drawing.Point(120, 97);
			this.nudDay.Name = "nudDay";
			this.nudDay.Size = new System.Drawing.Size(50, 20);
			this.nudDay.TabIndex = 16;
			// 
			// tbMCode
			// 
			this.tbMCode.Location = new System.Drawing.Point(102, 38);
			this.tbMCode.Name = "tbMCode";
			this.tbMCode.Size = new System.Drawing.Size(150, 20);
			this.tbMCode.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "МКБ:";
			// 
			// DiagnosisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 439);
			this.Controls.Add(this.tbMCode);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbCode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ucMedicamentGroups);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Name = "DiagnosisForm";
			this.Text = "Диагноз";
			this.Load += new System.EventHandler(this.DiagnosisForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudHigh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFirst)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private HospitalDepartment.UserControls.MedicamentGroupsUserControl ucMedicamentGroups;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCode;
		private System.Windows.Forms.NumericUpDown nudHigh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudFirst;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nudSecond;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nudDay;
		private System.Windows.Forms.TextBox tbMCode;
		private System.Windows.Forms.Label label8;
	}
}