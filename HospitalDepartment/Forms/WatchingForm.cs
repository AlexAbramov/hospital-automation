using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment;
using HospitalDepartment.Utils;
using HospitalDepartment.Data;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.Forms
{
	public partial class WatchingForm : Form
	{

		App app;
		Watching watching;
		DataTable dtWards = new DataTable("Wards");
		DataTable dtPatients = new DataTable("Patients");
		bool loaded = false;

		DataRow SelectedWardRow { get { return GridViewUtils.GetSelectedRow(gvWards); } }
		DataRow SelectedPatientRow { get { return GridViewUtils.GetSelectedRow(gvPatients); } }
		int SelectedWardId { get { DataRow dr = SelectedWardRow; return dr != null ? (int)dr[0] : 0; } }
		int SelectedPatientId { get { DataRow dr = SelectedPatientRow; return dr != null ? (int)dr[0] : 0; } }

		public WatchingForm(App app)
		{
			InitializeComponent();
			FormUtils.Init(this);
			this.app = app;
			this.watching = app.UserInfo.Watching;
			gvWards = splitContainer1.Panel1.Controls["gvWards"] as DataGridView;
			gvPatients = splitContainer1.Panel2.Controls["gvPatients"] as DataGridView;
		}

		private void WardsForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
            UserInfo ui=App.Instance.UserInfo;
            base.Text += string.Format(" - {0} {1}",ui.Role.name,ui.UserName);
			using (GmConnection conn = App.CreateConnection())
			{
				Fill(conn);
				FillSchemas(conn);
			}
			UpdateDataTables();
			gvWards.DataSource = dtWards;
			gvPatients.DataSource = dtPatients;
			OnRowEnter();
			dtWards.RowChanging += new DataRowChangeEventHandler(WardsDataTable_RowChanging);
			dtWards.ColumnChanging += new DataColumnChangeEventHandler(WardsDataTable_ColumnChanging);
			UpdateControls();
			loaded = true;
		}

		private void UpdateControls()
		{
			WatchingScheme ws = lbSchemes.SelectedItem as WatchingScheme;
			btnRemove.Enabled = ws != null;
			btnRename.Enabled = ws != null;
			btnUpdate.Enabled = ws != null;
		}

		private void FillSchemas(GmConnection conn)
		{
			using(DbDataReader dr= conn.ExecuteReader("select * from WatchingSchemes where UserId="+watching.userId))
			{
				while (dr.Read())
				{
					lbSchemes.Items.Add(new WatchingScheme(dr));
				}
			}			
		}

		private void UpdateDataTables()
		{
			foreach (DataRow dr in dtWards.Rows)
			{
				int id = (int)dr["Id"];
				if (watching.HasWard(id)) dr["Checked"] = true;
			}
			foreach (DataRow dr in dtPatients.Rows)
			{
				int id = (int)dr["Id"];
				if (watching.HasWard(id)) dr["Checked"] = true;
			}
		}

		private void UpdateDataTables(WatchingScheme ws)
		{
			foreach (DataRow dr in dtWards.Rows)
			{
				int id = (int)dr["Id"];
				dr["Checked"] = ws.HasWard(id);
			}
			foreach (DataRow dr in dtPatients.Rows)
			{
//				int id = (int)dr["Id"];
				int wardId = (int)dr["WardId"];
				dr["Checked"] = ws.HasWard(wardId);
			}
		}
		
		public void Fill(GmConnection conn)
		{
			string cmdText = @"
select Wards.Id, Number, Name as WardTypeName, NumberOfBeds 
from Wards 
left join WardTypes on WardTypes.Id=WardTypeId
order by Number
";
			DbDataAdapter dataAdapter = conn.CreateDataAdapter(cmdText);
			dataAdapter.Fill(dtWards);

			cmdText = @"
select Patients.Id, Passports.Surname, Passports.Name, Passports.MiddleName, AdmissionDate, DischargeDate, Wards.Number as WardNumber, WardId
from Patients 
left join Passports on PassportId=Passports.Id
left join Wards on WardId=Wards.Id
where Patients.Status=1
";
			dataAdapter = conn.CreateDataAdapter(cmdText);
			dataAdapter.Fill(dtPatients);
			/*			watchingDataSet.Relations.Clear();
						DataRelation relation = new DataRelation("WardsPatients",
								watchingDataSet.Wards.IdColumn,
								watchingDataSet.Patients.WardIdColumn);
						watchingDataSet.Relations.Add(relation);*/

			DataColumn dcWardChecked = new DataColumn("Checked", typeof(bool));
			dcWardChecked.DefaultValue = false;
			dcWardChecked.AllowDBNull = true;
			dtWards.Columns.Add(dcWardChecked);

			DataColumn dcPatientChecked = new DataColumn("Checked", typeof(bool));
			dcPatientChecked.DefaultValue = false;
			dcPatientChecked.AllowDBNull = true;
			dtPatients.Columns.Add(dcPatientChecked);

			DataColumn dcUserName = new DataColumn("UserName", typeof(string));
			dcUserName.DefaultValue = DBNull.Value;
			dcUserName.AllowDBNull = true;
			dtPatients.Columns.Add(dcUserName);

			DataColumn dcPatientId=dtPatients.Columns["Id"];
			foreach (DataRow dr in dtPatients.Rows)
			{
				int patientId=(int)dr[dcPatientId];
				User user = app.AppCache.GetWatchingUser(patientId);
				if (user != null)
				{
					dr[dcUserName] = user.NonEmptyName;
				}
			}
		}

		void Save(GmConnection conn)
		{
			/*			GmCommand cmd = conn.CreateCommand();
						cmd.AddInt("Id", id);
						cmd.AddString("Number", number);
						cmd.AddInt("WardTypeId", (int)wardTypeId);
						cmd.AddInt("NumberOfBeds", numberOfBeds);
						if (id == 0)
						{
							cmd.CommandText = "insert into Watching values (@Number,@WardTypeId,@NumberOfBeds) select @@Identity";
							id = (int)(decimal)cmd.ExecuteScalar();
						}*/
		}

		void WardsDataTable_RowChanging(object sender, DataRowChangeEventArgs e)
		{
		}

		void WardsDataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
		{
			if (e.Column.ColumnName=="Checked")
			{
				UpdateDetails((bool)e.ProposedValue);
			}
		}

		private void UpdateDetails(bool p)
		{
		}

		private void gvWards_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			OnRowEnter();
		}

		private void OnRowEnter()
		{
			int id = SelectedWardId;
			if (id != 0)
			{
				dtPatients.DefaultView.RowFilter = "WardId=" + id;
				//				WardsGridView.DataSource = watchingDataSet;

			}
		}

		private void OnCheckedWardChanged()
		{
			DataRow dr = SelectedWardRow;
			if(dr!=null)
			{
			  int id=(int)dr["Id"];
			  bool val=(bool)dr["Checked"];
				DataColumn dcWardId= dtPatients.Columns["WardId"];
				foreach (DataRow dr2 in dtPatients.Rows)
				{
					if ((int)dr2[dcWardId] == id)
					{
						dr2["Checked"] = val;
					}
				}
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			watching.Clear();
			foreach (DataRow dr in dtWards.Rows)
			{
				int id = (int)dr["Id"];
				if ((bool)dr["Checked"]) watching.AddWard(id);
			}
			foreach (DataRow dr in dtPatients.Rows)
			{
				int id = (int)dr["Id"];
				if ((bool)dr["Checked"]) watching.AddPatient(id);
			}			
			using (GmConnection conn = App.CreateConnection())
			{
				watching.Save(conn);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			TextForm tf = new TextForm(false);
			tf.Text = "Имя схемы";
			if (tf.ShowDialog() == DialogResult.OK)
			{
				WatchingScheme ws = new WatchingScheme(watching.userId);
				ws.name = tf.TextValue;
				UpdateWatchingScheme(ws);
				using (GmConnection conn = App.CreateConnection())
				{
					ws.Save(conn);
				}
				lbSchemes.Items.Add(ws);
				lbSchemes.SelectedItem = ws;
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			WatchingScheme ws = lbSchemes.SelectedItem as WatchingScheme;
			if (ws != null)
			{
				if (FormUtils.Ask("Удалить схему '" + ws.name + "'?"))
				{
					using (GmConnection conn = App.CreateConnection())
					{
						WatchingScheme.Remove(conn, ws.Id);
					}
					lbSchemes.Items.Remove(ws);
				}
			}
		}

		private void btnRename_Click(object sender, EventArgs e)
		{
			WatchingScheme ws = lbSchemes.SelectedItem as WatchingScheme;
			if (ws != null)
			{
				TextForm tf = new TextForm(false);
				tf.Text = "Имя схемы";
				tf.TextValue = ws.Name;
				if (tf.ShowDialog() == DialogResult.OK)
				{
					ws.name = tf.TextValue;
					using (GmConnection conn = App.CreateConnection())
					{
						ws.Save(conn);
					}
					lbSchemes.Items[lbSchemes.SelectedIndex] = ws;
				}
			}
		}

		bool UpdateWatchingScheme(WatchingScheme ws)
		{
			bool changed = false;
			foreach (DataRow dr in dtWards.Rows)
			{
				int id = (int)dr["Id"];
				bool wardChecked = (bool)dr["Checked"];
				if (ws.UpdateWard(id, wardChecked)) changed = true;
			}
			return changed;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			WatchingScheme ws = lbSchemes.SelectedItem as WatchingScheme;
			if (ws != null)
			{
				if (UpdateWatchingScheme(ws))
				{
					using (GmConnection conn = App.CreateConnection())
					{
						ws.Save(conn);
					}
				}
			}
		}

		private void lbSchemes_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateControls();
			WatchingScheme ws = lbSchemes.SelectedItem as WatchingScheme;
			if (ws != null)
			{
				UpdateDataTables(ws);
		  }
		}

		private void gvWards_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			if (gvWards.IsCurrentCellDirty)
			{
				gvWards.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void gvWards_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (!loaded) return;
			if (e.ColumnIndex == colChecked.Index)
				OnCheckedWardChanged();
		}

		private void gvPatients_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (!loaded) return;
			if (e.ColumnIndex == colChecked2.Index)
			{
				DataGridViewRow vr = gvPatients.Rows[e.RowIndex];
				vr.ErrorText = "";
				DataRowView drv = vr.DataBoundItem as DataRowView;
				//				drv.Row.
				if (drv != null)
				{
					bool v = (bool)gvPatients.CurrentCell.Value;
					string userName = drv.Row["UserName"] as string;

					if (!v && userName != null)
					{
						vr.ErrorText = "За пациентом уже закреплен дежурный: " + userName;
						MessageBox.Show(vr.ErrorText);
						vr.ErrorText = "";
						e.Cancel = true;
					}
				}
			}
		}
	}
}