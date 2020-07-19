using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDepartment.UserControls
{
	interface IPatientAdmissionControl
	{
		void OnSelected();
	}
	interface IHandbookUserControl
	{
		void Init(Handbook handbook);
		void Save();
	}	
}
