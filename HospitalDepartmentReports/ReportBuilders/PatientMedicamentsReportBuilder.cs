using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class PatientMedicamentsReportBuilder : BaseReportBuilder
	{
        public PatientMedicamentsReportBuilder(ConnectionFactory factory, Config config, Patient patient)
            : base(ReportBuilderId.PatientMedicaments)
		{
            AddDataSource("ReportsDataSet_PatientMedicaments", GetPatientMedicamentsTable(factory, patient.Id));
            Insurance insurance;
            string insuranceCompanyName="";
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				AddParameter("Age", patient.GetAgeStr(conn));
                insurance=patient.GetInsurance(conn);
                if (insurance!=null) insuranceCompanyName = insurance.GetInsuranceCompanyName(conn);
			}
            AddParameter("HeadDoctor", config.departmentConfig.headDoctor);
            AddParameter("DepartmentName", config.departmentConfig.departmentName);
            AddParameter("HospitalName", config.departmentConfig.hospitalName);
            DiagnosisInfo di = patient.patientDiagnoses.LatestDiagnosisInfo;
            AddParameter("Diagnosis", di.text);
            AddParameter("DiagnosisCode", di.code);
            AddParameter("AdmissionDate", patient.admissionDate);
            AddParameter("DischargeDate", patient.DischargeDateStr);
            AddParameter("Duration", patient.Duration);
            AddParameter("CaseHistoryNumber", patient.patientData);
            AddParameter("InsuranceNumber", insurance!=null?insurance.number:"");
            AddParameter("InsuranceCompany", insuranceCompanyName);
        }

        public static ReportsDataSet.PatientMedicamentsDataTable GetPatientMedicamentsTable(ConnectionFactory factory, int patientId)
		{
            ReportsDataSet.PatientMedicamentsDataTable dtPatientMedicaments = new ReportsDataSet.PatientMedicamentsDataTable();
            string cmdText = @"
SELECT StoreProducts.Id, Products.Name, Products.PackedNumber, Products.Maker, Prescriptions.Dose * Prescriptions.Multiplicity * Prescriptions.Duration AS Count,
                          StoreProducts.Price, Prescriptions.Dose * Prescriptions.Multiplicity * Prescriptions.Duration * StoreProducts.Price AS Sum, Series, MedLists
FROM Prescriptions 
LEFT OUTER JOIN StoreProducts ON StoreProducts.Id = Prescriptions.StoreProductId 
LEFT OUTER JOIN Products ON Products.Id = StoreProducts.ProductId
WHERE Prescriptions.PatientId = @PatientId";
            using (GmConnection conn = factory.CreateConnection())
			{
                GmCommand cmd = conn.CreateCommand(cmdText);
                cmd.AddInt("PatientId", patientId);
                conn.Fill(dtPatientMedicaments, cmd);
			}
            int index = 0;
			foreach (ReportsDataSet.PatientMedicamentsRow row in dtPatientMedicaments.Rows)
			{
                row.Id = ++index;
			}
			return dtPatientMedicaments;
		}
	}
}
