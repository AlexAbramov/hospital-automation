using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.UserControls
{
	public partial class GuiConfigUserControl : UserControl
	{
		Config config;
		GuiConfig guiConfig;
		public void Init(Config config) { this.config = config; guiConfig = config.guiConfig; }
		public GuiConfigUserControl()
		{
			InitializeComponent();
		}

		private void GuiConfigUserControl_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			UpdateControls();
		}

		private void UpdateControls()
		{
			tbFont.Text = guiConfig.FontString;
			tbGridFont.Text = guiConfig.GridFontString;
			nudHandbookControlWidth.Value = guiConfig.handbookControlWidth;
			chkDTPShowUpDown.Checked = !guiConfig.dateTimePickerShowUpDown;
		}

		private void btnFont_Click(object sender, EventArgs e)
		{
			EditFont(ref guiConfig.font);
		}

		private void btnGridFont_Click(object sender, EventArgs e)
		{
			EditFont(ref guiConfig.gridFont);
		}

		private void EditFont(ref Font font)
		{
			dlgFont.Font = font;
			if (dlgFont.ShowDialog() == DialogResult.OK)
			{
				font = (Font)dlgFont.Font.Clone();
			    UpdateControls();
			}
		}

		private void nudHandbookControlWidth_ValueChanged(object sender, EventArgs e)
		{
			guiConfig.handbookControlWidth = (int)nudHandbookControlWidth.Value;
		}

		private void chkDTPShowUpDown_CheckedChanged(object sender, EventArgs e)
		{
			guiConfig.dateTimePickerShowUpDown = !chkDTPShowUpDown.Checked;
		}
	}
}
