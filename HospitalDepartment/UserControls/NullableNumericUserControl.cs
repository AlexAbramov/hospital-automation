using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class NullableNumericUserControl : UserControl
	{
		public override string Text 
		{ 
			get { return checkBox.Checked? numericUpDown.Value.ToString() : ""; } 
			set 
			{
				if (value.Trim().Length > 0)
				{
					try
					{
						numericUpDown.Value=decimal.Parse(value);
						checkBox.Checked = true;
						return;
					}
					catch
					{
					}
				}
				checkBox.Checked = false;
				CheckedChanged();
			} 
		}
		
		public NullableNumericUserControl()
		{
			InitializeComponent();
		}

		private void NullableNumericUserControl_Resize(object sender, EventArgs e)
		{
			Height = numericUpDown.Height;
		}

		private void checkBox_CheckedChanged(object sender, EventArgs e)
		{
			CheckedChanged();
		}

		private void CheckedChanged()
		{
			numericUpDown.Enabled = checkBox.Checked;
		}
	}
}
