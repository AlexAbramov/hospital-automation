namespace HospitalDepartment.UserControls
{
	partial class SelectStoreProductUserControl
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
			this.gridView = new System.Windows.Forms.DataGridView();
			this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// gridView
			// 
			this.gridView.AllowUserToAddRows = false;
			this.gridView.AllowUserToDeleteRows = false;
			this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colProductName,
            this.colMaker,
            this.colPrice,
            this.colExpiredDate});
			this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridView.Location = new System.Drawing.Point(0, 0);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.ReadOnly = true;
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(375, 441);
			this.gridView.TabIndex = 5;
			this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
			// 
			// colCode
			// 
			this.colCode.DataPropertyName = "Code";
			this.colCode.HeaderText = "Код";
			this.colCode.Name = "colCode";
			this.colCode.ReadOnly = true;
			this.colCode.Visible = false;
			// 
			// colProductName
			// 
			this.colProductName.DataPropertyName = "ProductName";
			this.colProductName.HeaderText = "Наименование";
			this.colProductName.Name = "colProductName";
			this.colProductName.ReadOnly = true;
			// 
			// colMaker
			// 
			this.colMaker.DataPropertyName = "Maker";
			this.colMaker.HeaderText = "Производитель";
			this.colMaker.Name = "colMaker";
			this.colMaker.ReadOnly = true;
			this.colMaker.Visible = false;
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
			// SelectStoreProductUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridView);
			this.Name = "SelectStoreProductUserControl";
			this.Size = new System.Drawing.Size(375, 441);
			this.Load += new System.EventHandler(this.SelectStoreProductUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaker;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colExpiredDate;

	}
}
