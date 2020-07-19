using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using Geomethod.Windows.Forms;
using HospitalDepartment.Forms;

namespace HospitalDepartment
{
	public partial class ComboBoxUtils
	{
		public static void Fill(ComboBox cb, Handbook handbook, string text)
		{
			cb.DataSource = handbook.Items;
			cb.Text = text;
		}
		public static void Fill(DataGridViewComboBoxColumn cb, List<Handbook> handbooks)
		{
			cb.ValueMember = "Id";
			cb.DisplayMember = "Name";
			cb.DataSource = handbooks;
		}

        public static string GetSelectedText(ComboBox cb)
        {
            return cb.GetSelectedText();
        }

        public static void Fill(DataGridViewComboBoxColumn cb, List<HandbookGroup> handbookGroups)
		{
			cb.ValueMember = "Id";
			cb.DisplayMember = "Name";
			cb.DataSource = handbookGroups;
		}

        public static int GetSelectedValue(ComboBox cb)
        {
            return cb.GetSelectedValue();
        }
    }
}
