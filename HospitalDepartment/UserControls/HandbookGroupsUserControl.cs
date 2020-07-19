using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Forms;
using HospitalDepartment.Utils;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class HandbookGroupsUserControl : UserControl
	{
		Config config;
		public void Init(Config config) { this.config = config; }

		HandbookGroup SelectedHandbookGroup { get { return GridViewUtils.GetSelectedItem(gridView) as HandbookGroup; } }

		public HandbookGroupsUserControl()
		{
			InitializeComponent();
		}

		private void HandbookGroupsUserControl_Load(object sender, EventArgs e)
		{
			if (!base.DesignMode)
			{
				gridView.DataSource = config.handbookGroups;
			}
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void Open()
		{
			try
			{
				HandbookGroup hg = SelectedHandbookGroup;
				if (hg != null)
				{
					HandbookGroupForm form = new HandbookGroupForm(hg);
					if (form.ShowDialog() == DialogResult.OK)
					{
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Open();
		}
	}
}
