namespace HospitalDepartment.UserControls
{
	partial class StringHandbookUserControl
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
			this.tbDefaultValue = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nudLineCount = new System.Windows.Forms.NumericUpDown();
			this.chkAdditive = new System.Windows.Forms.CheckBox();
			this.ucStringList = new HospitalDepartment.UserControls.StringListUserControl();
			((System.ComponentModel.ISupportInitialize)(this.nudLineCount)).BeginInit();
			this.SuspendLayout();
			// 
			// tbDefaultValue
			// 
			this.tbDefaultValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbDefaultValue.Location = new System.Drawing.Point(141, 29);
			this.tbDefaultValue.Name = "tbDefaultValue";
			this.tbDefaultValue.Size = new System.Drawing.Size(171, 20);
			this.tbDefaultValue.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "«начение по умолчанию:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Ёлементы списка:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "„исло строк:";
			// 
			// nudLineCount
			// 
			this.nudLineCount.Location = new System.Drawing.Point(141, 3);
			this.nudLineCount.Name = "nudLineCount";
			this.nudLineCount.Size = new System.Drawing.Size(50, 20);
			this.nudLineCount.TabIndex = 14;
			// 
			// chkAdditive
			// 
			this.chkAdditive.AutoSize = true;
			this.chkAdditive.Location = new System.Drawing.Point(141, 55);
			this.chkAdditive.Name = "chkAdditive";
			this.chkAdditive.Size = new System.Drawing.Size(156, 17);
			this.chkAdditive.TabIndex = 15;
			this.chkAdditive.Text = "добавл€ть через зап€тую";
			this.chkAdditive.UseVisualStyleBackColor = true;
			// 
			// ucStringList
			// 
			this.ucStringList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.ucStringList.Location = new System.Drawing.Point(3, 78);
			this.ucStringList.Name = "ucStringList";
			this.ucStringList.Size = new System.Drawing.Size(309, 191);
			this.ucStringList.TabIndex = 16;
			// 
			// StringHandbookUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ucStringList);
			this.Controls.Add(this.chkAdditive);
			this.Controls.Add(this.nudLineCount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbDefaultValue);
			this.Controls.Add(this.label2);
			this.Name = "StringHandbookUserControl";
			this.Size = new System.Drawing.Size(315, 272);
			this.Load += new System.EventHandler(this.StringHandbookUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudLineCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbDefaultValue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudLineCount;
		private System.Windows.Forms.CheckBox chkAdditive;
		private StringListUserControl ucStringList;
	}
}
