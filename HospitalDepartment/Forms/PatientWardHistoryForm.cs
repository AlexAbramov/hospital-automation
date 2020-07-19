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
using HospitalDepartment.Reports;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.Forms
{
	public partial class PatientWardHistoryForm : Form
	{
		Patient patient;
		DataTable dataTable = new DataTable();

		DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }
		int SelectedId { get { DataRow dr = SelectedRow; return dr!=null? (int)dr[0]: 0; } }

		public PatientWardHistoryForm(Patient patient)
		{
			InitializeComponent();
			this.patient = patient;
			FormUtils.Init(this);
		}

		private void PatientWardHistoryForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
		}

		void LoadData()
		{
            string cmdText = @"select PatientWardHistory.Id, Date, Number as WardNumber, PatientTypes.Name as PatientTypeName 
from PatientWardHistory 
left join Wards on WardId=Wards.Id 
left join PatientTypes on PatientTypeId=PatientTypes.Id
where PatientId=" + patient.Id;
			using (GmConnection conn = App.CreateConnection())
			{
				conn.Fill(dataTable, cmdText);
			}
			gridView.DataSource = dataTable;
		}


	}
}