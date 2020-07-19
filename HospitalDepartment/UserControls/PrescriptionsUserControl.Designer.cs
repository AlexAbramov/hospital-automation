namespace HospitalDepartment.UserControls
{
	partial class PrescriptionsUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrescriptionTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucSelectStoreProduct = new HospitalDepartment.UserControls.SelectStoreProductUserControl();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblHospitalStay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colPrescriptionTypeName,
            this.colStartDate,
            this.colEndDate,
            this.colDuration,
            this.colDose,
            this.colFactor,
            this.colBaseUnitName,
            this.colUnitCount});
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(413, 484);
            this.gridView.TabIndex = 5;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "Медикамент";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colPrescriptionTypeName
            // 
            this.colPrescriptionTypeName.DataPropertyName = "PrescriptionTypeName";
            this.colPrescriptionTypeName.HeaderText = "Способ приёма";
            this.colPrescriptionTypeName.Name = "colPrescriptionTypeName";
            this.colPrescriptionTypeName.ReadOnly = true;
            this.colPrescriptionTypeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Format = "dd.MM.yy HH";
            dataGridViewCellStyle1.NullValue = null;
            this.colStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colStartDate.HeaderText = "Начало приёма";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            this.colEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Format = "dd.MM.yy HH";
            this.colEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEndDate.HeaderText = "colEndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            // 
            // colDuration
            // 
            this.colDuration.DataPropertyName = "Duration";
            this.colDuration.HeaderText = "Продолжительность";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            this.colDuration.Visible = false;
            // 
            // colDose
            // 
            this.colDose.DataPropertyName = "Dose";
            this.colDose.HeaderText = "Доза";
            this.colDose.Name = "colDose";
            this.colDose.ReadOnly = true;
            // 
            // colFactor
            // 
            this.colFactor.DataPropertyName = "Multiplicity";
            this.colFactor.HeaderText = "Кратность";
            this.colFactor.Name = "colFactor";
            this.colFactor.ReadOnly = true;
            // 
            // colBaseUnitName
            // 
            this.colBaseUnitName.DataPropertyName = "BaseUnitName";
            this.colBaseUnitName.HeaderText = "Ед. изм.";
            this.colBaseUnitName.Name = "colBaseUnitName";
            this.colBaseUnitName.ReadOnly = true;
            // 
            // colUnitCount
            // 
            this.colUnitCount.DataPropertyName = "UnitCount";
            this.colUnitCount.HeaderText = "Доза упаковочн.";
            this.colUnitCount.Name = "colUnitCount";
            this.colUnitCount.ReadOnly = true;
            this.colUnitCount.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucSelectStoreProduct);
            this.splitContainer1.Size = new System.Drawing.Size(679, 484);
            this.splitContainer1.SplitterDistance = 413;
            this.splitContainer1.TabIndex = 15;
            // 
            // ucSelectStoreProduct
            // 
            this.ucSelectStoreProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectStoreProduct.Location = new System.Drawing.Point(0, 0);
            this.ucSelectStoreProduct.Name = "ucSelectStoreProduct";
            this.ucSelectStoreProduct.Size = new System.Drawing.Size(262, 484);
            this.ucSelectStoreProduct.TabIndex = 0;
            this.ucSelectStoreProduct.OnSelected += new System.EventHandler(this.ucSelectStoreProduct_OnSelected);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(581, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 23);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Автозаполнение";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblHospitalStay
            // 
            this.lblHospitalStay.AutoSize = true;
            this.lblHospitalStay.Location = new System.Drawing.Point(3, 8);
            this.lblHospitalStay.Name = "lblHospitalStay";
            this.lblHospitalStay.Size = new System.Drawing.Size(191, 13);
            this.lblHospitalStay.TabIndex = 17;
            this.lblHospitalStay.Text = "Ориентировочный срок пребывания";
            // 
            // PrescriptionsUserControl
            // 
            this.Controls.Add(this.lblHospitalStay);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PrescriptionsUserControl";
            this.Size = new System.Drawing.Size(685, 519);
            this.Load += new System.EventHandler(this.PrescriptionsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private SelectStoreProductUserControl ucSelectStoreProduct;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label lblHospitalStay;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrescriptionTypeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDose;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFactor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBaseUnitName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCount;
	}
}
