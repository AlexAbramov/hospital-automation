namespace HospitalDepartment.Forms
{
	partial class PatientAdmissionForm
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.tpPrescription = new System.Windows.Forms.TabPage();
			this.ucPrescriptions = new HospitalDepartment.UserControls.PrescriptionsUserControl();
			this.tpPatientDescription = new System.Windows.Forms.TabPage();
			this.ucPatientDescription = new HospitalDepartment.UserControls.PatientDescriptionUserControl();
			this.tpPatient = new System.Windows.Forms.TabPage();
			this.ucPatientData = new HospitalDepartment.UserControls.PatientDataUserControl();
			this.tpInsurance = new System.Windows.Forms.TabPage();
			this.ucInsurance = new HospitalDepartment.UserControls.InsuranceUserControl();
			this.tpIdentificaton = new System.Windows.Forms.TabPage();
			this.ucPatientIdentification = new HospitalDepartment.UserControls.PatientIdentificationUserControl();
			this.tpPassport = new System.Windows.Forms.TabPage();
			this.ucPassport = new HospitalDepartment.UserControls.PassportUserControl();
			this.tcPatient = new System.Windows.Forms.TabControl();
			this.tpDiagnoses = new System.Windows.Forms.TabPage();
			this.ucDiagnoses = new HospitalDepartment.UserControls.PatientDiagnosesUserControl();
			this.tpAnalyses = new System.Windows.Forms.TabPage();
			this.ucAnalyses = new HospitalDepartment.UserControls.AnalysesUserControl();
			this.tpPrescription.SuspendLayout();
			this.tpPatientDescription.SuspendLayout();
			this.tpPatient.SuspendLayout();
			this.tpInsurance.SuspendLayout();
			this.tpIdentificaton.SuspendLayout();
			this.tpPassport.SuspendLayout();
			this.tcPatient.SuspendLayout();
			this.tpDiagnoses.SuspendLayout();
			this.tpAnalyses.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(12, 424);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(93, 424);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// tpPrescription
			// 
			this.tpPrescription.Controls.Add(this.ucPrescriptions);
			this.tpPrescription.Location = new System.Drawing.Point(4, 22);
			this.tpPrescription.Name = "tpPrescription";
			this.tpPrescription.Padding = new System.Windows.Forms.Padding(3);
			this.tpPrescription.Size = new System.Drawing.Size(638, 380);
			this.tpPrescription.TabIndex = 5;
			this.tpPrescription.Text = "Назначения";
			this.tpPrescription.UseVisualStyleBackColor = true;
			// 
			// ucPrescriptions
			// 
			this.ucPrescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPrescriptions.Location = new System.Drawing.Point(3, 3);
			this.ucPrescriptions.Name = "ucPrescriptions";
			this.ucPrescriptions.Size = new System.Drawing.Size(632, 374);
			this.ucPrescriptions.TabIndex = 0;
			// 
			// tpPatientDescription
			// 
			this.tpPatientDescription.Controls.Add(this.ucPatientDescription);
			this.tpPatientDescription.Location = new System.Drawing.Point(4, 22);
			this.tpPatientDescription.Name = "tpPatientDescription";
			this.tpPatientDescription.Padding = new System.Windows.Forms.Padding(3);
			this.tpPatientDescription.Size = new System.Drawing.Size(638, 380);
			this.tpPatientDescription.TabIndex = 4;
			this.tpPatientDescription.Text = "Описание";
			this.tpPatientDescription.UseVisualStyleBackColor = true;
			// 
			// ucPatientDescription
			// 
			this.ucPatientDescription.AutoScroll = true;
			this.ucPatientDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPatientDescription.Location = new System.Drawing.Point(3, 3);
			this.ucPatientDescription.Name = "ucPatientDescription";
			this.ucPatientDescription.Size = new System.Drawing.Size(632, 374);
			this.ucPatientDescription.TabIndex = 0;
			// 
			// tpPatient
			// 
			this.tpPatient.Controls.Add(this.ucPatientData);
			this.tpPatient.Location = new System.Drawing.Point(4, 22);
			this.tpPatient.Name = "tpPatient";
			this.tpPatient.Padding = new System.Windows.Forms.Padding(3);
			this.tpPatient.Size = new System.Drawing.Size(638, 380);
			this.tpPatient.TabIndex = 3;
			this.tpPatient.Text = "Пациент";
			this.tpPatient.UseVisualStyleBackColor = true;
			// 
			// ucPatientData
			// 
			this.ucPatientData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPatientData.Location = new System.Drawing.Point(3, 3);
			this.ucPatientData.Name = "ucPatientData";
			this.ucPatientData.Size = new System.Drawing.Size(632, 374);
			this.ucPatientData.TabIndex = 0;
			// 
			// tpInsurance
			// 
			this.tpInsurance.Controls.Add(this.ucInsurance);
			this.tpInsurance.Location = new System.Drawing.Point(4, 22);
			this.tpInsurance.Name = "tpInsurance";
			this.tpInsurance.Padding = new System.Windows.Forms.Padding(3);
			this.tpInsurance.Size = new System.Drawing.Size(638, 380);
			this.tpInsurance.TabIndex = 2;
			this.tpInsurance.Text = "Страхование";
			this.tpInsurance.UseVisualStyleBackColor = true;
			// 
			// ucInsurance
			// 
			this.ucInsurance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucInsurance.Location = new System.Drawing.Point(3, 3);
			this.ucInsurance.Name = "ucInsurance";
			this.ucInsurance.Size = new System.Drawing.Size(632, 374);
			this.ucInsurance.TabIndex = 0;
			// 
			// tpIdentificaton
			// 
			this.tpIdentificaton.Controls.Add(this.ucPatientIdentification);
			this.tpIdentificaton.Location = new System.Drawing.Point(4, 22);
			this.tpIdentificaton.Name = "tpIdentificaton";
			this.tpIdentificaton.Padding = new System.Windows.Forms.Padding(3);
			this.tpIdentificaton.Size = new System.Drawing.Size(638, 380);
			this.tpIdentificaton.TabIndex = 1;
			this.tpIdentificaton.Text = "Идентификация";
			this.tpIdentificaton.UseVisualStyleBackColor = true;
			// 
			// ucPatientIdentification
			// 
			this.ucPatientIdentification.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPatientIdentification.Location = new System.Drawing.Point(3, 3);
			this.ucPatientIdentification.Name = "ucPatientIdentification";
			this.ucPatientIdentification.Size = new System.Drawing.Size(632, 374);
			this.ucPatientIdentification.TabIndex = 0;
			// 
			// tpPassport
			// 
			this.tpPassport.Controls.Add(this.ucPassport);
			this.tpPassport.Location = new System.Drawing.Point(4, 22);
			this.tpPassport.Name = "tpPassport";
			this.tpPassport.Padding = new System.Windows.Forms.Padding(3);
			this.tpPassport.Size = new System.Drawing.Size(638, 380);
			this.tpPassport.TabIndex = 0;
			this.tpPassport.Text = "Паспорт";
			this.tpPassport.UseVisualStyleBackColor = true;
			// 
			// ucPassport
			// 
			this.ucPassport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPassport.Location = new System.Drawing.Point(3, 3);
			this.ucPassport.Name = "ucPassport";
			this.ucPassport.Size = new System.Drawing.Size(632, 374);
			this.ucPassport.TabIndex = 0;
			// 
			// tcPatient
			// 
			this.tcPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tcPatient.Controls.Add(this.tpPassport);
			this.tcPatient.Controls.Add(this.tpInsurance);
			this.tcPatient.Controls.Add(this.tpIdentificaton);
			this.tcPatient.Controls.Add(this.tpPatient);
			this.tcPatient.Controls.Add(this.tpDiagnoses);
			this.tcPatient.Controls.Add(this.tpPatientDescription);
			this.tcPatient.Controls.Add(this.tpPrescription);
			this.tcPatient.Controls.Add(this.tpAnalyses);
			this.tcPatient.Location = new System.Drawing.Point(12, 12);
			this.tcPatient.Multiline = true;
			this.tcPatient.Name = "tcPatient";
			this.tcPatient.SelectedIndex = 0;
			this.tcPatient.Size = new System.Drawing.Size(646, 406);
			this.tcPatient.TabIndex = 0;
			this.tcPatient.SelectedIndexChanged += new System.EventHandler(this.tcPatient_SelectedIndexChanged);
			// 
			// tpDiagnoses
			// 
			this.tpDiagnoses.Controls.Add(this.ucDiagnoses);
			this.tpDiagnoses.Location = new System.Drawing.Point(4, 22);
			this.tpDiagnoses.Name = "tpDiagnoses";
			this.tpDiagnoses.Padding = new System.Windows.Forms.Padding(3);
			this.tpDiagnoses.Size = new System.Drawing.Size(638, 380);
			this.tpDiagnoses.TabIndex = 7;
			this.tpDiagnoses.Text = "Диагнозы";
			this.tpDiagnoses.UseVisualStyleBackColor = true;
			// 
			// ucDiagnoses
			// 
			this.ucDiagnoses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucDiagnoses.Location = new System.Drawing.Point(3, 3);
			this.ucDiagnoses.Name = "ucDiagnoses";
			this.ucDiagnoses.Size = new System.Drawing.Size(632, 374);
			this.ucDiagnoses.TabIndex = 0;
			// 
			// tpAnalyses
			// 
			this.tpAnalyses.Controls.Add(this.ucAnalyses);
			this.tpAnalyses.Location = new System.Drawing.Point(4, 22);
			this.tpAnalyses.Name = "tpAnalyses";
			this.tpAnalyses.Padding = new System.Windows.Forms.Padding(3);
			this.tpAnalyses.Size = new System.Drawing.Size(638, 380);
			this.tpAnalyses.TabIndex = 6;
			this.tpAnalyses.Text = "Анализы";
			this.tpAnalyses.UseVisualStyleBackColor = true;
			// 
			// ucAnalyses
			// 
			this.ucAnalyses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucAnalyses.Location = new System.Drawing.Point(3, 3);
			this.ucAnalyses.Name = "ucAnalyses";
			this.ucAnalyses.Size = new System.Drawing.Size(632, 374);
			this.ucAnalyses.TabIndex = 0;
			// 
			// PatientAdmissionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 453);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tcPatient);
			this.Name = "PatientAdmissionForm";
			this.Text = "Поступление пациента";
			this.Load += new System.EventHandler(this.PatientAdmissionForm_Load);
			this.tpPrescription.ResumeLayout(false);
			this.tpPatientDescription.ResumeLayout(false);
			this.tpPatient.ResumeLayout(false);
			this.tpInsurance.ResumeLayout(false);
			this.tpIdentificaton.ResumeLayout(false);
			this.tpPassport.ResumeLayout(false);
			this.tcPatient.ResumeLayout(false);
			this.tpDiagnoses.ResumeLayout(false);
			this.tpAnalyses.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TabPage tpPrescription;
		private HospitalDepartment.UserControls.PrescriptionsUserControl ucPrescriptions;
		private System.Windows.Forms.TabPage tpPatientDescription;
		private HospitalDepartment.UserControls.PatientDescriptionUserControl ucPatientDescription;
		private System.Windows.Forms.TabPage tpPatient;
		private HospitalDepartment.UserControls.PatientDataUserControl ucPatientData;
		private System.Windows.Forms.TabPage tpInsurance;
		private HospitalDepartment.UserControls.InsuranceUserControl ucInsurance;
		private System.Windows.Forms.TabPage tpIdentificaton;
		private HospitalDepartment.UserControls.PatientIdentificationUserControl ucPatientIdentification;
		private System.Windows.Forms.TabPage tpPassport;
		private HospitalDepartment.UserControls.PassportUserControl ucPassport;
		private System.Windows.Forms.TabControl tcPatient;
		private System.Windows.Forms.TabPage tpAnalyses;
		private System.Windows.Forms.TabPage tpDiagnoses;
		private HospitalDepartment.UserControls.PatientDiagnosesUserControl ucDiagnoses;
		private HospitalDepartment.UserControls.AnalysesUserControl ucAnalyses;
	}
}