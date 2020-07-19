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
	public partial class ProductForm : Form
	{
		Product product;
		public Product Product { get { return product; } }
		public string MedicamentName { get { return ComboBoxUtils.GetSelectedText(cbMedicament); } }
		public string BaseUnitName { get { return ComboBoxUtils.GetSelectedText(cbBaseUnit); } }
		public ProductForm()
		{
			InitializeComponent();
		}
		public ProductForm(Product product)
		{
			InitializeComponent();
			this.product = product;
			FormUtils.Init(this);
		}

		private void ProductForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			using (GmConnection conn = App.CreateConnection())
			{
                cbMedicament.Fill(conn, "select Id, Name from Medicaments order by Name", product.medicamentId);
                cbBaseUnit.Fill(conn, "select Id, Name from BaseUnits order by Name", product.baseUnitId);
			}
			tbName.Text = product.name;
			tbCode.Text = product.code;
			nudPackedNumber.Value = product.packedNumber;
			tbMaker.Text = product.maker;
			nudUnitCount.Value = product.unitCount;
            cbMedLists.Text=product.medLists;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			product.name = tbName.Text.Trim();
			product.code = tbCode.Text.Trim();
			product.packedNumber = (int)nudPackedNumber.Value;
			product.medicamentId = ComboBoxUtils.GetSelectedValue(cbMedicament);
			product.maker = tbMaker.Text.Trim();
			product.baseUnitId = ComboBoxUtils.GetSelectedValue(cbBaseUnit);
			product.unitCount = nudUnitCount.Value;
            product.medLists = cbMedLists.Text;
            using (GmConnection conn = App.CreateConnection())
			{
				product.Save(conn);
			}
		}
	}
}