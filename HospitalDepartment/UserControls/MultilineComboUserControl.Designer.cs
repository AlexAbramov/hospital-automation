namespace HospitalDepartment.UserControls
{
	partial class MultilineComboUserControl
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
			this.textBox = new System.Windows.Forms.TextBox();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox.Location = new System.Drawing.Point(0, 0);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(413, 80);
			this.textBox.TabIndex = 8;
			// 
			// comboBox
			// 
			this.comboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox.FormattingEnabled = true;
			this.comboBox.IntegralHeight = false;
			this.comboBox.Location = new System.Drawing.Point(0, 59);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(431, 21);
			this.comboBox.TabIndex = 9;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Font = new System.Drawing.Font("Arial", 6F);
			this.btnEdit.Location = new System.Drawing.Point(0, 40);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(19, 19);
			this.btnEdit.TabIndex = 10;
			this.btnEdit.Tag = "ignoreInit";
			this.btnEdit.Text = "...";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.btnEdit);
			this.panel.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel.Location = new System.Drawing.Point(412, 0);
			this.panel.Margin = new System.Windows.Forms.Padding(0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(19, 59);
			this.panel.TabIndex = 11;
			// 
			// MultilineComboUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.comboBox);
			this.Name = "MultilineComboUserControl";
			this.Size = new System.Drawing.Size(431, 80);
			this.Load += new System.EventHandler(this.MultilineComboUserControl_Load);
			this.Resize += new System.EventHandler(this.MultilineComboUserControl_Resize);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Panel panel;
	}
}
