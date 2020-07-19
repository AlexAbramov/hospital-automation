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
using Geomethod.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class MedicamentGroupsForm : Form
	{
        DataTable dataTable = new DataTable();
        DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
        int SelectedId { get { DataRow dr = SelectedRow; return dr != null ? (int)dr[0] : 0; } }
        bool readOnly = false;
//		HandbookRecord SelectedHandbook { get { DataRow dr = SelectedRow; return dr!=null? new HandbookRecord(dr): null; } }

		public MedicamentGroupsForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
		}

        internal bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
                bool vis = !readOnly;
                btnAdd.Visible = vis;
                btnRemove.Visible = vis;
                btnRestore.Visible = vis;
                btnOpen.Visible = vis;
            }
        }

		private void MedicamentGroupsForm_Load(object sender, EventArgs e)
		{
			LoadData();
            if (!App.HasPermission(PermissionId.MedicamentGroup)) ReadOnly = true;
            UpdateControls();
		}

		void LoadData()
		{
            using (GmConnection conn = App.CreateConnection())
            {
                conn.Fill(dataTable, "select * from MedicamentGroups");
            }
            bindingSource.DataSource = dataTable;
            bindingSource.Sort = "Name";
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Open();
		}

		private void Open()
		{
            try
            {
                if (readOnly) return;
                DataRow dr = SelectedRow;
                if (dr != null)
                {
                    int id = (int)dr["Id"];
                    MedicamentGroup medicamentGroup = null;
                    using (GmConnection conn = App.CreateConnection())
                    {
                        medicamentGroup = MedicamentGroup.GetMedicamentGroup(conn, id);
                    }
                    if (medicamentGroup != null)
                    {
                        MedicamentGroupForm form = new MedicamentGroupForm(medicamentGroup);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            dr["Name"] = medicamentGroup.name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

/*		private bool HasName(string name, DataRow ignoredRow)
		{
			foreach(DataRow dr in dataTable.Rows)
			{
				if (dr != ignoredRow && string.Compare(dr[dcName].ToString(), name, true) == 0) return true;
			}
			return false;
		}*/

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = SelectedRow;
                if (dr != null)
                {
                    int id = (int)dr["Id"];
                    dr["Status"] = (int)Status.Removed;
                    using (GmConnection conn = App.CreateConnection())
                    {
                        MedicamentGroup.SetStatus(conn, id, Status.Removed);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

        private void chkShowRemoved_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void UpdateControls()
        {
            bindingSource.Filter = chkShowRemoved.Checked ? "Status=0" : "Status=1";
            btnRestore.Visible =!readOnly && chkShowRemoved.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MedicamentGroup medicamentGroup = new MedicamentGroup();
                MedicamentGroupForm form = new MedicamentGroupForm(medicamentGroup);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow["Id"] = medicamentGroup.Id;
                    newRow["Name"] = medicamentGroup.name;
                    newRow["Status"] = medicamentGroup.status;
                    dataTable.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = SelectedRow;
                if (dr != null)
                {
                    int id = (int)dr["Id"];
                    dr["Status"] = (int)Status.Normal;
                    using (GmConnection conn = App.CreateConnection())
                    {
                        MedicamentGroup.SetStatus(conn, id, Status.Normal);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }
	}
}