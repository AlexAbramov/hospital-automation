namespace HospitalDepartment.Forms
{
	partial class DocumentsForm
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
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateOutgoingDocument = new System.Windows.Forms.Button();
            this.btnCreateIncomingDocument = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(446, 354);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Закрыть";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(446, 12);
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
            this.colDate,
            this.colDocumentTypeName,
            this.colUserName,
            this.colCompleted});
            this.gridView.Location = new System.Drawing.Point(12, 12);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(422, 365);
            this.gridView.TabIndex = 3;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colDocumentTypeName
            // 
            this.colDocumentTypeName.DataPropertyName = "DocumentTypeName";
            this.colDocumentTypeName.HeaderText = "Тип документа";
            this.colDocumentTypeName.Name = "colDocumentTypeName";
            this.colDocumentTypeName.ReadOnly = true;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "Пользователь";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colCompleted
            // 
            this.colCompleted.DataPropertyName = "Completed";
            this.colCompleted.HeaderText = "Укомплектован";
            this.colCompleted.Name = "colCompleted";
            this.colCompleted.ReadOnly = true;
            this.colCompleted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCompleted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnCreateOutgoingDocument);
            this.groupBox1.Controls.Add(this.btnCreateIncomingDocument);
            this.groupBox1.Location = new System.Drawing.Point(440, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            this.groupBox1.Visible = false;
            // 
            // btnCreateOutgoingDocument
            // 
            this.btnCreateOutgoingDocument.Location = new System.Drawing.Point(6, 48);
            this.btnCreateOutgoingDocument.Name = "btnCreateOutgoingDocument";
            this.btnCreateOutgoingDocument.Size = new System.Drawing.Size(75, 23);
            this.btnCreateOutgoingDocument.TabIndex = 5;
            this.btnCreateOutgoingDocument.Text = "Расход";
            this.btnCreateOutgoingDocument.UseVisualStyleBackColor = true;
            this.btnCreateOutgoingDocument.Click += new System.EventHandler(this.btnCreateOutgoingDocument_Click);
            // 
            // btnCreateIncomingDocument
            // 
            this.btnCreateIncomingDocument.Location = new System.Drawing.Point(6, 19);
            this.btnCreateIncomingDocument.Name = "btnCreateIncomingDocument";
            this.btnCreateIncomingDocument.Size = new System.Drawing.Size(75, 23);
            this.btnCreateIncomingDocument.TabIndex = 3;
            this.btnCreateIncomingDocument.Text = "Приход";
            this.btnCreateIncomingDocument.UseVisualStyleBackColor = true;
            this.btnCreateIncomingDocument.Click += new System.EventHandler(this.btnCreateIncomingDocument_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(446, 41);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // DocumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 389);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnOk);
            this.Name = "DocumentsForm";
            this.Text = "Складские документы";
            this.Load += new System.EventHandler(this.DocumentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCreateOutgoingDocument;
		private System.Windows.Forms.Button btnCreateIncomingDocument;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentTypeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colCompleted;
	}
}