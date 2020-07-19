namespace HospitalDepartment.Forms
{
	partial class RoleForm
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.cbWatchingGroup = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ucPermissions = new HospitalDepartment.UserControls.PermissionsUserControl();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(12, 361);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "���������";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(93, 361);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "������";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "����� �������:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "���������:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(129, 10);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(188, 20);
			this.tbName.TabIndex = 6;
			// 
			// cbWatchingGroup
			// 
			this.cbWatchingGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbWatchingGroup.FormattingEnabled = true;
			this.cbWatchingGroup.Location = new System.Drawing.Point(129, 36);
			this.cbWatchingGroup.Name = "cbWatchingGroup";
			this.cbWatchingGroup.Size = new System.Drawing.Size(188, 21);
			this.cbWatchingGroup.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "������ ����������:";
			// 
			// ucPermissions
			// 
			this.ucPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.ucPermissions.Location = new System.Drawing.Point(16, 81);
			this.ucPermissions.Name = "ucPermissions";
			this.ucPermissions.Size = new System.Drawing.Size(467, 274);
			this.ucPermissions.TabIndex = 1;
			// 
			// RoleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 396);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbWatchingGroup);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.ucPermissions);
			this.Name = "RoleForm";
			this.Text = "���������";
			this.Load += new System.EventHandler(this.RoleForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private HospitalDepartment.UserControls.PermissionsUserControl ucPermissions;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.ComboBox cbWatchingGroup;
		private System.Windows.Forms.Label label3;
	}
}