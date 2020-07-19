namespace HospitalDepartment.Forms
{
	partial class ProductForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPackedNumber = new System.Windows.Forms.NumericUpDown();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaker = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBaseUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudUnitCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMedLists = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPackedNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 239);
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
            this.btnCancel.Location = new System.Drawing.Point(93, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(176, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(204, 20);
            this.tbName.TabIndex = 6;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(176, 12);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(120, 20);
            this.tbCode.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Код:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество в упаковке:";
            // 
            // nudPackedNumber
            // 
            this.nudPackedNumber.Location = new System.Drawing.Point(176, 117);
            this.nudPackedNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPackedNumber.Name = "nudPackedNumber";
            this.nudPackedNumber.Size = new System.Drawing.Size(120, 20);
            this.nudPackedNumber.TabIndex = 10;
            this.nudPackedNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMedicament
            // 
            this.cbMedicament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMedicament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(176, 64);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(204, 21);
            this.cbMedicament.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Международное название:";
            // 
            // tbMaker
            // 
            this.tbMaker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaker.Location = new System.Drawing.Point(177, 91);
            this.tbMaker.Name = "tbMaker";
            this.tbMaker.Size = new System.Drawing.Size(203, 20);
            this.tbMaker.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Производитель:";
            // 
            // cbBaseUnit
            // 
            this.cbBaseUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaseUnit.FormattingEnabled = true;
            this.cbBaseUnit.Location = new System.Drawing.Point(176, 169);
            this.cbBaseUnit.Name = "cbBaseUnit";
            this.cbBaseUnit.Size = new System.Drawing.Size(120, 21);
            this.cbBaseUnit.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Базовая еденица измерения:";
            // 
            // nudUnitCount
            // 
            this.nudUnitCount.DecimalPlaces = 3;
            this.nudUnitCount.Location = new System.Drawing.Point(176, 143);
            this.nudUnitCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudUnitCount.Name = "nudUnitCount";
            this.nudUnitCount.Size = new System.Drawing.Size(120, 20);
            this.nudUnitCount.TabIndex = 19;
            this.nudUnitCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Доза в базовых еденицах:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Принадлежность к ЖНВЛС:";
            // 
            // cbMedLists
            // 
            this.cbMedLists.FormattingEnabled = true;
            this.cbMedLists.Items.AddRange(new object[] {
            "ЖНВЛС",
            "ОМС",
            "ЖНВЛС/ОМС"});
            this.cbMedLists.Location = new System.Drawing.Point(176, 196);
            this.cbMedLists.Name = "cbMedLists";
            this.cbMedLists.Size = new System.Drawing.Size(204, 21);
            this.cbMedLists.TabIndex = 21;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 274);
            this.Controls.Add(this.cbMedLists);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudUnitCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBaseUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMaker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMedicament);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudPackedNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "ProductForm";
            this.Text = "Номенклатура";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPackedNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudPackedNumber;
		private System.Windows.Forms.ComboBox cbMedicament;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbMaker;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbBaseUnit;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nudUnitCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMedLists;
	}
}