namespace HospitalDepartment.Forms
{
	partial class PatientsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDischargeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObservations = new System.Windows.Forms.Button();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.btnReacard = new System.Windows.Forms.Button();
            this.btnConsultations = new System.Windows.Forms.Button();
            this.btnExpertBoards = new System.Windows.Forms.Button();
            this.ucSelectReport = new HospitalDepartment.UserControls.SelectReportUserControl();
            this.btnRemove = new System.Windows.Forms.Button();
            this.chkDischarged = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(505, 403);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Закрыть";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(505, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Поступление";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colWardNumber,
            this.colSurname,
            this.colName,
            this.colMiddleName,
            this.colAdmissionDate,
            this.colDischargeDate,
            this.colDoctorName});
            this.gridView.Location = new System.Drawing.Point(12, 25);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(487, 401);
            this.gridView.TabIndex = 8;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Номер";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colWardNumber
            // 
            this.colWardNumber.DataPropertyName = "WardNumber";
            this.colWardNumber.HeaderText = "Палата";
            this.colWardNumber.Name = "colWardNumber";
            this.colWardNumber.ReadOnly = true;
            // 
            // colSurname
            // 
            this.colSurname.DataPropertyName = "Surname";
            this.colSurname.HeaderText = "Фамилия";
            this.colSurname.Name = "colSurname";
            this.colSurname.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Имя";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colMiddleName
            // 
            this.colMiddleName.DataPropertyName = "MiddleName";
            this.colMiddleName.HeaderText = "Отчество";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            // 
            // colAdmissionDate
            // 
            this.colAdmissionDate.DataPropertyName = "AdmissionDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colAdmissionDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAdmissionDate.HeaderText = "Дата поcтупления";
            this.colAdmissionDate.Name = "colAdmissionDate";
            this.colAdmissionDate.ReadOnly = true;
            // 
            // colDischargeDate
            // 
            this.colDischargeDate.DataPropertyName = "DischargeDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colDischargeDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDischargeDate.HeaderText = "Дата выписки";
            this.colDischargeDate.Name = "colDischargeDate";
            this.colDischargeDate.ReadOnly = true;
            // 
            // colDoctorName
            // 
            this.colDoctorName.DataPropertyName = "DoctorName";
            this.colDoctorName.HeaderText = "Врач";
            this.colDoctorName.Name = "colDoctorName";
            this.colDoctorName.ReadOnly = true;
            // 
            // btnObservations
            // 
            this.btnObservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObservations.Location = new System.Drawing.Point(505, 41);
            this.btnObservations.Name = "btnObservations";
            this.btnObservations.Size = new System.Drawing.Size(100, 23);
            this.btnObservations.TabIndex = 9;
            this.btnObservations.Text = "Дневники";
            this.btnObservations.UseVisualStyleBackColor = true;
            this.btnObservations.Click += new System.EventHandler(this.btnObservations_Click);
            // 
            // btnDischarge
            // 
            this.btnDischarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDischarge.Location = new System.Drawing.Point(505, 157);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(100, 23);
            this.btnDischarge.TabIndex = 10;
            this.btnDischarge.Text = "Выписка";
            this.btnDischarge.UseVisualStyleBackColor = true;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // btnReacard
            // 
            this.btnReacard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReacard.Location = new System.Drawing.Point(505, 70);
            this.btnReacard.Name = "btnReacard";
            this.btnReacard.Size = new System.Drawing.Size(100, 23);
            this.btnReacard.TabIndex = 11;
            this.btnReacard.Text = "Реакарта";
            this.btnReacard.UseVisualStyleBackColor = true;
            this.btnReacard.Click += new System.EventHandler(this.btnReacard_Click);
            // 
            // btnConsultations
            // 
            this.btnConsultations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultations.Location = new System.Drawing.Point(505, 99);
            this.btnConsultations.Name = "btnConsultations";
            this.btnConsultations.Size = new System.Drawing.Size(100, 23);
            this.btnConsultations.TabIndex = 12;
            this.btnConsultations.Text = "Консультации";
            this.btnConsultations.UseVisualStyleBackColor = true;
            this.btnConsultations.Click += new System.EventHandler(this.btnConsultations_Click);
            // 
            // btnExpertBoards
            // 
            this.btnExpertBoards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpertBoards.Location = new System.Drawing.Point(505, 128);
            this.btnExpertBoards.Name = "btnExpertBoards";
            this.btnExpertBoards.Size = new System.Drawing.Size(100, 23);
            this.btnExpertBoards.TabIndex = 13;
            this.btnExpertBoards.Text = "КЭК";
            this.btnExpertBoards.UseVisualStyleBackColor = true;
            this.btnExpertBoards.Click += new System.EventHandler(this.btnExpertBoards_Click);
            // 
            // ucSelectReport
            // 
            this.ucSelectReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectReport.Location = new System.Drawing.Point(505, 187);
            this.ucSelectReport.Name = "ucSelectReport";
            this.ucSelectReport.Size = new System.Drawing.Size(100, 181);
            this.ucSelectReport.TabIndex = 15;
            this.ucSelectReport.OnShowReport += new System.EventHandler<HospitalDepartment.UserControls.SelectReportEventArgs>(this.ucSelectReport_OnShowReport);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(505, 374);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // chkDischarged
            // 
            this.chkDischarged.AutoSize = true;
            this.chkDischarged.Location = new System.Drawing.Point(12, 2);
            this.chkDischarged.Name = "chkDischarged";
            this.chkDischarged.Size = new System.Drawing.Size(91, 17);
            this.chkDischarged.TabIndex = 17;
            this.chkDischarged.Text = "Выписанные";
            this.chkDischarged.UseVisualStyleBackColor = true;
            this.chkDischarged.CheckedChanged += new System.EventHandler(this.chkDischarged_CheckedChanged);
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 438);
            this.Controls.Add(this.chkDischarged);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.ucSelectReport);
            this.Controls.Add(this.btnExpertBoards);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnConsultations);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnDischarge);
            this.Controls.Add(this.btnReacard);
            this.Controls.Add(this.btnObservations);
            this.Name = "PatientsForm";
            this.Text = "Пациенты";
            this.Load += new System.EventHandler(this.PatientsUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Button btnObservations;
		private System.Windows.Forms.Button btnDischarge;
		private System.Windows.Forms.Button btnReacard;
		private System.Windows.Forms.Button btnConsultations;
		private System.Windows.Forms.Button btnExpertBoards;
        private HospitalDepartment.UserControls.SelectReportUserControl ucSelectReport;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDischargeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorName;
        private System.Windows.Forms.CheckBox chkDischarged;
	}
}