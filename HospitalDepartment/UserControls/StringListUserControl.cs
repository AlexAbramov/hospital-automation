using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using HospitalDepartment.Utils;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class StringListUserControl : UserControl
	{
		List<string> items=new List<string>();
		DataTable dt = new DataTable();
        DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
        public string SelectedString { get { DataRow dr = SelectedRow; return dr != null ? (string)dr[0] : ""; } }
        public StringListUserControl()
		{
			InitializeComponent();
			dt.Columns.Add("Text", typeof(string));
		}
		public void Init(string headerText, List<string> items)
		{
			ColumnHeadersVisible = headerText != null;
			if (headerText!=null) HeaderText = headerText;
			this.items = items;
		}

		public bool ColumnHeadersVisible { get { return gridView.ColumnHeadersVisible; } set { gridView.ColumnHeadersVisible = value; } }
		public string HeaderText { get { return colValue.HeaderText; } set { colValue.HeaderText = value; } }
		public List<string> StringList { get { return items; } set { items = value; } }
		public bool Sorted { get { return dt.DefaultView.Sort.Length > 0; } set { dt.DefaultView.Sort = value ? "Text" : ""; } }

		private void StringListUserControl_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			foreach (string s in items)
			{
				object[] values ={ s };
				dt.Rows.Add(values);
			}
			gridView.DataSource = dt;
		}

		public void Save()
		{
			items.Clear();
			foreach (DataRow dr in dt.Rows)
			{
				items.Add((string)dr[0]);
			}
		}
	}
}
