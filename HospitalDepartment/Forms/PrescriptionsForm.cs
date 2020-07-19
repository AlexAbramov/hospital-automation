using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;
using HospitalDepartment.Forms;

namespace HospitalDepartment.Forms
{
    public partial class PrescriptionsForm : Form
    {
        Patient patient;
        DataTable dataTable = new DataTable();

        DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
        //		int SelectedId { get { DataRow dr = SelectedRow; return dr != null ? (int)dr[0] : 0; } }

        public PrescriptionsForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void PrescriptionsForm_Load(object sender, EventArgs e)
        {
            if (base.DesignMode) return;
            string cmdText = @"
select Prescriptions.*, Products.Name as ProductName, BaseUnits.Name as BaseUnitName, UnitCount, PrescriptionTypes.Name as PrescriptionTypeName
from Prescriptions 
left join StoreProducts on StoreProducts.Id=StoreProductId
left join Products on Products.Id=ProductId
left join BaseUnits on BaseUnits.Id=BaseUnitId
left join PrescriptionTypes on PrescriptionTypes.Id=PrescriptionTypeId
";
            using (GmConnection conn = App.CreateConnection())
            {
                conn.Fill(dataTable, cmdText + " where PatientId=" + patient.Id);
            }
//            gridView.DataError += new DataGridViewDataErrorEventHandler(gridView_DataError);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = dataTable;
            //			gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }


    }
}