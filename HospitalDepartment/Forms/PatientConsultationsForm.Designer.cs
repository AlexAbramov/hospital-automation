namespace HospitalDepartment.Forms
{
	partial class PatientConsultationsForm
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.ucSelectReport = new HospitalDepartment.UserControls.SelectReportUserControl();
			this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colExecutionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(382, 277);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Закрыть";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Location = new System.Drawing.Point(382, 12);
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
            this.colRequestDate,
            this.colExecutionDate});
			this.gridView.Location = new System.Drawing.Point(12, 12);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.ReadOnly = true;
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(364, 288);
			this.gridView.TabIndex = 3;
			this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(382, 41);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// ucSelectReport
			// 
			this.ucSelectReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectReport.Location = new System.Drawing.Point(382, 70);
			this.ucSelectReport.Name = "ucSelectReport";
			this.ucSelectReport.Size = new System.Drawing.Size(100, 127);
			this.ucSelectReport.TabIndex = 19;
			this.ucSelectReport.OnShowReport += new System.EventHandler<HospitalDepartment.UserControls.SelectReportEventArgs>(this.ucSelectReport_OnShowReport);
			// 
			// colRequestDate
			// 
			this.colRequestDate.DataPropertyName = "RequestDate";
			dataGridViewCellStyle1.Format = "D";
			dataGridViewCellStyle1.NullValue = null;
			this.colRequestDate.DefaultCellStyle = dataGridViewCellStyle1;
			this.colRequestDate.HeaderText = "Дата подачи заявки";
			this.colRequestDate.Name = "colRequestDate";
			this.colRequestDate.ReadOnly = true;
			// 
			// colExecutionDate
			// 
			this.colExecutionDate.DataPropertyName = "ExecutionDate";
			dataGridViewCellStyle2.Format = "D";
			this.colExecutionDate.DefaultCellStyle = dataGridViewCellStyle2;
			this.colExecutionDate.HeaderText = "Дата выполнения";
			this.colExecutionDate.Name = "colExecutionDate";
			this.colExecutionDate.ReadOnly = true;
			// 
			// PatientConsultationsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 312);
			this.Controls.Add(this.ucSelectReport);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnOk);
			this.Name = "PatientConsultationsForm";
			this.Text = "Консультации";
			this.Load += new System.EventHandler(this.PatientConsultationsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Button btnAdd;
		private HospitalDepartment.UserControls.SelectReportUserControl ucSelectReport;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colExecutionDate;
	}
}