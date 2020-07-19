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
	public partial class SelectStoreProductUserControl : UserControl
	{
		public event EventHandler OnSelected;
		DataTable dataTable = new DataTable();
		DbDataAdapter dataAdapter;
		public DataRow SelectedRow { get { return GridViewUtils.GetSelectedRow(gridView); } }	
		
		public SelectStoreProductUserControl()
		{
			InitializeComponent();
		}

		private void SelectStoreProductUserControl_Load(object sender, EventArgs e)
		{
			if (DesignMode||!App.IsConfigLoaded) return;
			LoadData();
		}

		void LoadData()
		{
			string cmdText = @"
select StoreProducts.*, Products.Code, Products.Name as ProductName, Products.Maker, Products.UnitCount, BaseUnits.Name as BaseUnitName
from StoreProducts 
left join Products on Products.Id=ProductId
left join BaseUnits on BaseUnits.Id=BaseUnitId
";
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
