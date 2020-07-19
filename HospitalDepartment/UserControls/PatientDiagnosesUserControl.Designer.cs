namespace HospitalDepartment.UserControls
{
	partial class PatientDiagnosesUserControl
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
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ucConcomitantDiagnosis = new HospitalDepartment.UserControls.MultilineComboUserControl();
			this.ucDirectionalDiagnosis = new HospitalDepartment.UserControls.MultilineComboUserControl();
			this.ucComplicationDiagnosis = new HospitalDepartment.UserControls.MultilineComboUserControl();
			this.ucFinalDiagnosis = new HospitalDepartment.UserControls.DiagnosisInfoUserControl();
			this.ucClinicalDiagnosis = new HospitalDepartment.UserControls.DiagnosisInfoUserControl();
			this.ucAdmissionDiagnosis = new HospitalDepartment.UserControls.DiagnosisInfoUserControl();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label16
			// 
			this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(3, 302);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(90, 13);
			this.label16.TabIndex = 12;
			this.label16.Text = "Сопутствующий:";
			// 
			// label15
			// 
			this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(3, 245);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(74, 13);
			this.label15.TabIndex = 11;
			this.label15.Text = "Осложнения:";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Направившего учреждения:";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "При поступлении:";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Клинический:";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 189);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(158, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Окончательный клинический:";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ucConcomitantDiagnosis, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.ucDirectionalDiagnosis, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.ucComplicationDiagnosis, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ucFinalDiagnosis, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.ucClinicalDiagnosis, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.ucAdmissionDiagnosis, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label16, 0, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 338);
			this.tableLayoutPanel1.TabIndex = 19;
			// 
			// ucConcomitantDiagnosis
			// 
			this.ucConcomitantDiagnosis.Additive = false;
			this.ucConcomitantDiagnosis.DataSource = null;
			this.ucConcomitantDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucConcomitantDiagnosis.LineCount = 0;
			this.ucConcomitantDiagnosis.Location = new System.Drawing.Point(167, 283);
			this.ucConcomitantDiagnosis.Name = "ucConcomitantDiagnosis";
			this.ucConcomitantDiagnosis.Size = new System.Drawing.Size(241, 52);
			this.ucConcomitantDiagnosis.TabIndex = 18;
			this.ucConcomitantDiagnosis.Text = "";
			// 
			// ucDirectionalDiagnosis
			// 
			this.ucDirectionalDiagnosis.Additive = false;
			this.ucDirectionalDiagnosis.DataSource = null;
			this.ucDirectionalDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucDirectionalDiagnosis.LineCount = 0;
			this.ucDirectionalDiagnosis.Location = new System.Drawing.Point(167, 3);
			this.ucDirectionalDiagnosis.Name = "ucDirectionalDiagnosis";
			this.ucDirectionalDiagnosis.Size = new System.Drawing.Size(241, 50);
			this.ucDirectionalDiagnosis.TabIndex = 16;
			this.ucDirectionalDiagnosis.Text = "";
			// 
			// ucComplicationDiagnosis
			// 
			this.ucComplicationDiagnosis.Additive = true;
			this.ucComplicationDiagnosis.DataSource = null;
			this.ucComplicationDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucComplicationDiagnosis.LineCount = 0;
			this.ucComplicationDiagnosis.Location = new System.Drawing.Point(167, 227);
			this.ucComplicationDiagnosis.Name = "ucComplicationDiagnosis";
			this.ucComplicationDiagnosis.Size = new System.Drawing.Size(241, 50);
			this.ucComplicationDiagnosis.TabIndex = 17;
			this.ucComplicationDiagnosis.Text = "";
			// 
			// ucFinalDiagnosis
			// 
			this.ucFinalDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucFinalDiagnosis.Location = new System.Drawing.Point(167, 171);
			this.ucFinalDiagnosis.Name = "ucFinalDiagnosis";
			this.ucFinalDiagnosis.Size = new System.Drawing.Size(241, 50);
			this.ucFinalDiagnosis.TabIndex = 15;
			this.ucFinalDiagnosis.Load += new System.EventHandler(this.ucFinalDiagnosis_Load);
			this.ucFinalDiagnosis.OnDiagnosisIdChanged += new System.EventHandler(this.ucFinalDiagnosis_OnDiagnosisIdChanged);
			// 
			// ucClinicalDiagnosis
			// 
			this.ucClinicalDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucClinicalDiagnosis.Location = new System.Drawing.Point(167, 115);
			this.ucClinicalDiagnosis.Name = "ucClinicalDiagnosis";
			this.ucClinicalDiagnosis.Size = new System.Drawing.Size(241, 50);
			this.ucClinicalDiagnosis.TabIndex = 14;
			this.ucClinicalDiagnosis.OnDiagnosisIdChanged += new System.EventHandler(this.ucClinicalDiagnosis_OnDiagnosisIdChanged);
			// 
			// ucAdmissionDiagnosis
			// 
			this.ucAdmissionDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucAdmissionDiagnosis.Location = new System.Drawing.Point(167, 59);
			this.ucAdmissionDiagnosis.Name = "ucAdmissionDiagnosis";
			this.ucAdmissionDiagnosis.Size = new System.Drawing.Size(241, 50);
			this.ucAdmissionDiagnosis.TabIndex = 13;
			this.ucAdmissionDiagnosis.OnDiagnosisIdChanged += new System.EventHandler(this.ucAdmissionDiagnosis_OnDiagnosisIdChanged);
			// 
			// PatientDiagnosesUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "PatientDiagnosesUserControl";
			this.Size = new System.Drawing.Size(487, 391);
			this.Load += new System.EventHandler(this.PatientDiagnosesUserControl_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private DiagnosisInfoUserControl ucAdmissionDiagnosis;
		private DiagnosisInfoUserControl ucClinicalDiagnosis;
		private DiagnosisInfoUserControl ucFinalDiagnosis;
		private MultilineComboUserControl ucDirectionalDiagnosis;
		private MultilineComboUserControl ucComplicationDiagnosis;
		private MultilineComboUserControl ucConcomitantDiagnosis;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

	}
}
