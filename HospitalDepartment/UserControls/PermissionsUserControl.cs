using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.UserControls
{

	public partial class PermissionsUserControl : UserControl
	{
        public List<CheckedPermission> checkedPermissions = new List<CheckedPermission>();
//		DataTable dt = new DataTable();
//		DataColumn dcId;
//		DataColumn dcChecked;
		Permissions permissions;
        CheckedPermission SelectedDataBoundItem { get { return GridViewUtils.GetSelectedDataBoundItem(gridView) as CheckedPermission; } }
        
        public void Init(Permissions permissions)
		{
			this.permissions = permissions;
		}
		public PermissionsUserControl()
		{
			InitializeComponent();
		}

		internal void Save()
		{
			permissions.Clear();
			foreach (CheckedPermission cp in checkedPermissions)
			{
				if (cp.Checked) permissions.SetPermission(cp.id);
			}
		}

		private void PermissionsUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
/*			using (GmConnection conn = App.CreateConnection())
			{
				conn.Fill(dt, "select Id, Name from Permissions");
			}
			dcId = dt.Columns[0];
			dcChecked = dt.Columns.Add("Checked", typeof(bool));
			dcChecked.DefaultValue = false;
			foreach (DataRow dr in dt.Rows)
			{
				PermissionId p = (PermissionId)dr[dcId];
				dr[dcChecked] = permissions.HasPermission(p);
			}*/
            foreach (Permission p in App.Config.permissions)
            {
                CheckedPermission cp = new CheckedPermission(p);
                cp.Checked = permissions.HasPermission(cp.id);
                checkedPermissions.Add(cp);
            }
            gridView.DataSource = checkedPermissions;

		}

        public class CheckedPermission : Permission
        {
            bool check = false;
            public bool Checked { get { return check; } set { check = value; } }
            public CheckedPermission(Permission p)
                : base(p)
            {
            }
        }

        private void gridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (gridView.IsCurrentCellDirty)
            {
                gridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void gridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colChecked.Index)
                OnCheckedPermissionChanged();
        }

        private void OnCheckedPermissionChanged()
        {
            CheckedPermission cp = SelectedDataBoundItem;
            if (cp != null)
            {
                bool changed = false;
                if (cp.name.Length == 0)
                {
                    foreach (CheckedPermission cp2 in checkedPermissions)
                    {
                        if (cp.id != cp2.id && cp.group == cp2.group)
                        {
                            cp2.Checked = cp.Checked;
                            changed = true;
                        }
                    }
                }
                else if(cp.Checked)
                {
                    foreach (CheckedPermission cp2 in checkedPermissions)
                    {
                        if (cp.id != cp2.id && cp2.name.Length==0 && cp2.group==cp.group)
                        {
                            if (!cp2.Checked)
                            {
                                cp2.Checked = true;
                                changed = true;
                            }
                            break;
                        }
                    }
                }
                if(changed) gridView.Invalidate();
            }
        }

	}
}
