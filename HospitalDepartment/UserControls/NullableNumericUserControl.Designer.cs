namespace HospitalDepartment.UserControls
{
	partial class NullableNumericUserControl
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
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.checkBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown
			// 
			this.numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown.Location = new System.Drawing.Point(13, 0);
			this.numericUpDown.Margin = new System.Windows.Forms.Padding(0);
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(137, 20);
			this.numericUpDown.TabIndex = 0;
			// 
			// checkBox
			// 
			this.checkBox.AutoSize = true;
			this.checkBox.Location = new System.Drawing.Point(0, 2);
			this.checkBox.Margin = new System.Windows.Forms.Padding(0);
			this.checkBox.Name = "checkBox";
			this.checkBox.Size = new System.Drawing.Size(15, 14);
			this.checkBox.TabIndex = 1;
			this.checkBox.UseVisualStyleBackColor = true;
			this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// NullableNumericUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.checkBox);
			this.Name = "NullableNumericUserControl";
			this.Size = new System.Drawing.Size(150, 20);
			this.Resize += new System.EventHandler(this.NullableNumericUserControl_Resize);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.NumericUpDown numericUpDown;
		public System.Windows.Forms.CheckBox checkBox;

	}
}
