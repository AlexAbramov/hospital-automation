namespace HospitalDepartment.UserControls
{
	partial class SelectProductUserControl
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
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMedicamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPackedNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colMedicamentName,
            this.colPackedNumber,
            this.colMaker});
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
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Code";
			this.dataGridViewTextBoxColumn1.HeaderText = "Код";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// colMedicamentName
			// 
			this.colMedicamentName.DataPropertyName = "MedicamentName";
			this.colMedicamentName.HeaderText = "Международное название";
			this.colMedicamentName.Name = "colMedicamentName";
			this.colMedicamentName.ReadOnly = true;
			// 
			// colPackedNumber
			// 
			this.colPackedNumber.DataPropertyName = "PackedNumber";
			this.colPackedNumber.HeaderText = "Количество в упаковке";
			this.colPackedNumber.Name = "colPackedNumber";
			this.colPackedNumber.ReadOnly = true;
			// 
			// colMaker
			// 
			this.colMaker.DataPropertyName = "Maker";
			this.colMaker.HeaderText = "Производитель";
			this.colMaker.Name = "colMaker";
			this.colMaker.ReadOnly = true;
			// 
			// SelectProductUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridView);
			this.Name = "SelectProductUserControl";
			this.Size = new System.Drawing.Size(375, 441);
			this.Load += new System.EventHandler(this.SelectProductUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMedicamentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPackedNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaker;

	}
}
