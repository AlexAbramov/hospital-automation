namespace HospitalDepartment.UserControls
{
	partial class AnalysesUserControl
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
			this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colExecutionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAnalysisTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.ucSelectAnalysisType = new HospitalDepartment.UserControls.SelectAnalysisTypeUserControl();
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
            this.colRequestDate,
            this.colExecutionDate,
            this.colAnalysisTypeName});
			this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridView.Location = new System.Drawing.Point(0, 0);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.ReadOnly = true;
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.gridView.Size = new System.Drawing.Size(413, 484);
			this.gridView.TabIndex = 5;
			this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
			// 
			// colRequestDate
			// 
			this.colRequestDate.DataPropertyName = "RequestDate";
			this.colRequestDate.HeaderText = "Дата заявки";
			this.colRequestDate.Name = "colRequestDate";
			this.colRequestDate.ReadOnly = true;
			// 
			// colExecutionDate
			// 
			this.colExecutionDate.DataPropertyName = "ExecutionDate";
			this.colExecutionDate.HeaderText = "Дата выполнения";
			this.colExecutionDate.Name = "colExecutionDate";
			this.colExecutionDate.ReadOnly = true;
			// 
			// colAnalysisTypeName
			// 
			this.colAnalysisTypeName.DataPropertyName = "AnalysisTypeName";
			this.colAnalysisTypeName.HeaderText = "Тип анализа";
			this.colAnalysisTypeName.Name = "colAnalysisTypeName";
			this.colAnalysisTypeName.ReadOnly = true;
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
			this.splitContainer1.Panel2.Controls.Add(this.ucSelectAnalysisType);
			this.splitContainer1.Size = new System.Drawing.Size(679, 484);
			this.splitContainer1.SplitterDistance = 413;
			this.splitContainer1.TabIndex = 15;
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
			// 
			// ucSelectAnalysisType
			// 
			this.ucSelectAnalysisType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucSelectAnalysisType.Location = new System.Drawing.Point(0, 0);
			this.ucSelectAnalysisType.Name = "ucSelectAnalysisType";
			this.ucSelectAnalysisType.Size = new System.Drawing.Size(262, 484);
			this.ucSelectAnalysisType.TabIndex = 0;
			this.ucSelectAnalysisType.OnSelected += new System.EventHandler(this.ucSelectAnalysisType_OnSelected);
			// 
			// AnalysesUserControl
			// 
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.splitContainer1);
			this.Name = "AnalysesUserControl";
			this.Size = new System.Drawing.Size(685, 519);
			this.Load += new System.EventHandler(this.AnalysesUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnGenerate;
		private SelectAnalysisTypeUserControl ucSelectAnalysisType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colExecutionDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAnalysisTypeName;
	}
}
