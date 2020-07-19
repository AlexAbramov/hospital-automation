namespace HospitalDepartment.UserControls
{
	partial class HandbooksInfoUserControl
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
			this.tlp = new System.Windows.Forms.TableLayoutPanel();
			this.chkShowRare = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// tlp
			// 
			this.tlp.AutoSize = true;
			this.tlp.ColumnCount = 2;
			this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlp.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tlp.Location = new System.Drawing.Point(3, 3);
			this.tlp.Name = "tlp";
			this.tlp.RowCount = 2;
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp.Size = new System.Drawing.Size(317, 107);
			this.tlp.TabIndex = 2;
			// 
			// chkShowRare
			// 
			this.chkShowRare.AutoSize = true;
			this.chkShowRare.Location = new System.Drawing.Point(3, 3);
			this.chkShowRare.Name = "chkShowRare";
			this.chkShowRare.Size = new System.Drawing.Size(246, 17);
			this.chkShowRare.TabIndex = 3;
			this.chkShowRare.Text = "ѕоказать редко используемые параметры";
			this.chkShowRare.UseVisualStyleBackColor = true;
			this.chkShowRare.Visible = false;
			this.chkShowRare.CheckedChanged += new System.EventHandler(this.chkShowRare_CheckedChanged);
			// 
			// HandbooksInfoUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.chkShowRare);
			this.Controls.Add(this.tlp);
			this.Name = "HandbooksInfoUserControl";
			this.Size = new System.Drawing.Size(323, 113);
			this.Load += new System.EventHandler(this.HandbooksInfoUserControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlp;
		private System.Windows.Forms.CheckBox chkShowRare;
	}
}
