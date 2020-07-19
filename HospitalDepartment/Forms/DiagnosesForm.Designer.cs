namespace HospitalDepartment.Forms
{
	partial class DiagnosesForm
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
			this.btnOpen = new System.Windows.Forms.Button();
			this.gridView = new System.Windows.Forms.DataGridView();
			this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHospitalStayHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHospitalStayFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHospitalStaySecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHospitalStayDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(441, 354);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Закрыть";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Location = new System.Drawing.Point(441, 12);
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
            this.colCode,
            this.colMCode,
            this.colName,
            this.colHospitalStayHigh,
            this.colHospitalStayFirst,
            this.colHospitalStaySecond,
            this.colHospitalStayDay});
			this.gridView.Location = new System.Drawing.Point(12, 12);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.ReadOnly = true;
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(423, 365);
			this.gridView.TabIndex = 3;
			this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
			// 
			// colCode
			// 
			this.colCode.DataPropertyName = "Code";
			this.colCode.HeaderText = "Код КСГ";
			this.colCode.Name = "colCode";
			this.colCode.ReadOnly = true;
			// 
			// colMCode
			// 
			this.colMCode.DataPropertyName = "MCode";
			this.colMCode.HeaderText = "МКБ";
			this.colMCode.Name = "colMCode";
			this.colMCode.ReadOnly = true;
			// 
			// colName
			// 
			this.colName.DataPropertyName = "Name";
			this.colName.HeaderText = "Название";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colHospitalStayHigh
			// 
			this.colHospitalStayHigh.DataPropertyName = "HospitalStayHigh";
			this.colHospitalStayHigh.HeaderText = "Высшая";
			this.colHospitalStayHigh.Name = "colHospitalStayHigh";
			this.colHospitalStayHigh.ReadOnly = true;
			// 
			// colHospitalStayFirst
			// 
			this.colHospitalStayFirst.DataPropertyName = "HospitalStayFirst";
			this.colHospitalStayFirst.HeaderText = "Первая";
			this.colHospitalStayFirst.Name = "colHospitalStayFirst";
			this.colHospitalStayFirst.ReadOnly = true;
			// 
			// colHospitalStaySecond
			// 
			this.colHospitalStaySecond.DataPropertyName = "HospitalStaySecond";
			this.colHospitalStaySecond.HeaderText = "Вторая";
			this.colHospitalStaySecond.Name = "colHospitalStaySecond";
			this.colHospitalStaySecond.ReadOnly = true;
			// 
			// colHospitalStayDay
			// 
			this.colHospitalStayDay.DataPropertyName = "HospitalStayDay";
			this.colHospitalStayDay.HeaderText = "ДС";
			this.colHospitalStayDay.Name = "colHospitalStayDay";
			this.colHospitalStayDay.ReadOnly = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(441, 41);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(6, 19);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(75, 23);
			this.btnImport.TabIndex = 5;
			this.btnImport.Text = "Импорт";
			this.btnImport.UseVisualStyleBackColor = true;
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(6, 48);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 6;
			this.btnExport.Text = "Экспорт";
			this.btnExport.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.btnImport);
			this.groupBox1.Controls.Add(this.btnExport);
			this.groupBox1.Location = new System.Drawing.Point(441, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(87, 90);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Данные";
			// 
			// DiagnosesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 389);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnOk);
			this.Name = "DiagnosesForm";
			this.Text = "Диагнозы";
			this.Load += new System.EventHandler(this.DiagnosesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHospitalStayHigh;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHospitalStayFirst;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHospitalStaySecond;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHospitalStayDay;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}