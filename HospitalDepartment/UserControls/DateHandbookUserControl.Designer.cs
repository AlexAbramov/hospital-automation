namespace HospitalDepartment.UserControls
{
	partial class DateHandbookUserControl
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
            this.chkNullable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkNullable
            // 
            this.chkNullable.AutoSize = true;
            this.chkNullable.Location = new System.Drawing.Point(3, 107);
            this.chkNullable.Name = "chkNullable";
            this.chkNullable.Size = new System.Drawing.Size(185, 17);
            this.chkNullable.TabIndex = 17;
            this.chkNullable.Text = "значение может отсутствовать";
            this.chkNullable.UseVisualStyleBackColor = true;
            this.chkNullable.CheckedChanged += new System.EventHandler(this.chkNullable_CheckedChanged);
            // 
            // DateHandbookUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.chkNullable);
            this.Name = "DateHandbookUserControl";
            this.Size = new System.Drawing.Size(191, 127);
            this.Load += new System.EventHandler(this.DateHandbookUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.CheckBox chkNullable;
	}
}
