namespace HospitalDepartment.Forms
{
	partial class HandbookGroupForm
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
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.gridView = new System.Windows.Forms.DataGridView();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colFrequent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMultiline = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnOpen = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(419, 417);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Имя группы:";
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(101, 12);
			this.tbName.Name = "tbName";
			this.tbName.ReadOnly = true;
			this.tbName.Size = new System.Drawing.Size(312, 20);
			this.tbName.TabIndex = 9;
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
            this.colName,
            this.colDataType,
            this.colFrequent,
            this.colDefaultValue,
            this.colItems,
            this.colMultiline});
			this.gridView.Location = new System.Drawing.Point(12, 38);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(401, 402);
			this.gridView.TabIndex = 8;
			this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
			// 
			// colName
			// 
			this.colName.DataPropertyName = "Name";
			this.colName.FillWeight = 150F;
			this.colName.HeaderText = "Имя справочника";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colDataType
			// 
			this.colDataType.DataPropertyName = "HandbookType";
			this.colDataType.DisplayStyleForCurrentCellOnly = true;
			this.colDataType.HeaderText = "Тип";
			this.colDataType.Name = "colDataType";
			// 
			// colFrequent
			// 
			this.colFrequent.DataPropertyName = "Frequent";
			this.colFrequent.HeaderText = "Часто используемый";
			this.colFrequent.Name = "colFrequent";
			// 
			// colDefaultValue
			// 
			this.colDefaultValue.DataPropertyName = "DefaultValue";
			this.colDefaultValue.HeaderText = "Значение по умолчанию";
			this.colDefaultValue.Name = "colDefaultValue";
			this.colDefaultValue.ReadOnly = true;
			// 
			// colItems
			// 
			this.colItems.DataPropertyName = "ItemsList";
			this.colItems.FillWeight = 200F;
			this.colItems.HeaderText = "Список значений";
			this.colItems.Name = "colItems";
			this.colItems.ReadOnly = true;
			// 
			// colMultiline
			// 
			this.colMultiline.DataPropertyName = "IsMultiline";
			this.colMultiline.HeaderText = "Многострочный";
			this.colMultiline.Name = "colMultiline";
			this.colMultiline.ReadOnly = true;
			this.colMultiline.Visible = false;
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Location = new System.Drawing.Point(419, 38);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 7;
			this.btnOpen.Text = "Открыть";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// HandbookGroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 452);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnClose);
			this.Name = "HandbookGroupForm";
			this.Text = "Группа справочников";
			this.Load += new System.EventHandler(this.HandbooksForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewComboBoxColumn colDataType;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colFrequent;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDefaultValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colItems;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMultiline;
	}
}