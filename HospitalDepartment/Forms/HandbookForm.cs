using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment;
using HospitalDepartment.Utils;
using HospitalDepartment.UserControls;
using Geomethod;

namespace HospitalDepartment.Forms
{
	public partial class HandbookForm : Form
	{
		Handbook handbook;
		IHandbookUserControl ucHandbook = null;

		public HandbookForm(Handbook handbook)
		{
			InitializeComponent();
			this.handbook = handbook;
			FormUtils.Init(this);
		}

		private void Init()
		{
			base.SuspendLayout();
			base.AutoSize = true;
			panel.AutoSize = true;
			tbName.Text = handbook.name;
			chkFrequent.Checked = handbook.frequent;
			switch (handbook.handbookType)
			{
				case HandbookType.Number:
					ucHandbook = new NumberHandbookUserControl();
					break;
                case HandbookType.Date:
                    ucHandbook = new DateHandbookUserControl();
                    break;
                case HandbookType.String:
					ucHandbook = new StringHandbookUserControl();
					break;
			}
			panel.Controls.Clear();
			UserControl ctl=null;
			if (ucHandbook != null)
			{
				ucHandbook.Init(handbook);
				ctl = ucHandbook as UserControl;
				panel.Controls.Add(ctl);
			}
			base.ResumeLayout();

			panel.AutoSize = false;
			Size size = base.Size;
			base.AutoSize = false;
			base.Size = size;
			base.MinimumSize = size;
			if (ctl != null && !ctl.AutoSize)
			{
				ctl.Dock = DockStyle.Fill;
			}
		}

		private void HandbookForm_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			Init();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			if (ucHandbook != null) ucHandbook.Save();
			handbook.name = tbName.Text.Trim();
			handbook.frequent = chkFrequent.Checked;
		}
	}
}