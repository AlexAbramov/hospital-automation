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
    public partial class AnalysesForm : Form
    {
        Patient patient;
        DataTable dataTable = new DataTable();

        DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
        //		int SelectedId { get { DataRow dr = SelectedRow; return dr != null ? (int)dr[0] : 0; } }

        public AnalysesForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            FormUtils.Init(this);
        }

        private void AnalysesForm_Load(object sender, EventArgs e)
        {
            if (base.DesignMode) return;
            string cmdText = @"
select Analyses.*, AnalysisTypes.Name as AnalysisTypeName
from Analyses 
left join AnalysisTypes on AnalysisTypes.Id=AnalysisTypeId
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

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void Open()
        {
            try
            {
                Analysis analysis = GetAnalysis();
                if (analysis != null)
                {
                    AnalisisForm form = new AnalisisForm(analysis, patient);
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Open();
        }

        private Analysis GetAnalysis()
        {
            DataRow dr = SelectedRow;
            if (dr != null)
            {
                return new Analysis(dr);// (DataTableUtils.CreateDataReader(dataTable, dr));
            }
            return null;
        }

    }
}