namespace HospitalDepartment.Forms
{
	partial class WardForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.tbNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nudNumberOfBeds = new System.Windows.Forms.NumericUpDown();
			this.cbWardType = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.nudNumberOfBeds)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(12, 117);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "Сохранить";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(93, 117);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Тип палаты:";
			// 
			// tbNumber
			// 
			this.tbNumber.Location = new System.Drawing.Point(147, 12);
			this.tbNumber.Name = "tbNumber";
			this.tbNumber.Size = new System.Drawing.Size(120, 20);
			this.tbNumber.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Номер:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Число кроватей:";
			// 
			// nudNumberOfBeds
			// 
			this.nudNumberOfBeds.Location = new System.Drawing.Point(147, 65);
			this.nudNumberOfBeds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudNumberOfBeds.Name = "nudNumberOfBeds";
			this.nudNumberOfBeds.Size = new System.Drawing.Size(120, 20);
			this.nudNumberOfBeds.TabIndex = 10;
			this.nudNumberOfBeds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cbWardType
			// 
			this.cbWardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbWardType.FormattingEnabled = true;
			this.cbWardType.Location = new System.Drawing.Point(147, 38);
			this.cbWardType.Name = "cbWardType";
			this.cbWardType.Size = new System.Drawing.Size(121, 21);
			this.cbWardType.TabIndex = 11;
			// 
			// WardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 152);
			this.Controls.Add(this.cbWardType);
			this.Controls.Add(this.nudNumberOfBeds);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbNumber);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Name = "WardForm";
			this.Text = "Палата";
			this.Load += new System.EventHandler(this.WardForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudNumberOfBeds)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudNumberOfBeds;
		private System.Windows.Forms.ComboBox cbWardType;
	}
}