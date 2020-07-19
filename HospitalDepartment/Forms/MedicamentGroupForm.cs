using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class MedicamentGroupForm : Form
	{
		MedicamentGroup medicamentGroup;
        public MedicamentGroup MedicamentGroup { get { return medicamentGroup; } }
        public MedicamentGroupForm(MedicamentGroup medicamentGroup)
		{
			InitializeComponent();
			FormUtils.Init(this);
            this.medicamentGroup = medicamentGroup;
            tbName.Text = medicamentGroup.name;
		}

		private void MedicamentGroupForm_Load(object sender, EventArgs e)
		{

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			medicamentGroup.name = tbName.Text.Trim().ToLower();
			using (GmConnection conn = App.CreateConnection())
			{
				medicamentGroup.Save(conn);
			}
		}

	}
}