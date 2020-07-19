namespace HospitalDepartment.UserControls
{
	partial class GuiConfigUserControl
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
			this.dlgFont = new System.Windows.Forms.FontDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFont = new System.Windows.Forms.TextBox();
			this.tbGridFont = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnFont = new System.Windows.Forms.Button();
			this.btnGridFont = new System.Windows.Forms.Button();
			this.nudHandbookControlWidth = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.chkDTPShowUpDown = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nudHandbookControlWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Шрифт:";
			// 
			// tbFont
			// 
			this.tbFont.Location = new System.Drawing.Point(112, 3);
			this.tbFont.Name = "tbFont";
			this.tbFont.ReadOnly = true;
			this.tbFont.Size = new System.Drawing.Size(200, 20);
			this.tbFont.TabIndex = 1;
			// 
			// tbGridFont
			// 
			this.tbGridFont.Location = new System.Drawing.Point(112, 29);
			this.tbGridFont.Name = "tbGridFont";
			this.tbGridFont.ReadOnly = true;
			this.tbGridFont.Size = new System.Drawing.Size(200, 20);
			this.tbGridFont.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Шрифт для таблиц:";
			// 
			// btnFont
			// 
			this.btnFont.Location = new System.Drawing.Point(318, 1);
			this.btnFont.Name = "btnFont";
			this.btnFont.Size = new System.Drawing.Size(75, 23);
			this.btnFont.TabIndex = 4;
			this.btnFont.Text = "Изменить";
			this.btnFont.UseVisualStyleBackColor = true;
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			// 
			// btnGridFont
			// 
			this.btnGridFont.Location = new System.Drawing.Point(318, 27);
			this.btnGridFont.Name = "btnGridFont";
			this.btnGridFont.Size = new System.Drawing.Size(75, 23);
			this.btnGridFont.TabIndex = 5;
			this.btnGridFont.Text = "Изменить";
			this.btnGridFont.UseVisualStyleBackColor = true;
			this.btnGridFont.Click += new System.EventHandler(this.btnGridFont_Click);
			// 
			// nudHandbookControlWidth
			// 
			this.nudHandbookControlWidth.Location = new System.Drawing.Point(273, 56);
			this.nudHandbookControlWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudHandbookControlWidth.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudHandbookControlWidth.Name = "nudHandbookControlWidth";
			this.nudHandbookControlWidth.Size = new System.Drawing.Size(120, 20);
			this.nudHandbookControlWidth.TabIndex = 6;
			this.nudHandbookControlWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudHandbookControlWidth.ValueChanged += new System.EventHandler(this.nudHandbookControlWidth_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(231, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Ширина элемента управления справочника:";
			// 
			// chkDTPShowUpDown
			// 
			this.chkDTPShowUpDown.AutoSize = true;
			this.chkDTPShowUpDown.Location = new System.Drawing.Point(6, 82);
			this.chkDTPShowUpDown.Name = "chkDTPShowUpDown";
			this.chkDTPShowUpDown.Size = new System.Drawing.Size(361, 17);
			this.chkDTPShowUpDown.TabIndex = 8;
			this.chkDTPShowUpDown.Text = "Выпадающий стиль для управляющих элементов даты и времени";
			this.chkDTPShowUpDown.UseVisualStyleBackColor = true;
			this.chkDTPShowUpDown.CheckedChanged += new System.EventHandler(this.chkDTPShowUpDown_CheckedChanged);
			// 
			// GuiConfigUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chkDTPShowUpDown);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nudHandbookControlWidth);
			this.Controls.Add(this.btnGridFont);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbGridFont);
			this.Controls.Add(this.tbFont);
			this.Controls.Add(this.label1);
			this.Name = "GuiConfigUserControl";
			this.Size = new System.Drawing.Size(453, 451);
			this.Load += new System.EventHandler(this.GuiConfigUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudHandbookControlWidth)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FontDialog dlgFont;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbFont;
		private System.Windows.Forms.TextBox tbGridFont;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnFont;
		private System.Windows.Forms.Button btnGridFont;
		private System.Windows.Forms.NumericUpDown nudHandbookControlWidth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chkDTPShowUpDown;
	}
}
