using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class SelectDiagnosisForm : Form
	{
		DiagnosisInfo diagnosisInfo;
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }
		public DiagnosisInfo SelectedDiagnosisInfo { get { return diagnosisInfo; } }

		public SelectDiagnosisForm(DiagnosisInfo diagnosisInfo)
		{
			InitializeComponent();
			this.diagnosisInfo = diagnosisInfo;
			FormUtils.Init(this);
		}

		private void DiagnosesForm_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		void LoadData()
		{
			string fieldName = "HospitalStay" + App.DepartmentConfig.hospitalType.ToString();
			string cmdText = string.Format("select *, {0} as HospitalStay from Diagnoses where {0}>0", fieldName);
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter(cmdText);
				dataAdapter.Fill(dataTable);
			}
			gridView.DataSource = dataTable;
			if (diagnosisInfo.code.Trim().Length > 0)
			{
				GridViewUtils.SetCurrentRow(gridView, "Code='" + diagnosisInfo.code+"'");
			}
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			OnOk();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			OnOk();
		}

		private void OnOk()
		{
			DataRow dr = SelectedRow;
			if (dr != null)
			{
				diagnosisInfo.id = (int)dr["Id"];
				diagnosisInfo.code = (string)dr["Code"];
				diagnosisInfo.text = (string)dr["Name"];
			}
		}
	}
}