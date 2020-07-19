namespace HospitalDepartment.Forms
{
	partial class PrescriptionsOrderForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPrescriptionTypes = new System.Windows.Forms.CheckedListBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.nudNDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNDays)).BeginInit();
            this.gbParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(431, 358);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Сохранить";
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
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colName,
            this.colPrice,
            this.colExpiredDate,
            this.colPlan,
            this.colCount});
            this.gridView.Location = new System.Drawing.Point(12, 154);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(575, 198);
            this.gridView.TabIndex = 13;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Код";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Наименование";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Цена";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colExpiredDate
            // 
            this.colExpiredDate.DataPropertyName = "ExpiredDate";
            this.colExpiredDate.HeaderText = "Годен до";
            this.colExpiredDate.Name = "colExpiredDate";
            this.colExpiredDate.ReadOnly = true;
            // 
            // colPlan
            // 
            this.colPlan.DataPropertyName = "PlannedCount";
            this.colPlan.HeaderText = "План";
            this.colPlan.Name = "colPlan";
            this.colPlan.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.DataPropertyName = "Count";
            this.colCount.HeaderText = "Факт";
            this.colCount.Name = "colCount";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Кол-во дней:";
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
            this.gbParams.Text = "Требование";
            // 
            // chkCompleted
            // 
            this.chkCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Enabled = false;
            this.chkCompleted.Location = new System.Drawing.Point(12, 362);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(110, 17);
            this.chkCompleted.TabIndex = 20;
            this.chkCompleted.Text = "укомплектовано";
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // PrescriptionsOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 393);
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.gbParams);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "PrescriptionsOrderForm";
            this.Text = "Требование на получение медикаментов";
            this.Load += new System.EventHandler(this.DocumentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNDays)).EndInit();
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
	}
}