using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using Geomethod.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;
using HospitalDepartment.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class PrescriptionsUserControl : UserControl, IPatientAdmissionControl
	{
		bool loaded = false;
		Patient patient;
		DataTable dataTable=new DataTable();
		int diagnosisId = 0;
		int hospitalStay = 0;
        int patientId = 0;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr != null ? (int)dr[0] : 0; } }

		public void Init(Patient patient)
		{
			this.patient=patient;
            patientId = patient.Id;
		}
		public PrescriptionsUserControl()
		{
			InitializeComponent();
		}

		private void PrescriptionsUserControl_Load(object sender, EventArgs e)
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
                //				ComboBoxUtils.Fill(colPrescriptionName, conn, "select Id, Name from PrescriptionTypes",null);
                conn.Fill(dataTable, cmdText + " where PatientId=" + (patientId == 0 ? -1 : patientId));
            }
/*			dt.Columns.Add("MedicamentName", typeof(string));
			dt.Columns.Add("Dose", typeof(decimal));
			dt.Columns.Add("Factor", typeof(decimal));*/
//			dataTable.Columns.Add("Duration", typeof(TimeSpan),"EndDate-StartDate");
			gridView.DataError += new DataGridViewDataErrorEventHandler(gridView_DataError);
			gridView.DataSource = dataTable;
//			gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			loaded = true;
		}

		void gridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			Log.Exception(e.Exception);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Add();
		}

		private void ucSelectStoreProduct_OnSelected(object sender, EventArgs e)
		{
			Add();
		}

		private void Add()
		{
			try
			{
				DataRow productRow = ucSelectStoreProduct.SelectedRow;
				if (productRow != null)
				{
					DataRow dr = dataTable.NewRow();
					dr["PatientId"] = patientId;
					dr["PrescriptionTypeId"] = (int)PrescriptionTypeId.Inner;
					dr["StoreProductId"] = productRow["Id"];
					dr["Dose"] = 0;
					dr["Multiplicity"] = 1;
					DateTime now = DateTime.Now;
					dr["StartDate"] = now;
					dr["EndDate"] = now;
					dr["ProductName"] = productRow["ProductName"];
					dr["BaseUnitName"] = productRow["BaseUnitName"];
					dr["UnitCount"] = productRow["UnitCount"];
					dr["Duration"] = hospitalStay;
					dr["ReanimationFlag"] = false;
					if (ShowPrescriptionForm(dr))
					{
						dataTable.Rows.Add(dr);
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

        internal void Save(GmConnection conn)
		{
			if (!loaded) return;
            if (patientId == 0)
            {
                patientId = patient.Id;
                foreach (DataRow dr in dataTable.Rows) dr["PatientId"] = patientId;
            }
            if (patientId > 0)
            {
                DbCommandBuilder bld = conn.CreateCommandBuilder();
                bld.ConflictOption = ConflictOption.OverwriteChanges;
                DbDataAdapter dataAdapter = conn.CreateDataAdapter("select top 0 * from Prescriptions");
                bld.DataAdapter = dataAdapter;
                dataAdapter.Update(dataTable);
            }
            else Log.Error("PrescriptionsUserControl.Save patientId=0");
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			Generate();
		}

		private void Generate()
		{

		}

		bool ShowPrescriptionForm(DataRow dr)
		{
			if (dr != null)
			{
			PrescriptionForm form = new PrescriptionForm(dr, patient);
			if(form.ShowDialog()==DialogResult.OK)
			{
				return true;
			}
			}
			return false;
		}

		#region IPatientAdmissionControl Members

		public void OnSelected()
		{
			DiagnosisInfo di=patient.LatestDiagnosisInfo;
			if (diagnosisId != di.id)
			{
				using (GmConnection conn = App.CreateConnection())
				{
					Diagnosis d = di.GetDiagnosis(conn);
					if (d != null)
					{
                        hospitalStay = App.DepartmentConfig.GetRecommendedHospitalStay(d);
					}
				}
				diagnosisId = di.id;
			}
			lblHospitalStay.Text = string.Format("Ориентировочный срок пребывания больного в стационаре {0} койкодней", hospitalStay);
		}

		#endregion

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Open();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void Open()
		{
			try
			{
				ShowPrescriptionForm(SelectedRow);
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			Remove();
		}

		private void Remove()
		{
			try
			{
				DataRow selRow = SelectedRow;
				if (selRow != null)
				{
					object obj = selRow[0];
					if (obj is int)
					{
						int id = (int)obj;
						using (GmConnection conn = App.CreateConnection())
						{
							GmCommand cmd = conn.CreateCommand("delete from Prescriptions where Id=@Id");
							cmd.AddInt("Id", id);
							cmd.ExecuteNonQuery();
						}
					}
					dataTable.Rows.Remove(selRow);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}



	}
}
