namespace HospitalDepartment.UserControls
{
	partial class UserUserControl
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbConfirmPassword = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.cbRole = new System.Windows.Forms.ComboBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ФИО:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Должность:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Логин:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Пароль:";
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(139, 55);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(121, 20);
			this.tbLogin.TabIndex = 7;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(139, 81);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(121, 20);
			this.tbPassword.TabIndex = 8;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Подтверждение пароля:";
			// 
			// tbConfirmPassword
			// 
			this.tbConfirmPassword.Location = new System.Drawing.Point(139, 107);
			this.tbConfirmPassword.Name = "tbConfirmPassword";
			this.tbConfirmPassword.Size = new System.Drawing.Size(121, 20);
			this.tbConfirmPassword.TabIndex = 9;
			this.tbConfirmPassword.UseSystemPasswordChar = true;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(139, 2);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(200, 20);
			this.tbName.TabIndex = 5;
			// 
			// cbRole
			// 
			this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRole.FormattingEnabled = true;
			this.cbRole.Location = new System.Drawing.Point(139, 28);
			this.cbRole.Name = "cbRole";
			this.cbRole.Size = new System.Drawing.Size(200, 21);
			this.cbRole.TabIndex = 6;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// UserUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbConfirmPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.cbRole);
			this.Name = "UserUserControl";
			this.Size = new System.Drawing.Size(345, 136);
			this.Load += new System.EventHandler(this.UserUserControl_Load);
			this.Validating += new System.ComponentModel.CancelEventHandler(this.UserUserControl_Validating);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbRole;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbConfirmPassword;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
