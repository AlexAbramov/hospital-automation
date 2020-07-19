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
	public partial class StoreProductForm : Form
	{
		DataRow dataRow;
        bool readOnly=false;
		public StoreProductForm(DataRow dataRow, bool readOnly)
		{
			InitializeComponent();
			this.dataRow = dataRow;
			FormUtils.Init(this);
            this.readOnly = readOnly;
            if (readOnly)
            {
                Control[] controls ={ nudPrice,nudCount,dpExpiredDate,tbSeries,btnOk };
                foreach (Control ctl in controls) ctl.Enabled = false;
            }
		}

		private void StoreProductForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;

            lblProductInfo.Text = (string)dataRow["Name"];
            nudPrice.Value = (decimal)dataRow["Price"];
            nudCount.Value = (decimal)dataRow["Count"];
            tbSeries.Text = (string)dataRow["Series"];
			DateTimePickerUtils.Init(dpExpiredDate, dataRow["ExpiredDate"]);

            /*			tbMedicament.Text=dataRow["ProductName"].ToString();
                        using (GmConnection conn = App.CreateConnection())
                        {
                            ComboBoxUtils.Fill(cbStoreProductType,conn,"select Id, Name from StoreProductTypes order by Name",(int)dataRow["StoreProductTypeId"]);
                        }
                        dpExpiredDate.Value = (DateTime)dataRow["StartDate"];
                        dtpEndDate.Value=(DateTime)dataRow["ExpiredDate"];
                        nudDose.Value = (decimal)dataRow["Dose"];
                        nudMultiplicity.Value = (int)dataRow["Multiplicity"];
                        lblUnit.Text = dataRow["BaseUnitName"].ToString();
                        dpExpiredDate.ShowUpDown = true;
                        dtpEndDate.ShowUpDown = true;
                        nudDuration.Value = (int)dataRow["Duration"];
                        chkReanimation.Checked = (bool)dataRow["ReanimationFlag"];
            */
        }

		private void btnOk_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
            dataRow["Price"] = nudPrice.Value;
            dataRow["Count"] = nudCount.Value;
            dataRow["Series"] = tbSeries.Text;
            dataRow["ExpiredDate"] = DateTimePickerUtils.GetDateTimeObject(dpExpiredDate);
            
		}
	}
}