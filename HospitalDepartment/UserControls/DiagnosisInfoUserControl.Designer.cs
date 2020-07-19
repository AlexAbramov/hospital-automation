namespace HospitalDepartment.UserControls
{
	partial class DiagnosisInfoUserControl
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
			this.lblCode = new System.Windows.Forms.Label();
			this.btnSelect = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Location = new System.Drawing.Point(0, 0);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(250, 72);
			this.textBox.TabIndex = 1;
			this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// lblCode
			// 
			this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblCode.Font = new System.Drawing.Font("Arial", 6F);
			this.lblCode.ForeColor = System.Drawing.Color.Blue;
			this.lblCode.Location = new System.Drawing.Point(-1, 1);
			this.lblCode.Margin = new System.Windows.Forms.Padding(0);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(19, 52);
			this.lblCode.TabIndex = 2;
			this.lblCode.Tag = "ignoreInit";
			this.lblCode.Text = "123456";
			this.lblCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelect.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelect.Location = new System.Drawing.Point(-1, 53);
			this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(19, 19);
			this.btnSelect.TabIndex = 0;
			this.btnSelect.Tag = "ignoreInit";
			this.btnSelect.Text = "...";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.btnSelect);
			this.panel.Controls.Add(this.lblCode);
			this.panel.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel.Location = new System.Drawing.Point(250, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(18, 72);
			this.panel.TabIndex = 4;
			// 
			// DiagnosisInfoUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.panel);
			this.Name = "DiagnosisInfoUserControl";
			this.Size = new System.Drawing.Size(268, 72);
			this.Load += new System.EventHandler(this.DiagnosisInfoUserControl_Load);
			this.Resize += new System.EventHandler(this.DiagnosisInfoUserControl_Resize);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Panel panel;
	}
}
