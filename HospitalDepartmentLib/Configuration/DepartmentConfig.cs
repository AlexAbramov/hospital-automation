using System;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;

namespace HospitalDepartment
{
	public class DepartmentConfig: ICloneable
	{
		#region Fields
		public HospitalType hospitalType = HospitalType.First;
		public string hospitalName = "";
        public string headDoctor = "";
		public string departmentName = "";
        public string iconName = "";
        public int taskGenPeriod = 15;// min
        public int commonObservationStartHour = 15;// Время заполнения дневников
        public int commonObservationPeriod = 24;// hours
        public int intensiveCareObservationStartHour = 2;
        public int intensiveCareObservationPeriod = 4;// 2, 6, 10, 14, 18, 22
        public int reanimationObservationStartHour = 0;
        public int reanimationObservationPeriod = 2;// 2, 4, 6 ...
        public int temperatureObservationStartHour = 6;// hours
        public int temperatureObservationPeriod = 12;// hours 6, 18
        public int intensiveCareMaxDuration = 9;// days 
        public int reanimationMaxDuration = 9;// days
        public int clinicDiagnosisDays = 3;// days 
        public int doctorRoundHour = 11;//
        public int doctorRoundPeriod = 10;// days
        public int chiefRoundHour = 11;// 
        public int chiefRoundPeriod = 7;// days
        public string defaultDiet = "";
        public int recommendedHospitalStayPercent = 80;
		[XmlIgnore]
		List<string> diets = new List<string>();
		#endregion

		#region Properties
		public string DietsList
		{
			get
			{
				diets.Sort();
				StringBuilder sb = new StringBuilder();
				foreach (string s in diets)
				{
					if (sb.Length != 0) sb.Append(";");
					sb.Append(s);
				}
				return sb.ToString();
			}
			set
			{
				diets.AddRange(value.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
			}
		}
		[XmlIgnore]
		public List<string> Diets { get { return diets; } }
		#endregion

		public DepartmentConfig() {}

		#region ICloneable Members

		public object Clone()
		{
			DepartmentConfig config = (DepartmentConfig)this.MemberwiseClone();
			return config;
		}

		#endregion

        #region Methods
        public DateTime GetNextObservationTime(ObservationTypeId observationTypeId, PatientTypeId patientTypeId, DateTime prevTime, bool firstObservation)
        {
            DateTime prevDate = prevTime.Date;
            int prevHour=prevTime.Hour;
            switch (observationTypeId)
            {
                case ObservationTypeId.Diary:
                    {
                        int nextHour = GetNextObservationHour(patientTypeId, prevHour);
                        return prevDate + TimeSpan.FromHours(nextHour);
                    }
                case ObservationTypeId.TemperatureCard:
                    {
                        if (firstObservation) return prevDate;
                        int nextHour = GetNextObservationHour(prevHour, temperatureObservationStartHour, temperatureObservationPeriod);
                        return prevDate + TimeSpan.FromHours(nextHour);
                    }
                case ObservationTypeId.ChiefRound:
                    /*							int curDay = (int)dt.DayOfWeek;
                                                int targetDay = App.DepartmentConfig.chiefRoundDay;
                                                int dif=targetDay-curDay;
                                                if(dif<=0) dif+=7;*/
                    return prevDate + TimeSpan.FromDays(chiefRoundPeriod) + TimeSpan.FromHours(chiefRoundHour);
                case ObservationTypeId.DoctorRound:
                    return prevDate + TimeSpan.FromDays(doctorRoundPeriod)+TimeSpan.FromHours(doctorRoundHour);
                default:
                    throw new HospitalDepartmentException("Non supported ObservationTypeId: " + observationTypeId);
            }
        }
        int GetNextObservationHour(PatientTypeId patientTypeId, int prevHour)
        {
            switch (patientTypeId)
            {
                case PatientTypeId.Common: return GetNextObservationHour(prevHour,commonObservationStartHour,commonObservationPeriod);
                case PatientTypeId.IntensiveCare: return GetNextObservationHour(prevHour,intensiveCareObservationStartHour,intensiveCareObservationPeriod);
                case PatientTypeId.Reanimation: return GetNextObservationHour(prevHour,reanimationObservationStartHour,reanimationObservationPeriod);
            }
            return 0;
        }

        int GetNextObservationHour(int prevHour, int startHour, int interval)
        {
            System.Diagnostics.Debug.Assert(interval>0);
            if (prevHour < startHour) return startHour;
            int hour = startHour;
            while(hour < 24 && hour <= prevHour) hour += interval;
            return hour<24 ? hour : 24+startHour;
        }
        #endregion

        public int GetRecommendedHospitalStay(Diagnosis d)
        {
		    int hospitalStayDuration = d.GetHospitalStayDuration(hospitalType);
            return (int)Math.Ceiling(hospitalStayDuration * recommendedHospitalStayPercent /100.0);
        }
    }
}
