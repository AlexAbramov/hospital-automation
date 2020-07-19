namespace HospitalDepartment.Forms
{
	partial class WatchingForm
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
		System.Windows.Forms.DataGridView gvPatients;
		System.Windows.Forms.DataGridView gvWards;

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAdmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWardNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colChecked2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnRename = new System.Windows.Forms.Button();
			this.lbSchemes = new System.Windows.Forms.ListBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.colChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colNumberOfBeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWardTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gvPatients = new System.Windows.Forms.DataGridView();
			gvWards = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(gvPatients)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(gvWards)).BeginInit();
			this.SuspendLayout();
			// 
			// gvPatients
			// 
			gvPatients.AllowUserToAddRows = false;
			gvPatients.AllowUserToDeleteRows = false;
			gvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			gvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colAdmissionDate,
            this.colSurname,
            this.colName,
            this.colMiddleName,
            this.colWardNumber2,
            this.colChecked2,
            this.colUserName});
			gvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
			gvPatients.Location = new System.Drawing.Point(0, 0);
			gvPatients.Name = "gvPatients";
			gvPatients.Size = new System.Drawing.Size(367, 344);
			gvPatients.TabIndex = 1;
			gvPatients.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gvPatients_CellBeginEdit);
			// 
			// colId
			// 
			this.colId.DataPropertyName = "Id";
			this.colId.HeaderText = "Номер";
			this.colId.Name = "colId";
			this.colId.ReadOnly = true;
			// 
			// colAdmissionDate
			// 
			this.colAdmissionDate.DataPropertyName = "AdmissionDate";
			this.colAdmissionDate.HeaderText = "Дата прибытия";
			this.colAdmissionDate.Name = "colAdmissionDate";
			this.colAdmissionDate.ReadOnly = true;
			// 
			// colSurname
			// 
			this.colSurname.DataPropertyName = "Surname";
			this.colSurname.HeaderText = "Фамилия";
			this.colSurname.Name = "colSurname";
			this.colSurname.ReadOnly = true;
			// 
			// colName
			// 
			this.colName.DataPropertyName = "Name";
			this.colName.HeaderText = "Имя";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colMiddleName
			// 
			this.colMiddleName.DataPropertyName = "MiddleName";
			this.colMiddleName.HeaderText = "Отчество";
			this.colMiddleName.Name = "colMiddleName";
			this.colMiddleName.ReadOnly = true;
			// 
			// colWardNumber2
			// 
			this.colWardNumber2.DataPropertyName = "WardNumber";
			this.colWardNumber2.HeaderText = "Палата";
			this.colWardNumber2.Name = "colWardNumber2";
			this.colWardNumber2.ReadOnly = true;
			this.colWardNumber2.Visible = false;
			// 
			// colChecked2
			// 
			this.colChecked2.DataPropertyName = "Checked";
			this.colChecked2.HeaderText = "Заступить";
			this.colChecked2.Name = "colChecked2";
			// 
			// colUserName
			// 
			this.colUserName.DataPropertyName = "UserName";
			this.colUserName.HeaderText = "Дежурный";
			this.colUserName.Name = "colUserName";
			this.colUserName.ReadOnly = true;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(580, 304);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(105, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Войти";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(580, 333);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(105, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.btnRemove);
			this.groupBox1.Controls.Add(this.btnRename);
			this.groupBox1.Controls.Add(this.lbSchemes);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Location = new System.Drawing.Point(574, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(117, 214);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Схемы";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(6, 98);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(105, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.Location = new System.Drawing.Point(6, 127);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(105, 23);
			this.btnRemove.TabIndex = 7;
			this.btnRemove.Text = "Удалить";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnRename
			// 
			this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.btnRename.Location = new System.Drawing.Point(6, 156);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(105, 23);
			this.btnRename.TabIndex = 6;
			this.btnRename.Text = "Переименовать";
			this.btnRename.UseVisualStyleBackColor = true;
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
			// 
			// lbSchemes
			// 
			this.lbSchemes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lbSchemes.DisplayMember = "Name";
			this.lbSchemes.FormattingEnabled = true;
			this.lbSchemes.IntegralHeight = false;
			this.lbSchemes.Location = new System.Drawing.Point(6, 19);
			this.lbSchemes.Name = "lbSchemes";
			this.lbSchemes.Size = new System.Drawing.Size(105, 73);
			this.lbSchemes.TabIndex = 5;
			this.lbSchemes.SelectedIndexChanged += new System.EventHandler(this.lbSchemes_SelectedIndexChanged);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Location = new System.Drawing.Point(6, 185);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(105, 23);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Обновить";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(gvWards);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(gvPatients);
			this.splitContainer1.Size = new System.Drawing.Size(556, 344);
			this.splitContainer1.SplitterDistance = 185;
			this.splitContainer1.TabIndex = 9;
			// 
			// colChecked
			// 
			this.colChecked.DataPropertyName = "Checked";
			this.colChecked.HeaderText = "Заступить";
			this.colChecked.Name = "colChecked";
			// 
			// colNumberOfBeds
			// 
			this.colNumberOfBeds.DataPropertyName = "NumberOfBeds";
			this.colNumberOfBeds.HeaderText = "Коек";
			this.colNumberOfBeds.Name = "colNumberOfBeds";
			this.colNumberOfBeds.ReadOnly = true;
			this.colNumberOfBeds.Visible = false;
			// 
			// colWardTypeName
			// 
			this.colWardTypeName.DataPropertyName = "WardTypeName";
			this.colWardTypeName.HeaderText = "Тип палаты";
			this.colWardTypeName.Name = "colWardTypeName";
			this.colWardTypeName.ReadOnly = true;
			// 
			// colWardNumber
			// 
			this.colWardNumber.DataPropertyName = "Number";
			this.colWardNumber.HeaderText = "Номер";
			this.colWardNumber.Name = "colWardNumber";
			this.colWardNumber.ReadOnly = true;
			// 
			// gvWards
			// 
			gvWards.AllowUserToAddRows = false;
			gvWards.AllowUserToDeleteRows = false;
			gvWards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			gvWards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gvWards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWardNumber,
            this.colWardTypeName,
            this.colNumberOfBeds,
            this.colChecked});
			gvWards.Dock = System.Windows.Forms.DockStyle.Fill;
			gvWards.Location = new System.Drawing.Point(0, 0);
			gvWards.Name = "gvWards";
			gvWards.Size = new System.Drawing.Size(185, 344);
			gvWards.TabIndex = 13;
			gvWards.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvWards_CellValueChanged);
			gvWards.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvWards_RowEnter);
			gvWards.CurrentCellDirtyStateChanged += new System.EventHandler(this.gvWards_CurrentCellDirtyStateChanged);
			// 
			// WatchingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 368);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Name = "WatchingForm";
			this.Text = "Дежурство по палатам";
			this.Load += new System.EventHandler(this.WardsForm_Load);
			((System.ComponentModel.ISupportInitialize)(gvPatients)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(gvWards)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnRename;
		private System.Windows.Forms.ListBox lbSchemes;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissionDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colWardNumber2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colChecked2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colChecked;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfBeds;
		private System.Windows.Forms.DataGridViewTextBoxColumn colWardTypeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colWardNumber;
	}
}