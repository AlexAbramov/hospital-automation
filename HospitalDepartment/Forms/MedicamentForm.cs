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
	public partial class MedicamentForm : Form
	{
		Medicament medicament;
		public Medicament Medicament { get { return medicament; } }
		public MedicamentForm()
		{
			InitializeComponent();
            FormUtils.Init(this);
		}
		public MedicamentForm(Medicament medicament)
		{
			InitializeComponent();
			FormUtils.Init(this);
			this.medicament = medicament;
			using (GmConnection conn = App.CreateConnection())
			{
				ucMedicamentGroups.Init(medicament.Id, "MedicamentGroupTies", "MedicamentId");
			}
			tbName.Text = medicament.name;
		}

		private void MedicamentForm_Load(object sender, EventArgs e)
		{

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			medicament.name = tbName.Text.Trim().ToLower();
			using (GmConnection conn = App.CreateConnection())
			{
				medicament.Save(conn);
				ucMedicamentGroups.Save(conn,medicament.Id);
			}
		}
	}
}