using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using Geomethod.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class WardForm : Form
	{
		Ward ward;
		public Ward Ward { get { return ward; } }
		public string WardTypeName{ get { return cbWardType.Text; } }
		public WardForm()
		{
			InitializeComponent();
		}
		public WardForm(Ward ward)
		{
			InitializeComponent();
			this.ward = ward;
			FormUtils.Init(this);
		}

		private void WardForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			using (GmConnection conn = App.CreateConnection())
			{
                cbWardType.Fill(conn, "select Id, Name from WardTypes", (int)ward.wardTypeId);
			}
			tbNumber.Text = ward.number;
			nudNumberOfBeds.Value = ward.numberOfBeds;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			ward.number = tbNumber.Text.Trim();
			ward.wardTypeId = (WardTypeId)ComboBoxUtils.GetSelectedValue(cbWardType);
			ward.numberOfBeds = (int)nudNumberOfBeds.Value;
			using (GmConnection conn = App.CreateConnection())
			{
				ward.Save(conn);
			}
		}
	}
}