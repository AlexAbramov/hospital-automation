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
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class PatientsPrescriptionsForm : Form
	{
        Document doc=new Document(DocumentTypeId.Outgoing);
        bool hasWatching;
		public PatientsPrescriptionsForm()
		{
			InitializeComponent();
            hasWatching=App.Instance.UserInfo.HasWatching;
            if (doc.documentData.patients.Count == 0 && hasWatching)
            {
                doc.documentData.patients.AddRange(App.Instance.UserInfo.Watching.Patients);
            }
			FormUtils.Init(this);
		}

		private void DocumentForm_Load(object sender, EventArgs e)
		{
            if (!DesignMode)
            {
                LoadDocument();
            }
		}

        private void LoadDocument()
        {
            dpDate.Value = doc.date;
            lblUser.Text += App.Instance.AppCache.GetUserName(doc.userId);
            foreach (PrescriptionType pt in App.Instance.AppCache.PrescriptionTypes)
            {
                lbPrescriptionTypes.Items.Add(pt, doc.documentData.HasPrescriptionType(pt.Id));
            }
        }

		int LoadData()
		{
            reportsDataSet.PatientsPrescriptions.Clear();
            doc.documentData.prescriptionTypes.Clear();
            foreach (PrescriptionType prescriptionType in lbPrescriptionTypes.CheckedItems)
            {
                doc.documentData.prescriptionTypes.Add(prescriptionType.Id);
            }
            doc.date = dpDate.Value.Date;
            if (doc.documentData.prescriptionTypes.Count == 0) return 0;
			string cmdText= @"
SELECT        Wards.Number AS WardNumber, Prescriptions.PatientId, Passports.Surname + ' ' + Passports.Name AS PatientName, 
                         PrescriptionTypes.Name AS PrescriptionTypeName, Products.Name AS ProductName, Prescriptions.Dose, BaseUnits.Name AS BaseUnitName, 
                         Prescriptions.Multiplicity
FROM            Prescriptions LEFT OUTER JOIN
                         StoreProducts ON StoreProducts.Id = Prescriptions.StoreProductId LEFT OUTER JOIN
                         Products ON Products.Id = StoreProducts.ProductId LEFT OUTER JOIN
                         BaseUnits ON BaseUnits.Id = Products.BaseUnitId LEFT OUTER JOIN
                         PrescriptionTypes ON PrescriptionTypes.Id = Prescriptions.PrescriptionTypeId LEFT OUTER JOIN
                         Patients ON Patients.Id = Prescriptions.PatientId LEFT OUTER JOIN
                         Wards ON Wards.Id = Patients.WardId LEFT OUTER JOIN
                         Passports ON Passports.Id = Patients.PassportId 
WHERE (Prescriptions.StartDate <= @EndDate) AND (@StartDate <= Prescriptions.EndDate)";
            cmdText += string.Format(" and PrescriptionTypeId in ({0})", CollectionUtils.GetCommaSeparatedList(doc.documentData.prescriptionTypes));
            if (hasWatching)
            {
                cmdText += string.Format(" and PatientId in ({0})", CollectionUtils.GetCommaSeparatedList(doc.documentData.patients));
            }
            else cmdText += " and (DischargeDate is null)";
            cmdText+=" ORDER BY WardNumber, Prescriptions.PatientId";
        
			using (GmConnection conn = App.CreateConnection())
			{
				GmCommand cmd = conn.CreateCommand(cmdText);
                cmd.AddDateTime("StartDate", doc.date);
                cmd.AddDateTime("EndDate", doc.date+TimeSpan.FromDays(1));
                cmd.Fill(reportsDataSet.PatientsPrescriptions);
			}
            return reportsDataSet.PatientsPrescriptions.Rows.Count;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
		}

        private void lbPrescriptionTypes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateControls();
        }

        private void UpdateControls()
        {
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

	}
}