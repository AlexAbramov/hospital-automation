namespace HospitalDepartment.UserControls
{
	partial class ReportsUserControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnOpen = new System.Windows.Forms.Button();
			this.gridView = new System.Windows.Forms.DataGridView();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colReportBuilder = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colEmbeddedResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Location = new System.Drawing.Point(396, 3);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 3;
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
            this.colName,
            this.colReportBuilder,
            this.colEmbeddedResource,
            this.colPath,
            this.colVisible});
			this.gridView.Location = new System.Drawing.Point(3, 3);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(387, 466);
			this.gridView.TabIndex = 4;
			this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
			// 
			// colName
			// 
			this.colName.DataPropertyName = "Name";
			this.colName.HeaderText = "Имя";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colReportBuilder
			// 
			this.colReportBuilder.DataPropertyName = "ReportBuilderId";
			this.colReportBuilder.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.colReportBuilder.HeaderText = "Тип отчета";
			this.colReportBuilder.Name = "colReportBuilder";
			this.colReportBuilder.ReadOnly = true;
			this.colReportBuilder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colReportBuilder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colEmbeddedResource
			// 
			this.colEmbeddedResource.DataPropertyName = "EmbeddedResource";
			this.colEmbeddedResource.HeaderText = "Ресурс";
			this.colEmbeddedResource.Name = "colEmbeddedResource";
			this.colEmbeddedResource.ReadOnly = true;
			// 
			// colPath
			// 
			this.colPath.DataPropertyName = "Path";
			this.colPath.HeaderText = "Файл";
			this.colPath.Name = "colPath";
			this.colPath.ReadOnly = true;
			// 
			// colVisible
			// 
			this.colVisible.DataPropertyName = "Visible";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.NullValue = false;
			this.colVisible.DefaultCellStyle = dataGridViewCellStyle3;
			this.colVisible.HeaderText = "Видимый";
			this.colVisible.Name = "colVisible";
			// 
			// ReportsUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.btnOpen);
			this.Name = "ReportsUserControl";
			this.Size = new System.Drawing.Size(474, 472);
			this.Load += new System.EventHandler(this.ReportsUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewComboBoxColumn colReportBuilder;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmbeddedResource;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colVisible;
	}
}
