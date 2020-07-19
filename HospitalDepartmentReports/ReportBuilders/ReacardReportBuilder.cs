using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class ReacardReportBuilder : BaseReportBuilder
	{
		Patient patient;
		Reacard reacard;
        public ReacardReportBuilder(ConnectionFactory factory, Config config, Patient patient, Reacard reacard)
			: base(ReportBuilderId.Prescriptions)
		{
			this.patient = patient;
			this.reacard = reacard;
			AddDataSource("ReportsDataSet_ReacardDescriptions", GetReacardDescriptionsTable(factory));
			AddDataSource("ReportsDataSet_ReacardPrescriptions", GetReacardPrescriptionsTable(factory));
            Analysis analysis = null;
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("Age", patient.GetAgeStr(conn));
				AddParameter("PatientName", patient.GetPatientName(conn));
				GenderId gid=patient.GetGender(conn);
				AddParameter("Gender", GenderUtils.GetGender(gid));
                analysis = Analysis.GetLastAnalysis(conn,patient.Id, "BloodGroupAndRhesusFactor");
            }
			AddHandbooksInfo(patient.patientData, config[HandbookGroupId.PatientData]);
			AddHandbooksInfo(reacard.reacardData, config[HandbookGroupId.ReacardData]);
			AddParameter("Diet", patient.dietNumber);
            try
            {

                int output = GetReacardDataInt("Diuresis") + GetReacardDataInt("Stool");
                int balance = GetReacardDataInt("Input") + GetReacardDataInt("DrankWater") - output;
                AddParameter("Output", output.ToString());
                AddParameter("Balance", balance.ToString());
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }

            if (analysis != null)
            {
                AddParameter("BloodGroup", analysis.analysisData);
                AddParameter("RhesusFactor", analysis.analysisData);
            }
            else
            {
                AddParameter("BloodGroup", "");
                AddParameter("RhesusFactor", "");
            }
		}

        private int GetReacardDataInt(string name)
        {
            try
            {
                string val=reacard.reacardData[name];
                if (String.IsNullOrEmpty(val)) return 0;
                return int.Parse(val);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
            return 0;
        }

        public ReportsDataSet.ReacardDescriptionsDataTable GetReacardDescriptionsTable(ConnectionFactory factory)
		{
			// aux data
			DateTime startTime = reacard.date.Date + TimeSpan.FromHours(10);
			DateTime endTime = startTime+TimeSpan.FromHours(24);
			Dictionary<DateTime, ObservationData> dict0 = ObservationsReportBuilder.GetObservationData(factory, patient.Id, ObservationTypeId.Diary, startTime, endTime);
			Dictionary<int, ObservationData> dict = new Dictionary<int, ObservationData>();
			foreach(KeyValuePair<DateTime,ObservationData> pair in dict0)
			{
				TimeSpan ts=pair.Key-startTime;
				int col=((int)ts.TotalHours)/2+1;
				if(col>0&&col<=12)
				{
				  if (!dict.ContainsKey(col)) dict.Add(col, pair.Value);
				}
			}

			// data
			ReportsDataSet.ReacardDescriptionsDataTable dtReacardDescriptions = new ReportsDataSet.ReacardDescriptionsDataTable();
			CreateRow(dtReacardDescriptions,"");
			CreateRow(dtReacardDescriptions,"ÀÄ");
			CreateRow(dtReacardDescriptions,"Ïóëüñ");
			CreateRow(dtReacardDescriptions,"×ÑÑ");
			CreateRow(dtReacardDescriptions,"×ÄÄ");
			CreateRow(dtReacardDescriptions,"ÖÂÄ");
			CreateRow(dtReacardDescriptions,"Òåìïåðàòóðà");

			foreach(KeyValuePair<int,ObservationData> pair in dict)
			{
				int col=pair.Key;
				ObservationData od=pair.Value;
				int row=1;
				dtReacardDescriptions[row++][col]=od["SystolicBloodPressure"]+"/"+od["DiastolicBloodPressure"];
				dtReacardDescriptions[row++][col]=od["Pulse"];
				dtReacardDescriptions[row++][col]=od["HeartRate"];
				dtReacardDescriptions[row++][col]=od["RespiratoryRate"];
                dtReacardDescriptions[row++][col]=od["ÑentralVenousPressure"];
				dtReacardDescriptions[row++][col]=od["Temperature"];
			}
			return dtReacardDescriptions;
		}

		private DataRow CreateRow(ReportsDataSet.ReacardDescriptionsDataTable dtReacardDescriptions, string name)
		{
			DataRow dr=dtReacardDescriptions.NewRow();
			dr[0] = name;
			dtReacardDescriptions.Rows.Add(dr);
			return dr;
		}

        public ReportsDataSet.ReacardPrescriptionsDataTable GetReacardPrescriptionsTable(ConnectionFactory factory)
		{
			DataTable dataTable = new DataTable();
			string cmdText = @"select Prescriptions.*, Products.Name as ProductName, BaseUnits.Name as BaseUnitName, UnitCount, PrescriptionTypes.ShortName
from Prescriptions 
left join StoreProducts on StoreProducts.Id=StoreProductId
left join Products on Products.Id=ProductId
left join BaseUnits on BaseUnits.Id=BaseUnitId
left join PrescriptionTypes on PrescriptionTypes.Id=PrescriptionTypeId
where PatientId=@PatientId 
and StartDate<@EndTime
and EndDate>@StartTime
and ReanimationFlag=1
order by PrescriptionTypeId, StartDate";
//and PrescriptionTypeId=@PrescriptionTypeId
			DateTime startTime = reacard.date.Date + TimeSpan.FromHours(9);
			DateTime endTime = startTime + TimeSpan.FromHours(24);
			using (GmConnection conn = factory.CreateConnection())
			{
				GmCommand cmd = conn.CreateCommand(cmdText);
				cmd.AddInt("PatientId", patient.Id);
				cmd.AddDateTime("StartTime", startTime);
				cmd.AddDateTime("EndTime", endTime);
//				cmd.AddInt("PrescriptionTypeId", PrescriptionTypeId.IntravenousInjection);				
				conn.Fill(dataTable, cmd);
			}
			ReportsDataSet.ReacardPrescriptionsDataTable dtReacardPrescriptions = new ReportsDataSet.ReacardPrescriptionsDataTable();
			foreach (DataRow dr in dataTable.Rows)
			{
				string productName = string.Format("{0} {1}{2} {3}", dr["ProductName"], dr["UnitCount"], dr["BaseUnitName"], dr["ShortName"]);
				DateTime startDate = (DateTime)dr["StartDate"];
				DateTime endDate = (DateTime)dr["EndDate"];
				CreateRow(dtReacardPrescriptions, productName, startDate, endDate, reacard.date);
			}
			return dtReacardPrescriptions;
		}

		private DataRow CreateRow(ReportsDataSet.ReacardPrescriptionsDataTable dtReacardPrescriptions, string productName, DateTime startDate, DateTime endDate, DateTime dateTime)
		{
			DataRow dr=dtReacardPrescriptions.NewRow();
			dr[0] = productName;
			bool first = true;
			for (int col = 1; col <= 24; col++)
			{ 
				DateTime dt=reacard.date.Date+TimeSpan.FromHours(col+8);
				if (startDate <= dt && dt < endDate)
				{
					if (first)
					{
						TimeSpan ts = dt - startDate;
						first = ts.TotalHours<1;
					}
					dr[col] = first ? "+" : ">";
					if (first) first = false;
				}
			}
			dtReacardPrescriptions.Rows.Add(dr);
			return dr;
		}
	}
}
