namespace HospitalDepartment.Forms
{
	partial class PatientsPrescriptionsForm
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.wardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseUnitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplicityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsPrescriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDataSet = new HospitalDepartment.Reports.ReportsDataSet();
            this.lbPrescriptionTypes = new System.Windows.Forms.CheckedListBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.nudNDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbParams = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsPrescriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNDays)).BeginInit();
            this.gbParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(512, 154);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Обновить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(512, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата:";
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(54, 19);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(145, 20);
            this.dpDate.TabIndex = 12;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoGenerateColumns = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wardNumberDataGridViewTextBoxColumn,
            this.patientIdDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.prescriptionTypeNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.doseDataGridViewTextBoxColumn,
            this.baseUnitNameDataGridViewTextBoxColumn,
            this.multiplicityDataGridViewTextBoxColumn});
            this.gridView.DataSource = this.patientsPrescriptionsBindingSource;
            this.gridView.Location = new System.Drawing.Point(12, 154);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(494, 227);
            this.gridView.TabIndex = 13;
            // 
            // wardNumberDataGridViewTextBoxColumn
            // 
            this.wardNumberDataGridViewTextBoxColumn.DataPropertyName = "WardNumber";
            this.wardNumberDataGridViewTextBoxColumn.FillWeight = 50F;
            this.wardNumberDataGridViewTextBoxColumn.HeaderText = "Палата";
            this.wardNumberDataGridViewTextBoxColumn.Name = "wardNumberDataGridViewTextBoxColumn";
            this.wardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "№";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Пациент";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prescriptionTypeNameDataGridViewTextBoxColumn
            // 
            this.prescriptionTypeNameDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionTypeName";
            this.prescriptionTypeNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.prescriptionTypeNameDataGridViewTextBoxColumn.HeaderText = "Назначение";
            this.prescriptionTypeNameDataGridViewTextBoxColumn.Name = "prescriptionTypeNameDataGridViewTextBoxColumn";
            this.prescriptionTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Медикамент";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doseDataGridViewTextBoxColumn
            // 
            this.doseDataGridViewTextBoxColumn.DataPropertyName = "Dose";
            this.doseDataGridViewTextBoxColumn.HeaderText = "Доза";
            this.doseDataGridViewTextBoxColumn.Name = "doseDataGridViewTextBoxColumn";
            this.doseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baseUnitNameDataGridViewTextBoxColumn
            // 
            this.baseUnitNameDataGridViewTextBoxColumn.DataPropertyName = "BaseUnitName";
            this.baseUnitNameDataGridViewTextBoxColumn.HeaderText = "Ед.";
            this.baseUnitNameDataGridViewTextBoxColumn.Name = "baseUnitNameDataGridViewTextBoxColumn";
            this.baseUnitNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // multiplicityDataGridViewTextBoxColumn
            // 
            this.multiplicityDataGridViewTextBoxColumn.DataPropertyName = "Multiplicity";
            this.multiplicityDataGridViewTextBoxColumn.FillWeight = 50F;
            this.multiplicityDataGridViewTextBoxColumn.HeaderText = "Кратность";
            this.multiplicityDataGridViewTextBoxColumn.Name = "multiplicityDataGridViewTextBoxColumn";
            this.multiplicityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientsPrescriptionsBindingSource
            // 
            this.patientsPrescriptionsBindingSource.DataMember = "PatientsPrescriptions";
            this.patientsPrescriptionsBindingSource.DataSource = this.reportsDataSet;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "ReportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbPrescriptionTypes
            // 
            this.lbPrescriptionTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrescriptionTypes.CheckOnClick = true;
            this.lbPrescriptionTypes.FormattingEnabled = true;
            this.lbPrescriptionTypes.IntegralHeight = false;
            this.lbPrescriptionTypes.Location = new System.Drawing.Point(286, 32);
            this.lbPrescriptionTypes.Name = "lbPrescriptionTypes";
            this.lbPrescriptionTypes.Size = new System.Drawing.Size(283, 98);
            this.lbPrescriptionTypes.TabIndex = 14;
            this.lbPrescriptionTypes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbPrescriptionTypes_ItemCheck);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.Location = new System.Drawing.Point(6, 68);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(274, 62);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "Пользователь: ";
            // 
            // nudNDays
            // 
            this.nudNDays.Location = new System.Drawing.Point(156, 45);
            this.nudNDays.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudNDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNDays.Name = "nudNDays";
            this.nudNDays.Size = new System.Drawing.Size(43, 20);
            this.nudNDays.TabIndex = 16;
            this.nudNDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNDays.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Кол-во дней:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Виды назначений:";
            // 
            // gbParams
            // 
            this.gbParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParams.Controls.Add(this.dpDate);
            this.gbParams.Controls.Add(this.label2);
            this.gbParams.Controls.Add(this.lbPrescriptionTypes);
            this.gbParams.Controls.Add(this.lblUser);
            this.gbParams.Controls.Add(this.label3);
            this.gbParams.Controls.Add(this.nudNDays);
            this.gbParams.Controls.Add(this.label1);
            this.gbParams.Location = new System.Drawing.Point(12, 12);
            this.gbParams.Name = "gbParams";
            this.gbParams.Size = new System.Drawing.Size(575, 136);
            this.gbParams.TabIndex = 20;
            this.gbParams.TabStop = false;
            // 
            // PatientsPrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 393);
            this.Controls.Add(this.gbParams);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "PatientsPrescriptionsForm";
            this.Text = "Назначения наблюдаемым пациентам";
            this.Load += new System.EventHandler(this.DocumentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsPrescriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNDays)).EndInit();
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.CheckedListBox lbPrescriptionTypes;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.NumericUpDown nudNDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.BindingSource patientsPrescriptionsBindingSource;
        private HospitalDepartment.Reports.ReportsDataSet reportsDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn wardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseUnitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplicityDataGridViewTextBoxColumn;
	}
}