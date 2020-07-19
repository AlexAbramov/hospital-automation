using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class PrescriptionsReportBuilder : BaseReportBuilder
	{
        public PrescriptionsReportBuilder(ConnectionFactory factory, Config config, Patient patient)
            : base(ReportBuilderId.Prescriptions)
		{
			AddDataSource("ReportsDataSet_Prescriptions", GetPrescriptionsTable(factory, patient.Id));
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("DoctorName", patient.GetDoctorName(conn));
				AddParameter("ChiefName", patient.GetChiefName(conn));
				AddParameter("WardNumber", patient.GetWardNumber(conn));
				AddParameter("Age", patient.GetAgeStr(conn));
			}
			AddHandbooksInfo(patient.patientData, config[HandbookGroupId.PatientData]);
			AddParameter("AdmissionDate", patient.admissionDate, "dd.MM.yy HH:mm");
			AddParameter("Diet", patient.dietNumber);
		}

        public static ReportsDataSet.PrescriptionsDataTable GetPrescriptionsTable(ConnectionFactory factory, int patientId)
		{
			DataTable dataTable = new DataTable();
			string cmdText = @"
select Prescriptions.*, Products.Name as ProductName, BaseUnits.Name as BaseUnitName 
from Prescriptions 
left join StoreProducts on StoreProducts.Id=StoreProductId
left join Products on Products.Id=ProductId
left join BaseUnits on BaseUnits.Id=BaseUnitId
where PatientId=" + patientId;
			using (GmConnection conn = factory.CreateConnection())
			{
				conn.Fill(dataTable, cmdText);
			}
			ReportsDataSet.PrescriptionsDataTable dtPrescriptions = new ReportsDataSet.PrescriptionsDataTable();
			int[] rowIndexes ={ 0, 0, 0, 0 };
			foreach (DataRow dr in dataTable.Rows)
			{
				int pt = GetColumnIndex((PrescriptionTypeId)dr["PrescriptionTypeId"]);
				if (pt < 1 || pt > 3) continue;
				int startCol = (pt - 1) * 3;
				int rowIndex = rowIndexes[pt];
				rowIndexes[pt]++;
				ReportsDataSet.PrescriptionsRow row = GetRow(dtPrescriptions, rowIndex);
				row[startCol] = string.Format("{0:dd.MM}",dr["StartDate"]);
				row[startCol + 1] = string.Format("{0:dd.MM}",dr["EndDate"]);
				row[startCol + 2] = string.Format("{0} {1}{2}x{3}ð", dr["ProductName"], dr["Dose"], dr["BaseUnitName"], dr["Multiplicity"]);
			}
			AppendAnalyses(factory, patientId, dtPrescriptions, rowIndexes[rowIndexes.Length - 1]);
			return dtPrescriptions;
		}

		private static int GetColumnIndex(PrescriptionTypeId prescriptionTypeId)
		{
			switch (prescriptionTypeId)
			{ 
				case PrescriptionTypeId.IntramuscularInjection:
				case PrescriptionTypeId.HypodermicInjection:
					return 1;
				case PrescriptionTypeId.Inner:
					return 2;
				case PrescriptionTypeId.Outer:
					return 3;
			}
			return 0;
		}

		private static ReportsDataSet.PrescriptionsRow GetRow(ReportsDataSet.PrescriptionsDataTable dtPrescriptions, int rowIndex)
		{
			ReportsDataSet.PrescriptionsRow row;
			if (dtPrescriptions.Rows.Count <= rowIndex)
			{
				row = dtPrescriptions.NewPrescriptionsRow();
				dtPrescriptions.AddPrescriptionsRow(row);
			}
			else row = dtPrescriptions[rowIndex];
			return row;
		}

        public static void AppendAnalyses(ConnectionFactory factory, int patientId, ReportsDataSet.PrescriptionsDataTable dtPrescriptions, int rowIndex)
		{
			string cmdText="select AnalysisTypes.Name from Analyses left join AnalysisTypes on AnalysisTypes.Id=AnalysisTypeId where PatientId="+patientId;
			List<string> list=new List<string>();
			using (GmConnection conn = factory.CreateConnection())
			{
				using(DbDataReader dr=conn.ExecuteReader(cmdText))
				{
					while (dr.Read())
					{
						list.Add(dr.GetString(0));
					}
				}
			}
			foreach (string s in list)
			{
				ReportsDataSet.PrescriptionsRow row = GetRow(dtPrescriptions, rowIndex++);
				row.External = s;
			}
		}
	}
}
