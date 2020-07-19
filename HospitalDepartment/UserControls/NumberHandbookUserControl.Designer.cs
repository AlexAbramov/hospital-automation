namespace HospitalDepartment.UserControls
{
	partial class NumberHandbookUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudDefault = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.chkNullable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "По умолчанию:";
            // 
            // nudDefault
            // 
            this.nudDefault.Location = new System.Drawing.Point(152, 55);
            this.nudDefault.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDefault.Name = "nudDefault";
            this.nudDefault.Size = new System.Drawing.Size(100, 20);
            this.nudDefault.TabIndex = 10;
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(152, 81);
            this.nudMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(100, 20);
            this.nudMin.TabIndex = 11;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(152, 29);
            this.nudMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(100, 20);
            this.nudMax.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Минимальное:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Максимальное значение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Число разрядов:";
            // 
            // nudDecimalPlaces
            // 
            this.nudDecimalPlaces.Location = new System.Drawing.Point(152, 3);
            this.nudDecimalPlaces.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudDecimalPlaces.Name = "nudDecimalPlaces";
            this.nudDecimalPlaces.Size = new System.Drawing.Size(100, 20);
            this.nudDecimalPlaces.TabIndex = 15;
            this.nudDecimalPlaces.ValueChanged += new System.EventHandler(this.nudDecimalPlaces_ValueChanged);
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
            // NumberHandbookUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.chkNullable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudDecimalPlaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.nudDefault);
            this.Controls.Add(this.label2);
            this.Name = "NumberHandbookUserControl";
            this.Size = new System.Drawing.Size(255, 127);
            this.Load += new System.EventHandler(this.NumberHandbookUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudDefault;
		private System.Windows.Forms.NumericUpDown nudMin;
		private System.Windows.Forms.NumericUpDown nudMax;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudDecimalPlaces;
		private System.Windows.Forms.CheckBox chkNullable;
	}
}
