namespace HospitalDepartment.Forms
{
	partial class ProductsForm
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMedicamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPackedNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUnitCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBaseUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(453, 354);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Закрыть";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Location = new System.Drawing.Point(453, 12);
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
            this.colName,
            this.colMedicamentName,
            this.colMaker,
            this.colPackedNumber,
            this.colUnitCount,
            this.colBaseUnitName});
			this.gridView.Location = new System.Drawing.Point(12, 12);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.ReadOnly = true;
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(435, 365);
			this.gridView.TabIndex = 3;
			this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(453, 41);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
			// colMedicamentName
			// 
			this.colMedicamentName.DataPropertyName = "MedicamentName";
			this.colMedicamentName.HeaderText = "Международное название";
			this.colMedicamentName.Name = "colMedicamentName";
			this.colMedicamentName.ReadOnly = true;
			// 
			// colMaker
			// 
			this.colMaker.DataPropertyName = "Maker";
			this.colMaker.HeaderText = "Производитель";
			this.colMaker.Name = "colMaker";
			this.colMaker.ReadOnly = true;
			// 
			// colPackedNumber
			// 
			this.colPackedNumber.DataPropertyName = "PackedNumber";
			this.colPackedNumber.HeaderText = "Количество в упаковке";
			this.colPackedNumber.Name = "colPackedNumber";
			this.colPackedNumber.ReadOnly = true;
			// 
			// colUnitCount
			// 
			this.colUnitCount.DataPropertyName = "UnitCount";
			this.colUnitCount.HeaderText = "Доза в баз. еденицах";
			this.colUnitCount.Name = "colUnitCount";
			this.colUnitCount.ReadOnly = true;
			// 
			// colBaseUnitName
			// 
			this.colBaseUnitName.DataPropertyName = "BaseUnitName";
			this.colBaseUnitName.HeaderText = "Ед. изм.";
			this.colBaseUnitName.Name = "colBaseUnitName";
			this.colBaseUnitName.ReadOnly = true;
			// 
			// ProductsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 389);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnOk);
			this.Name = "ProductsForm";
			this.Text = "Номенклатура";
			this.Load += new System.EventHandler(this.ProductsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMedicamentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaker;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPackedNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBaseUnitName;
	}
}