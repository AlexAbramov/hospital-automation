using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod;

namespace HospitalDepartment.UserControls
{
	public partial class DateHandbookUserControl : UserControl, IHandbookUserControl
	{
		Handbook handbook;
		DataTable dt = new DataTable();
		public DateHandbookUserControl()
		{
			InitializeComponent();
		}

		private void DateHandbookUserControl_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			chkNullable.Checked = handbook.nullable;
		}

/*		private decimal GetValue(string s)
		{
			try
			{
				if (s == null || s.Trim().Length == 0) return 0;
				return decimal.Parse(s);
			}
			catch(Exception ex)
			{
				Log.Exception(ex);
			}
			return 0;
		}

		private string ToString(decimal d)
		{
			return d.ToString();
		}*/

		#region IHandbookUserControl Members
		public void Init(Handbook handbook) { this.handbook = handbook; }
		public void Save()
		{
/*			handbook.decimalPlaces = (int)nudDecimalPlaces.Value;
			handbook.defaultValue = ToString(nudDefault.Value);
			handbook.minValue = ToString(nudMin.Value);
			handbook.maxValue = ToString(nudMax.Value);*/
		}

		#endregion

		private void nudDecimalPlaces_ValueChanged(object sender, EventArgs e)
		{
		}

		private void chkNullable_CheckedChanged(object sender, EventArgs e)
		{
			handbook.nullable = chkNullable.Checked;
		}
	}
}
