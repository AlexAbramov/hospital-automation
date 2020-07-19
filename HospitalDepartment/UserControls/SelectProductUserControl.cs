using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment.Utils;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class SelectProductUserControl : UserControl
	{
		public event EventHandler OnSelected;
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;
		public DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }	
		
		public SelectProductUserControl()
		{
			InitializeComponent();
		}

		private void SelectProductUserControl_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			LoadData();
		}

		void LoadData()
		{
			string cmdText = @"
select Products.*, Medicaments.Id as MedicamentId, Medicaments.Name as MedicamentName 
from Products 
left join Medicaments on Medicaments.Id=MedicamentId";
			using (GmConnection conn = App.CreateConnection())
			{
				dataAdapter = conn.CreateDataAdapter(cmdText);
				dataAdapter.Fill(dataTable);
			}

			gridView.DataSource = dataTable;
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(OnSelected!=null) OnSelected(null,null);
		}
	}
}
