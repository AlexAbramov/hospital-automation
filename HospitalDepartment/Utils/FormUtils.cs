using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Forms;
using Geomethod;

namespace HospitalDepartment.Utils
{
	public class FormUtils
	{
		public static bool Ask(string text)
		{
			return MessageBox.Show(text, App.AssemblyInfo.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}
		public static void MessageExcl(string text) { Message(text, MessageBoxIcon.Exclamation); }
		public static void Message(string text) { Message(text, MessageBoxIcon.None); }
		public static void Message(string text, MessageBoxIcon messageBoxIcon)
		{
			MessageBox.Show(text, App.AssemblyInfo.AssemblyTitle, MessageBoxButtons.OK, messageBoxIcon);
		}

		internal static void Init(Form form)
		{
			if (!App.IsConfigLoaded) return;
			Iterate(form);
		}
		internal static void Init(UserControl uc)
		{
			if (!App.IsConfigLoaded) return;
			Iterate(uc);
		}
		static void Iterate(Control ctl)//recursive
		{
			foreach (Control childControl in ctl.Controls)
			{
				Iterate(childControl);
			}
			InitControl(ctl);
		}

		private static void InitControl(Control ctl)
		{
			if (ctl.Tag != null && ctl.Tag is string && ctl.Tag.ToString().Trim().ToLower() == "ignoreinit") return;
			GuiConfig guiConfig=App.Config.guiConfig;
			Font origFont = ctl.Font;
            if (ctl.Font.Size < 10)
            {
                ctl.Font = guiConfig.font;
            }
			if(ctl is Form)
			{
				Form form=(Form)ctl;
				if (form.FormBorderStyle == FormBorderStyle.Sizable)
				{
					if(guiConfig.formSize.Width>100 && guiConfig.formSize.Height>100)
					  form.Size = guiConfig.formSize;
					form.MinimumSize = form.Size;
				}
				form.StartPosition = FormStartPosition.CenterParent;
			}
			else if (ctl is UserControl)
			{
				UserControl uc = (UserControl)ctl;
				uc.AutoScroll = true;
			}
			else if (ctl is DataGridView)
			{
				DataGridView gridView=(DataGridView)ctl;
				gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				gridView.AllowUserToResizeRows = false;
				gridView.DefaultCellStyle.Font = guiConfig.gridFont;
				gridView.AutoGenerateColumns = false;
			}
			else if (ctl is TextBox)
			{
				TextBox tb = (TextBox)ctl;
				tb.Font = App.Config.guiConfig.gridFont;
			}
			else if (ctl is NumericUpDown)
			{
				NumericUpDown nud = (NumericUpDown)ctl;
				nud.Font = guiConfig.gridFont;
			}
			else if (ctl is ComboBox)
			{
				ComboBox cb = (ComboBox)ctl;
				cb.Font = guiConfig.gridFont;
			}
			else if (ctl is DateTimePicker)
			{
				DateTimePicker dtp = (DateTimePicker)ctl;
				dtp.Font = guiConfig.gridFont;
				dtp.ShowUpDown=guiConfig.dateTimePickerShowUpDown;
			}
			if (origFont.Bold)
			{
				ctl.Font = new Font(ctl.Font, FontStyle.Bold);
			}
		}
	}

/*	interface IControlVisitor
	{ 

	}

	public class ControlIterator
	{ 

	}*/
}
