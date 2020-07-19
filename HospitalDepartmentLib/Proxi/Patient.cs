using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;
using System.IO;
using System.Xml.Serialization;
using Geomethod;

namespace HospitalDepartment
{
	public class Patient
	{
		#region Fields
		int id = 0;
		public int passportId = 0;
		public int insuranceId = 0;
		public int patientIdentificationId = 0;
		public int doctorId = 0;
		public int diagnosisId = 0;
		public PatientData patientData;
		public PatientDescription patientDescription;
		public DateTime admissionDate = DateTime.Now;
		public int wardId = 0;
		public PatientTypeId patientTypeId = PatientTypeId.Common;
		public DischargeTypeId dischargeTypeId = DischargeTypeId.None;
		public DischargeData dischargeData;
		public DateTime dischargeDate=DateTime.MinValue;
		public PatientDiagnoses patientDiagnoses;
		public string dietNumber="";
        public Status status = Status.Normal;
		#endregion

		#region Properties
		public int Id { get { return id; } }
		public DiagnosisInfo LatestDiagnosisInfo { get { return patientDiagnoses.LatestDiagnosisInfo; } }
		public bool IsDischarged { get { return dischargeDate != DateTime.MinValue; } }
        public int Duration { get { DateTime dt= IsDischarged?dischargeDate:DateTime.Today; TimeSpan ts=dt-admissionDate; return ts.Days;} }
        public string DischargeDateStr { get { return IsDischarged ? DateTimeUtils.ToString(dischargeDate, "dd.MM.yy") : ""; } }        
		#endregion

