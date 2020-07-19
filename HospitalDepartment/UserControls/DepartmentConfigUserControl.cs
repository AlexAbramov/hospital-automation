using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Utils;
using ComboItem = System.Collections.Generic.KeyValuePair<string, HospitalDepartment.HospitalType>;

namespace HospitalDepartment.UserControls
{
	public partial class DepartmentConfigUserControl : UserControl
	{
		bool loaded = false;
		DepartmentConfig departmentConfig;
		Config config;
		public void Init(Config config) 
		{ 
			this.config = config; 
			departmentConfig = config.departmentConfig; 
			ucDiets.StringList = departmentConfig.Diets;
		}
		public DepartmentConfigUserControl()
		{
			InitializeComponent();
		}

		private void DepartmentConfigUserControl_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;
			tbDepartmentName.Text = departmentConfig.departmentName;
			tbHospitalName.Text = departmentConfig.hospitalName;
            tbHeadDoctor.Text=departmentConfig.headDoctor;

			cbHospitalType.DisplayMember = "Key";
			cbHospitalType.ValueMember = "Value";
			cbHospitalType.Items.Add(new ComboItem("Высшая", HospitalType.High));
			cbHospitalType.Items.Add(new ComboItem("Первая", HospitalType.First));
			cbHospitalType.Items.Add(new ComboItem("Вторая", HospitalType.Second));
			cbHospitalType.Items.Add(new ComboItem("Дневной стационар", HospitalType.Day));

            foreach(ComboItem ci in cbHospitalType.Items)
			{
				if(ci.Value==departmentConfig.hospitalType)
				{
					cbHospitalType.SelectedItem=ci;
					break;
				}
			}

            lblDefaultDiet.Text = departmentConfig.defaultDiet;

            nudTaskGenPeriod.Value=departmentConfig.taskGenPeriod;
            nudCommonObservationPeriod.Value = departmentConfig.commonObservationPeriod;
            nudIntensiveCareObservationPeriod.Value = departmentConfig.intensiveCareObservationPeriod;
            nudReanimationObservationPeriod.Value = departmentConfig.reanimationObservationPeriod;
            nudTemperatureObservationPeriod.Value = departmentConfig.temperatureObservationPeriod;
            nudIntensiveCareMaxDuration.Value = departmentConfig.intensiveCareMaxDuration;
            nudReanimationMaxDuration.Value = departmentConfig.reanimationMaxDuration;
            nudClinicDiagnosisDays.Value = departmentConfig.clinicDiagnosisDays;
            nudDoctorRoundPeriod.Value = departmentConfig.doctorRoundPeriod;
            nudChiefRoundPeriod.Value = departmentConfig.chiefRoundPeriod;
			loaded = true;
		}

		internal void Save()
		{
			if (loaded)
			{
				departmentConfig.hospitalName = tbHospitalName.Text.Trim();
				departmentConfig.headDoctor = tbHeadDoctor.Text.Trim();
				tbDepartmentName.Text = departmentConfig.departmentName;
				departmentConfig.hospitalType = ((ComboItem)cbHospitalType.SelectedItem).Value;
				ucDiets.Save();

				departmentConfig.taskGenPeriod = (int)nudTaskGenPeriod.Value;
				departmentConfig.commonObservationPeriod = (int)nudCommonObservationPeriod.Value;
				departmentConfig.intensiveCareObservationPeriod = (int)nudIntensiveCareObservationPeriod.Value;
				departmentConfig.reanimationObservationPeriod = (int)nudReanimationObservationPeriod.Value;
				departmentConfig.temperatureObservationPeriod = (int)nudTemperatureObservationPeriod.Value;
				departmentConfig.intensiveCareMaxDuration = (int)nudIntensiveCareMaxDuration.Value;
				departmentConfig.reanimationMaxDuration = (int)nudReanimationMaxDuration.Value;
				departmentConfig.clinicDiagnosisDays = (int)nudClinicDiagnosisDays.Value;
				departmentConfig.doctorRoundPeriod = (int)nudDoctorRoundPeriod.Value;
				departmentConfig.chiefRoundPeriod = (int)nudChiefRoundPeriod.Value;
			}
        }

        private void btnDefaultDiet_Click(object sender, EventArgs e)
        {
            string s=ucDiets.SelectedString;
            if (!String.IsNullOrEmpty(s))
            {
                departmentConfig.defaultDiet = s;
                lblDefaultDiet.Text = departmentConfig.defaultDiet;
            }
        }
	}
}
