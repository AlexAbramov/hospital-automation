using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class PostmortalEpicrisisReportBuilder : BaseReportBuilder
	{
        public PostmortalEpicrisisReportBuilder(ConnectionFactory factory, Config config, Patient patient)
			: base(ReportBuilderId.PostmortalEpicrisis)
		{
			using (GmConnection conn = factory.CreateConnection())
			{
				GenderId genderId = patient.GetGender(conn);
				AddParameter("Age", patient.GetAgeStr(conn));
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				AddParameter("EndingOi", GenderUtils.GetEndingOi(genderId));
				AddParameter("EndingA", GenderUtils.GetEndingA(genderId));
				AddParameter("Treatment", patient.GetTreatment(conn));
				AddParameter("PatientInvestigation", patient.GetAnalysesList(conn));
				AddParameter("PatientExamination", patient.GetExamination(conn));
				AddParameter("PatientStateDynamics", patient.GetPatientStateDynamics(conn));
			}
  			AddHandbooksInfo(patient.dischargeData, config[HandbookGroupId.Postmortal]);
			AddParameter("Department", config.DepartmentFullName);
			AddParameter("AdmissionDiagnosis", patient.patientDiagnoses.admissionDiagnosis);
			AddParameter("FinalDiagnosis", patient.patientDiagnoses.finalDiagnosis);
			AddParameter("Complication", patient.patientDiagnoses.complicationDiagnosis);
			AddParameter("GeneralCondition", patient.patientDescription);
			AddParameter("Coverlet", patient.patientDescription);
			AddParameter("SystolicBloodPressure", patient.patientDescription);
			AddParameter("DiastolicBloodPressure", patient.patientDescription);
			AddParameter("HeartRate", patient.patientDescription);
			AddParameter("RespiratoryRate", patient.patientDescription);

/*			ArrayList ar=new ArrayList(parameters);
			foreach (KeyValuePair<string,string> pair in ar)
			{
				if (pair.Value.Trim().Length == 0)
				{
					parameters[pair.Key]= "-";
				}
			}	*/		
		}
	}
}
