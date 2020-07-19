using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Data;
using Geomethod.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class AnalisisForm : Form
	{
		Analysis analysis;
		Patient patient;
		public Analysis Analysis { get { return analysis; } }
		public AnalisisForm(Analysis analysis, Patient patient)
		{
			InitializeComponent();
			this.analysis = analysis;
			this.patient = patient;
			FormUtils.Init(this);
		}

        public bool ReadOnly
        {
            get { return !ucHandbooksInfo.Enabled; }
            set
            {
                bool readOnly = value;
                ucHandbooksInfo.Enabled = !readOnly;
                if (readOnly)
                {
                    btnOk.Text = "Закрыть";
                    btnCancel.Visible = false;
                }
            }
        }

		private void AnalysisForm_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			DateTimePickerUtils.Init(dtpRequestDate, analysis.requestDate);
			DateTimePickerUtils.Init(dtpExecutionDate,analysis.executionDate);
			AnalysisType analysisType;
			using (GmConnection conn = App.CreateConnection())
			{
				analysisType = analysis.GetAnalysisType(conn);
			}
			base.Text = analysisType.name;
			HandbookGroup hg=App.Config.GetHandbookGroup(analysisType.handbookGroupId);
			if(hg!=null)
			{
			  ucHandbooksInfo.Init(analysis.analysisData, hg);
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			analysis.requestDate = DateTimePickerUtils.GetDateTime(dtpRequestDate);
			analysis.executionDate = DateTimePickerUtils.GetDateTime(dtpExecutionDate);
			ucHandbooksInfo.Save();
/*			using (GmConnection conn = App.CreateConnection())
			{
				analysis.Save(conn);
			}*/
		}
	}
}