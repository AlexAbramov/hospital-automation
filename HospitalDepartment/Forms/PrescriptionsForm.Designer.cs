namespace HospitalDepartment.Forms
{
    partial class PrescriptionsForm
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(468, 315);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Закрыть";
            this.btnOk.UseVisualStyleBackColor = true;
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
            this.colProductName,
            this.colPrescriptionTypeName,
            this.colStartDate,
            this.colEndDate,
            this.colDuration,
            this.colDose,
            this.colFactor,
            this.colBaseUnitName,
            this.colUnitCount});
            this.gridView.Location = new System.Drawing.Point(12, 12);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(450, 326);
            this.gridView.TabIndex = 6;
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
            // PrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 350);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnOk);
            this.Name = "PrescriptionsForm";
            this.Text = "Назначения";
            this.Load += new System.EventHandler(this.PrescriptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView gridView;
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