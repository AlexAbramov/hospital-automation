using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class LogForm : Form
	{
		DataTable dataTable = new DataTable();

		DataRow SelectedRecord { get { return GridViewUtils.GetSelectedRow(gridView); } }

		public LogForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
			using (GmConnection conn = App.CreateConnection())
			{
                cbUser.Fill( conn, "select Id, Name from Users", 0, "Все пользователи");
                cbLogType.Fill( conn, "select Id, Name from LogTypes",0,"Все типы сообщений");
			}
			LoadData();
		}

		private void LogForm_Load(object sender, EventArgs e)
		{
		}

		void LoadData()
		{
			using (WaitCursor wc = new WaitCursor())
			{
				colUserName.Visible = (int)cbUser.SelectedValue == 0;
				colLogType.Visible = (int)cbLogType.SelectedValue == 0;

				StringBuilder query = new StringBuilder();
				StringBuilder join = new StringBuilder();
				StringBuilder cond = new StringBuilder();

				query.Append("select Log.Id, Log.Time,");
				if (colUserName.Visible)
				{
					query.Append(" Users.Name as UserName,");
					join.Append(" left join Users on Users.Id=UserId");
				}
				if (colUserName.Visible)
				{
					query.Append(" LogTypes.Name as LogTypeName,");
					join.Append(" left join LogTypes on LogTypes.Id=LogType");
				}
				query.Append(" Header, Message from Log");

				using (GmConnection conn = App.CreateConnection())
				{
					GmCommand cmd = conn.CreateCommand();
					if (ucTimeRange.FromTimeChecked)
					{
						if (cond.Length > 0) cond.Append(" and");
						cond.Append(" Time>@FromTime");
						cmd.AddDateTime("FromTime", ucTimeRange.FromTime);
					}
					if (ucTimeRange.ToTimeChecked)
					{
						if (cond.Length > 0) cond.Append(" and");
						cond.Append(" Time<@ToTime");
						cmd.AddDateTime("ToTime", ucTimeRange.ToTime);
					}
					if ((int)cbUser.SelectedValue != 0)
					{
						if (cond.Length > 0) cond.Append(" and");
						cond.Append(" UserId=@UserId");
						cmd.AddInt("UserId", (int)cbUser.SelectedValue);
					}
					if ((int)cbLogType.SelectedValue != 0)
					{
						if (cond.Length > 0) cond.Append(" and");
						cond.Append(" LogType=@LogType");
						cmd.AddInt("LogType", (int)cbLogType.SelectedValue);
					}
					if (cond.Length > 0) cond.Insert(0, " where");
					cmd.CommandText = query.ToString() + join.ToString() + cond.ToString();
					dataTable.Rows.Clear();
					dataTable.Columns.Clear();
					dataTable.Clear();
					conn.Fill(dataTable, cmd);
				}

				gridView.DataSource = dataTable;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}