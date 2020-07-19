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
	public partial class SelectAnalysisTypeUserControl : UserControl
	{
		public event EventHandler OnSelected;
		DataTable dataTable = new DataTable();
		public DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }	
		
		public SelectAnalysisTypeUserControl()
		{
			InitializeComponent();
		}

		private void SelectAnalysisTypeUserControl_Load(object sender, EventArgs e)
		{
			if (DesignMode||!App.IsConfigLoaded) return;
			LoadData();
		}

		void LoadData()
		{
			string cmdText = @"
select *
from AnalysisTypes 
";
			using (GmConnection conn = App.CreateConnection())
			{
				conn.Fill(dataTable,cmdText);
			}

			gridView.DataSource = dataTable;
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(OnSelected!=null) OnSelected(null,null);
		}

	}
}
