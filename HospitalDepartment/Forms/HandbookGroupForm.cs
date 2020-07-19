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
using ComboItem = System.Collections.Generic.KeyValuePair<string, HospitalDepartment.HandbookType>;

namespace HospitalDepartment.Forms
{
	public partial class HandbookGroupForm : Form
	{
		HandbookGroup handbookGroup;
		Handbook SelectedHandbook { get { return GridViewUtils.GetSelectedItem(gridView) as Handbook; } }

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
//		Handbook SelectedHandbook { get { DataRow dr = SelectedRow; return dr!=null? new Handbook(dr): null; } }

		public HandbookGroupForm(HandbookGroup handbookGroup)
		{
			InitializeComponent();
			this.handbookGroup = handbookGroup;
			FormUtils.Init(this);
		}

		private void HandbooksForm_Load(object sender, EventArgs e)
		{
			colDataType.DisplayMember = "Key";
			colDataType.ValueMember = "Value";
			colDataType.Items.Add(new ComboItem("Заголовок", HandbookType.Header));
			colDataType.Items.Add(new ComboItem("Строка", HandbookType.String));
			colDataType.Items.Add(new ComboItem("Число", HandbookType.Number));
            colDataType.Items.Add(new ComboItem("Дата", HandbookType.Date));
            tbName.Text = handbookGroup.name;
			gridView.DataSource = handbookGroup.handbooks;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
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
				Handbook hb = SelectedHandbook;
				if (hb != null)
				{
					HandbookForm form = new HandbookForm(hb);
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

	}
}