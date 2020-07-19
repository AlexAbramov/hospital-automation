using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;

namespace HospitalDepartment.Utils
{
	class ComboBoxUtils
	{
		static bool useCache = false;
		static Dictionary<string, DataTable> cache = new Dictionary<string, DataTable>();
		static DataTable GetTable(GmConnection conn, string cmdText)
		{
			DataTable dt=null;
			lock (cache)
			{
				if (useCache) dt = cache[cmdText] as DataTable;
				if (dt == null)
				{
				  dt = new DataTable();
					conn.Fill(dt, cmdText);
					if (useCache) cache[cmdText] = dt;
				}
			}
			return dt;
		}
		public static DataTable Fill(ComboBox cb, GmConnection conn, string cmdText) { return Fill(cb, conn, cmdText, null); }
		public static DataTable Fill(ComboBox cb, GmConnection conn, string cmdText, string zeroText)
		{
			DataTable dt = GetTable(conn,cmdText);
			if(zeroText!=null)
			{
				DataRow dr=dt.NewRow();
				dr[0]=0;
				dr[1] = zeroText;
				dt.Rows.InsertAt(dr, 0);
			}
			cb.DisplayMember = dt.Columns[1].ColumnName;
			cb.ValueMember = dt.Columns[0].ColumnName;
			cb.DataSource = dt;
			return dt;
		}
		public static DataTable Fill(DataGridViewComboBoxColumn cb, GmConnection conn, string cmdText, string zeroText)
		{
			DataTable dt = GetTable(conn, cmdText);
			if (zeroText != null)
			{
				DataRow dr = dt.NewRow();
				dr[0] = 0;
				dr[1] = zeroText;
				dt.Rows.InsertAt(dr, 0);
			}
			cb.DisplayMember = dt.Columns[1].ColumnName;
			cb.ValueMember = dt.Columns[0].ColumnName;
			cb.DataSource = dt;
			return dt;
		}
		public static DataTable Fill(ComboBox cb, GmConnection conn, string cmdText, int selectedValue) { return Fill(cb, conn, cmdText, selectedValue, null); }
		public static DataTable Fill(ComboBox cb, GmConnection conn, string cmdText, int selectedValue, string zeroText)
		{
			DataTable dt = Fill(cb, conn, cmdText, zeroText);
			cb.SelectedValue = selectedValue;
			return dt;
		}
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
		public static void Fill(DataGridViewComboBoxColumn cb, List<HandbookGroup> handbookGroups)
		{
			cb.ValueMember = "Id";
			cb.DisplayMember = "Name";
			cb.DataSource = handbookGroups;
		}

		public static DataRow GetSelectedRow(ComboBox cb)
		{
			DataRowView drv = cb.SelectedItem as DataRowView;
			if (drv != null) return drv.Row;
			return null;
		}

		internal static string GetSelectedText(ComboBox cb)
		{
			DataRow dr = GetSelectedRow(cb);
			return dr == null ? "" : dr[1].ToString();
		}

		internal static int GetSelectedValue(ComboBox cb)
		{
			DataRow dr = GetSelectedRow(cb);
			return dr == null ? 0 : (int)dr[0];
		}

		internal static int GetInt(object selValue)
		{
			return selValue == null ? 0 : (int)selValue;
		}
	}
}
