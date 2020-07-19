namespace HospitalDepartment.UserControls
{
	partial class SelectAnalysisTypeUserControl
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
			this.coName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHandbookGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.coName,
            this.colCode,
            this.colHandbookGroupId});
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
			// coName
			// 
			this.coName.DataPropertyName = "Name";
			this.coName.FillWeight = 200F;
			this.coName.HeaderText = "Анализ";
			this.coName.Name = "coName";
			this.coName.ReadOnly = true;
			// 
			// colCode
			// 
			this.colCode.DataPropertyName = "Code";
			this.colCode.HeaderText = "Код";
			this.colCode.Name = "colCode";
			this.colCode.ReadOnly = true;
			// 
			// colHandbookGroupId
			// 
			this.colHandbookGroupId.DataPropertyName = "HandbookGroupId";
			this.colHandbookGroupId.HeaderText = "Группа справочников";
			this.colHandbookGroupId.Name = "colHandbookGroupId";
			this.colHandbookGroupId.ReadOnly = true;
			this.colHandbookGroupId.Visible = false;
			// 
			// SelectAnalysisTypeUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridView);
			this.Name = "SelectAnalysisTypeUserControl";
			this.Size = new System.Drawing.Size(375, 441);
			this.Load += new System.EventHandler(this.SelectAnalysisTypeUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn coName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHandbookGroupId;

	}
}
