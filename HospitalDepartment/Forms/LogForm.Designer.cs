namespace HospitalDepartment.Forms
{
	partial class LogForm
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
			this.gridView = new System.Windows.Forms.DataGridView();
			this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLogType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbUser = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbLogType = new System.Windows.Forms.ComboBox();
			this.ucTimeRange = new HospitalDepartment.UserControls.TimeRangeUserControl();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(468, 372);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Закрыть";
			this.btnOk.UseVisualStyleBackColor = true;
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
            this.colTime,
            this.colUserName,
            this.colLogType,
            this.colHeader,
            this.colMessage});
			this.gridView.Location = new System.Drawing.Point(12, 72);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.ReadOnly = true;
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(450, 323);
			this.gridView.TabIndex = 3;
			// 
			// colTime
			// 
			this.colTime.DataPropertyName = "Time";
			this.colTime.HeaderText = "Время";
			this.colTime.Name = "colTime";
			this.colTime.ReadOnly = true;
			// 
			// colUserName
			// 
			this.colUserName.DataPropertyName = "UserName";
			this.colUserName.HeaderText = "Пользователь";
			this.colUserName.Name = "colUserName";
			this.colUserName.ReadOnly = true;
			// 
			// colLogType
			// 
			this.colLogType.DataPropertyName = "LogTypeName";
			this.colLogType.HeaderText = "Тип сообщения";
			this.colLogType.Name = "colLogType";
			this.colLogType.ReadOnly = true;
			// 
			// colHeader
			// 
			this.colHeader.DataPropertyName = "Header";
			this.colHeader.HeaderText = "Заголовок";
			this.colHeader.Name = "colHeader";
			this.colHeader.ReadOnly = true;
			// 
			// colMessage
			// 
			this.colMessage.DataPropertyName = "Message";
			this.colMessage.FillWeight = 200F;
			this.colMessage.HeaderText = "Сообщение";
			this.colMessage.Name = "colMessage";
			this.colMessage.ReadOnly = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Location = new System.Drawing.Point(468, 72);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Обновить";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(297, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Пользователь:";
			// 
			// cbUser
			// 
			this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUser.FormattingEnabled = true;
			this.cbUser.Location = new System.Drawing.Point(392, 15);
			this.cbUser.Name = "cbUser";
			this.cbUser.Size = new System.Drawing.Size(150, 21);
			this.cbUser.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(297, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Тип сообщения:";
			// 
			// cbLogType
			// 
			this.cbLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLogType.FormattingEnabled = true;
			this.cbLogType.Location = new System.Drawing.Point(392, 42);
			this.cbLogType.Name = "cbLogType";
			this.cbLogType.Size = new System.Drawing.Size(150, 21);
			this.cbLogType.TabIndex = 9;
			// 
			// ucTimeRange
			// 
			this.ucTimeRange.Location = new System.Drawing.Point(12, 12);
			this.ucTimeRange.Name = "ucTimeRange";
			this.ucTimeRange.Size = new System.Drawing.Size(252, 54);
			this.ucTimeRange.TabIndex = 4;
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 407);
			this.Controls.Add(this.cbLogType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.ucTimeRange);
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.btnOk);
			this.Name = "LogForm";
			this.Text = "Журнал систмных сообщений";
			this.Load += new System.EventHandler(this.LogForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.DataGridView gridView;
		private HospitalDepartment.UserControls.TimeRangeUserControl ucTimeRange;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbUser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbLogType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLogType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
	}
}