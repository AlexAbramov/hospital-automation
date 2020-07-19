namespace HospitalDepartment.UserControls
{
	partial class InsuranceUserControl
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbInsuranceCompany = new System.Windows.Forms.ComboBox();
			this.tbNumber = new System.Windows.Forms.TextBox();
			this.tbSeries = new System.Windows.Forms.TextBox();
			this.tbDelo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Страховая компания:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "№ полиса:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Серия:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Дело:";
			// 
			// cbInsuranceCompany
			// 
			this.cbInsuranceCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbInsuranceCompany.FormattingEnabled = true;
			this.cbInsuranceCompany.Location = new System.Drawing.Point(153, 3);
			this.cbInsuranceCompany.Name = "cbInsuranceCompany";
			this.cbInsuranceCompany.Size = new System.Drawing.Size(150, 21);
			this.cbInsuranceCompany.TabIndex = 4;
			// 
			// tbNumber
			// 
			this.tbNumber.Location = new System.Drawing.Point(153, 30);
			this.tbNumber.Name = "tbNumber";
			this.tbNumber.Size = new System.Drawing.Size(100, 20);
			this.tbNumber.TabIndex = 5;
			// 
			// tbSeries
			// 
			this.tbSeries.Location = new System.Drawing.Point(153, 56);
			this.tbSeries.Name = "tbSeries";
			this.tbSeries.Size = new System.Drawing.Size(100, 20);
			this.tbSeries.TabIndex = 6;
			// 
			// tbDelo
			// 
			this.tbDelo.Location = new System.Drawing.Point(153, 82);
			this.tbDelo.Name = "tbDelo";
			this.tbDelo.Size = new System.Drawing.Size(100, 20);
			this.tbDelo.TabIndex = 7;
			// 
			// InsuranceUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbInsuranceCompany);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbDelo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbSeries);
			this.Controls.Add(this.tbNumber);
			this.Name = "InsuranceUserControl";
			this.Size = new System.Drawing.Size(376, 148);
			this.Load += new System.EventHandler(this.InsuranceUserControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbInsuranceCompany;
		private System.Windows.Forms.TextBox tbNumber;
		private System.Windows.Forms.TextBox tbSeries;
		private System.Windows.Forms.TextBox tbDelo;
	}
}
