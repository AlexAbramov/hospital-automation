using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using Geomethod;
//using Geomethod.Data;
using HospitalDepartment.Utils;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class InsuranceUserControl : UserControl
	{
		bool loaded=false;
		Insurance insurance;
		public void Init(Insurance insurance)
		{
			this.insurance = insurance;
		}
		public InsuranceUserControl()
		{
			InitializeComponent();
		}

		private void InsuranceUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
			using (GmConnection conn = App.CreateConnection())
			{
                cbInsuranceCompany.Fill(conn, "select Id, Name from InsuranceCompanies", insurance.insuranceCompanyId);
				tbDelo.Text = insurance.delo;
				tbSeries.Text = insurance.series;
				tbNumber.Text = insurance.number;
			}
			loaded = true;
		}

		internal bool Save()
		{
			if (!loaded) return false; ;
			insurance.delo = tbDelo.Text.Trim();
			insurance.series = tbSeries.Text.Trim();
			insurance.number = tbNumber.Text.Trim();
			insurance.insuranceCompanyId = cbInsuranceCompany.GetInt();
			return ReflectionUtils.HasData(insurance);
		}
	}
}
