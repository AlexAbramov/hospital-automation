using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class StringHandbookUserControl : UserControl, IHandbookUserControl
	{
		Handbook handbook;
		public StringHandbookUserControl()
		{
			InitializeComponent();
		}

		private void StringHandbookUserControl_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			nudLineCount.Value = handbook.lineCount;
			chkAdditive.Checked = handbook.additive;
			tbDefaultValue.Text = handbook.defaultValue;
		}

		#region IHandbookUserControl Members
		public void Init(Handbook handbook) 
		{ 
			this.handbook = handbook; 
			ucStringList.Init("Значение", handbook.Items);
		}
		public void Save()
		{
			handbook.lineCount = (int)nudLineCount.Value;
			handbook.additive = chkAdditive.Checked;
			handbook.defaultValue = tbDefaultValue.Text.Trim();
			ucStringList.Save();
		}

		#endregion
	}
}