		#region Static
		public static Patient GetPatient(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Patients where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Patient(dr);
			}
			return null;
		}
		public static int SetStatus(GmConnection conn, int id, Status status)
		{
			GmCommand cmd = conn.CreateCommand("update Patients set Status=@Status where Id=@Id");
            cmd.AddInt("Id", id);
            cmd.AddInt("Status", (int)status);
            return cmd.ExecuteNonQuery();
		}
        public static List<Patient> GetPatients(GmConnection conn, string sqlCond)
        {
            List<Patient> patients = new List<Patient>();
            using (DbDataReader dr = conn.ExecuteReader("select * from Patients where "+sqlCond))
            {
                while (dr.Read()) patients.Add( new Patient(dr));
            }
            return patients;
        }
		public static string GetTreatment(GmConnection conn, int patientId)
		{
/*			string cmdText = @"select Medicaments.Name from Prescriptions 
left join StoreProducts on StoreProducts.Id=StoreProductId
left join Products on Products.Id=ProductId
left join Medicaments on Medicaments.Id=MedicamentId
where PatientId=@PatientId";*/
			string cmdText = @"select MedicamentGroups.Name from Prescriptions 
left join StoreProducts on StoreProducts.Id=StoreProductId
left join Products on Products.Id=ProductId
left join MedicamentGroupTies on MedicamentGroupTies.MedicamentId=Products.MedicamentId
left join MedicamentGroups on MedicamentGroups.Id=MedicamentGroupId
where PatientId=@PatientId";
			GmCommand cmd = conn.CreateCommand(cmdText);
			cmd.AddInt("PatientId", patientId);
			List<string> list = new List<string>();
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				while (dr.Read())
				{
					string s = dr.GetString(0);
					if (!list.Contains(s)) list.Add(s);
				}
			}
			list.Sort();
			return Geomethod.CollectionUtils.GetCommaSeparatedList<string>(list);
		}
        #endregion

		#region Construction
		public Patient() : this(0) { }
		public Patient(int id)
		{
			this.id = id;
			admissionDate = DateTime.Now;
			patientData = new PatientData();
			patientDescription = new PatientDescription();
			dischargeData = new DischargeData();
			patientDiagnoses = new PatientDiagnoses();
		}
		public Patient(DbDataReader dr)
		{
			GmDataReader gr=new GmDataReader(dr);
			id = gr.GetInt32();
			passportId = gr.GetInt32();
			insuranceId = gr.GetInt32();
			patientIdentificationId = gr.GetInt32();
			doctorId = gr.GetInt32();
			diagnosisId = gr.GetInt32();
			patientData = PatientData.Create(gr.GetString());
			patientDescription = PatientDescription.Create(gr.GetString());
			admissionDate = gr.GetDateTime();
			wardId = gr.GetInt32();
			patientTypeId = (PatientTypeId)gr.GetInt32();
			dischargeTypeId = (DischargeTypeId)gr.GetInt32();
			dischargeData = DischargeData.Create(gr.GetString());
			dischargeDate = gr.GetDateTime();
			patientDiagnoses = PatientDiagnoses.Create(gr.GetString());
			dietNumber = gr.GetString();
            status = (Status)gr.GetInt32();
        }
		#endregion

		#region Serialization
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("PassportId", passportId);
			cmd.AddInt("InsuranceId", insuranceId);
			cmd.AddInt("PatientIdentificationId", patientIdentificationId);
			cmd.AddInt("DoctorId", doctorId);
			cmd.AddInt("DiagnosisId", diagnosisId);
			cmd.AddString("PatientData", patientData.GetXmlString());
			cmd.AddString("PatientDescription", patientDescription.GetXmlString());
			cmd.AddDateTime("AdmissionDate", admissionDate);
			cmd.AddInt("WardId", wardId);
			cmd.AddInt("PatientTypeId", (int)patientTypeId);
			cmd.AddString("PatientDiagnoses", patientDiagnoses.GetXmlString());
			cmd.AddString("DietNumber", dietNumber);
            cmd.AddInt("Status", (int)status);
            if (id == 0)
			{
				cmd.CommandText = "insert into Patients values (@PassportId,@InsuranceId,@PatientIdentificationId,@DoctorId,@DiagnosisId,@PatientData,@PatientDescription,@AdmissionDate,@WardId,@PatientTypeId,0,null,null,@PatientDiagnoses,@DietNumber, @Status) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = @"update Patients set PassportId=@PassportId,InsuranceId=@InsuranceId,PatientIdentificationId=@PatientIdentificationId,DoctorId=@DoctorId,DiagnosisId=@DiagnosisId,PatientData=@PatientData,PatientDescription=@PatientDescription,AdmissionDate=@AdmissionDate,WardId=@WardId,PatientTypeId=@PatientTypeId,PatientDiagnoses=@PatientDiagnoses,DietNumber=@DietNumber, Status=@Status where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}

		public int SaveWardHistory(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("PatientId", id);
			cmd.AddDateTime("Date", DateTime.Now);
			cmd.AddInt("WardId", wardId);
            cmd.AddInt("PatientTypeId", (int)patientTypeId);
            cmd.CommandText = "insert into PatientWardHistory values (@PatientId,@Date,@WardId,@PatientTypeId) select @@Identity";
			return (int)(decimal)cmd.ExecuteScalar();
		}

		public void SaveDischargeData(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("DischargeTypeId", (int)dischargeTypeId);
			cmd.AddString("DischargeData", dischargeData.GetXmlString());
			cmd.AddNullableDateTime("DischargeDate", dischargeDate);
			if (id == 0)
			{
				cmd.CommandText = "insert into Patients values (DischargeTypeId,@DischargeData,@DischargeDate) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = @"update Patients set DischargeTypeId=@DischargeTypeId,DischargeData=@DischargeData,DischargeDate=@DischargeDate where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		#endregion

		#region Aux
		public string GetTreatment(GmConnection conn)
		{
			return Patient.GetTreatment(conn, id);
		}
		public string GetWardNumber(GmConnection conn)
		{
			object obj = conn.ExecuteScalar("select Number from Wards where Id=" + wardId);
			return obj is string ? obj.ToString() : "";
		}
		public Passport GetPassport(GmConnection conn)
		{
			return Passport.GetPassport(conn, passportId);
		}
		public Insurance GetInsurance(GmConnection conn)
		{
			return Insurance.GetInsurance(conn, insuranceId);
		}
		public PatientIdentification GetPatientIdentification(GmConnection conn)
		{
			return PatientIdentification.GetPatientIdentification(conn, patientIdentificationId);
		}
		public string GetDoctorName(GmConnection conn)
		{
			return User.GetUserNameById(conn, doctorId);
		}
		public string GetChiefName(GmConnection conn)
		{
			return User.GetChiefName(conn);
		}
		public string GetPatientName(GmConnection conn)
		{
			Passport passport = GetPassport(conn);
			if (passport != null) return passport.PatientName;
			PatientIdentification pi = GetPatientIdentification(conn);
			if (pi != null) return pi.PatientName;
			return "Пациент №" + id;
		}
		public string GetAddress(GmConnection conn)
		{
			Passport passport = GetPassport(conn);
			if (passport != null) return passport.registration;
			PatientIdentification pi = GetPatientIdentification(conn);
			if (pi != null) return pi.Registration;
			return "";
		}
		public GenderId GetGender(GmConnection conn)
		{
			Passport passport = GetPassport(conn);
			if (passport != null) return passport.gender;
			PatientIdentification pi = GetPatientIdentification(conn);
			if (pi != null) return pi.gender;
			return GenderId.Null;
		}
		public string GetAgeStr(GmConnection conn) { int age = GetAge(conn); return age > -1 ? age.ToString() : ""; }
		public int GetAge(GmConnection conn)
		{
			Passport passport = GetPassport(conn);
			if (passport != null) return DateTimeUtils.Age(passport.birthday, admissionDate); 
			PatientIdentification pi = GetPatientIdentification(conn);
			if (pi != null) return DateTimeUtils.Age(pi.birthday, admissionDate);
			return -1;
		}
		public string GetAnalysesList(GmConnection conn)
		{
			StringBuilder sb = new StringBuilder();
			GmCommand cmd = conn.CreateCommand(
@"select RequestDate, Name from Analyses 
left join AnalysisTypes on AnalysisTypes.Id=AnalysisTypeId
where PatientId=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				while (dr.Read())
				{
                    GmDataReader gr = new GmDataReader(dr);
                    DateTime dt =gr.GetDateTime();
					string name=gr.GetString();
					if (sb.Length > 0) sb.Append("; ");
					sb.AppendFormat("{0:dd.MM} {1}", dt, name);
				}
			}
			if (sb.Length > 0) sb.Append(".");
			return sb.ToString();
		}
		public string GetAnalysesReport(GmConnection conn, Config config)
		{
			StringBuilder sb = new StringBuilder(1000);
			GmCommand cmd = conn.CreateCommand("select Analyses.*, AnalysisTypes.Name, HandbookGroupId from Analyses left join AnalysisTypes on AnalysisTypes.Id=AnalysisTypeId where PatientId=@PatientId");
			cmd.AddInt("PatientId", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				while (dr.Read())
				{
					if(sb.Length>0) sb.AppendLine();
					Analysis analisis = new Analysis(dr);
					string name = (string)dr["Name"];
					string hgId = (string)dr["HandbookGroupId"];
					HandbookGroup hg = config.GetHandbookGroup(hgId);
					sb.AppendFormat("{0} от {1}: {2}", name, analisis.executionDate.ToShortDateString(), analisis.analysisData.GetText(hg));
				}
			}
			return sb.ToString();
		}
		public string GetExamination(GmConnection conn)
		{
			StringBuilder sb = new StringBuilder(1000);
			GmCommand cmd = conn.CreateCommand("select * from PatientConsultations where PatientId=@PatientId");
			cmd.AddInt("PatientId", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				while (dr.Read())
				{
					if (sb.Length > 0) sb.AppendLine();
					PatientConsultation pc = new PatientConsultation(dr);
					sb.AppendFormat("{0} от {1}: {2}", pc.consultationData["Consultation"], pc.executionDate.ToShortDateString(), pc.consultationData["Conclusion"]);
				}
			}
			return sb.ToString();
		}
		public string GetPatientStateDynamics(GmConnection conn)
		{
			string res="";
			GmCommand cmd = conn.CreateCommand("select top(1) * from Observations where PatientId=@PatientId and (ObservationTypeId=2 or ObservationTypeId=3) order by Time desc");
			cmd.AddInt("PatientId", id);
			Observation obs=null;
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read())
				{
					obs = new Observation(dr);					
				}
			}
			if(obs!=null)
			{
				res=obs.description["Dynamics"];
			}

			return res;
		}
		#endregion

	}
}