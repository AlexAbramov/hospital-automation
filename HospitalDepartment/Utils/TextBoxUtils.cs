using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Utils
{
	class TextBoxUtils
	{
		public static void FixNameInput(TextBox textBox)
		{
			int selStart = textBox.SelectionStart;
			textBox.Text = StringUtils.TrimAndCap(textBox.Text);
			textBox.SelectionStart = selStart;
		}
	}
}
