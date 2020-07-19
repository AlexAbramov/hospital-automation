namespace HospitalDepartment.Forms
{
	partial class ObservationsForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.btnChiefRound = new System.Windows.Forms.Button();
            this.btnDoctorRound = new System.Windows.Forms.Button();
            this.ucSelectReport = new HospitalDepartment.UserControls.SelectReportUserControl();
            this.btnRemove = new System.Windows.Forms.Button();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservationTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(492, 374);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Закрыть";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(492, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Открыть";
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
            this.colTime,
            this.colObservationTypeName,
            this.colDoctorName});
            this.gridView.Location = new System.Drawing.Point(12, 12);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(474, 385);
            this.gridView.TabIndex = 3;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(6, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Дневник";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTemperature);
            this.groupBox1.Controls.Add(this.btnChiefRound);
            this.groupBox1.Controls.Add(this.btnDoctorRound);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(492, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 148);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            // 
            // btnTemperature
            // 
            this.btnTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemperature.Location = new System.Drawing.Point(6, 19);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(88, 23);
            this.btnTemperature.TabIndex = 7;
            this.btnTemperature.Text = "Температура";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // btnChiefRound
            // 
            this.btnChiefRound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiefRound.Location = new System.Drawing.Point(6, 106);
            this.btnChiefRound.Name = "btnChiefRound";
            this.btnChiefRound.Size = new System.Drawing.Size(88, 23);
            this.btnChiefRound.TabIndex = 6;
            this.btnChiefRound.Text = "Обход зав.";
            this.btnChiefRound.UseVisualStyleBackColor = true;
            this.btnChiefRound.Click += new System.EventHandler(this.btnChiefRound_Click);
            // 
            // btnDoctorRound
            // 
            this.btnDoctorRound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoctorRound.Location = new System.Drawing.Point(6, 77);
            this.btnDoctorRound.Name = "btnDoctorRound";
            this.btnDoctorRound.Size = new System.Drawing.Size(88, 23);
            this.btnDoctorRound.TabIndex = 5;
            this.btnDoctorRound.Text = "Этапный";
            this.btnDoctorRound.UseVisualStyleBackColor = true;
            this.btnDoctorRound.Click += new System.EventHandler(this.btnDoctorRound_Click);
            // 
            // ucSelectReport
            // 
            this.ucSelectReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectReport.Location = new System.Drawing.Point(492, 224);
            this.ucSelectReport.Name = "ucSelectReport";
            this.ucSelectReport.Size = new System.Drawing.Size(100, 127);
            this.ucSelectReport.TabIndex = 18;
            this.ucSelectReport.Load += new System.EventHandler(this.ucSelectReport_Load);
            this.ucSelectReport.OnShowReport += new System.EventHandler<HospitalDepartment.UserControls.SelectReportEventArgs>(this.ucSelectReport_OnShowReport);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(492, 195);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // colTime
            // 
            this.colTime.DataPropertyName = "Time";
            dataGridViewCellStyle1.Format = "dd.MM.yy HH:mm";
            this.colTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTime.HeaderText = "Время";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colObservationTypeName
            // 
            this.colObservationTypeName.DataPropertyName = "ObservationTypeName";
            this.colObservationTypeName.HeaderText = "Тип наблюдения";
            this.colObservationTypeName.Name = "colObservationTypeName";
            this.colObservationTypeName.ReadOnly = true;
            // 
            // colDoctorName
            // 
            this.colDoctorName.DataPropertyName = "DoctorName";
            this.colDoctorName.FillWeight = 200F;
            this.colDoctorName.HeaderText = "Наблюдающий";
            this.colDoctorName.Name = "colDoctorName";
            this.colDoctorName.ReadOnly = true;
            // 
            // ObservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 409);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.ucSelectReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnOk);
            this.Name = "ObservationsForm";
            this.Text = "Наблюдения";
            this.Load += new System.EventHandler(this.ObservationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnChiefRound;
		private System.Windows.Forms.Button btnDoctorRound;
		private HospitalDepartment.UserControls.SelectReportUserControl ucSelectReport;
        private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservationTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorName;
	}
}