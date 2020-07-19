using System;
using System.Data.Common;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment.Reports
{
	public class TemperatureCardReportBuilder : BaseReportBuilder
	{
		const int period = 14;
		Patient patient;
		int startDay;
		DateTime startDate;
		DateTime endDate;
        public TemperatureCardReportBuilder(ConnectionFactory factory, Config config, Patient patient, int cardIndex)
			: base(ReportBuilderId.TemperatureCard)
		{
			this.patient = patient;
			startDay = period * cardIndex+1;
			startDate=patient.admissionDate.Date+TimeSpan.FromDays(period*cardIndex);
			endDate=startDate+TimeSpan.FromDays(period);
			using (GmConnection conn = factory.CreateConnection())
			{
				AddParameter("PatientName", patient.GetPatientName(conn));
				AddParameter("WardNumber", patient.GetWardNumber(conn));
				//				AddParameter("DoctorName", patient.GetDoctorName(conn));
//				AddParameter("ChiefName", patient.GetChiefName(conn));
//				AddParameter("Analyses", patient.GetAnalysesList(conn));
			}
			AddDataSource("ReportsDataSet_TemperatureCard", GetTemperatureCardTable(factory, config));
			AddParameter("CardNumber", cardIndex+1);
			AddParameter("StartDay", startDay);
			string s = "Номер истории болезни: " + patient.patientData["CaseHistoryNumber"];

			AddParameter("FooterText", s);
			for (int i = 1; i <= period; i++)
			{
				DateTime dt=startDate + TimeSpan.FromDays(i-1);
				AddParameter("Date" + i, dt.ToString("dd.MM"));
			}
		}

        ReportsDataSet.TemperatureCardDataTable GetTemperatureCardTable(ConnectionFactory factory, Config config)
		{
			// aux data
			Dictionary<DateTime, ObservationData> dict = ObservationsReportBuilder.GetObservationData(factory, patient.Id, ObservationTypeId.TemperatureCard, startDate, endDate);

			// data
			ReportsDataSet.TemperatureCardDataTable dtTemperatureCard = new ReportsDataSet.TemperatureCardDataTable();
			foreach (KeyValuePair<DateTime, ObservationData> pair in dict)
			{
				DateTime dt=pair.Key;
				TimeSpan ts=dt-startDate;
				decimal timeIndex=(decimal)(ts.TotalDays);//+ts.Hours/24.0);
				AddRow(dtTemperatureCard, timeIndex, pair.Value["Temperature"]);
			}
			return dtTemperatureCard;
		}

		private void AddRow(ReportsDataSet.TemperatureCardDataTable dtTemperatureCard, decimal timeIndex, string temperatureStr)
		{
			decimal temperature = decimal.Parse(temperatureStr);
			ReportsDataSet.TemperatureCardRow row = dtTemperatureCard.NewTemperatureCardRow();
			row.Temperature = temperature;
			row.Time = timeIndex;
			dtTemperatureCard.AddTemperatureCardRow(row);
		}
	}
}
