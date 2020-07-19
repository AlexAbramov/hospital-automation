using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class ConsultationData: HandbooksInfo
	{
		public ConsultationData(){}
		public static ConsultationData Create(string xmlText)
		{
			if (xmlText == null || xmlText.Length == 0) return new ConsultationData();
			return (ConsultationData)XmlUtils.Deserialize(typeof(ConsultationData), xmlText);
		}
	}

	public class PatientConsultation
	{
		#region Fields
		int id=0;
		public int patientId=0;
		public DateTime requestDate = DateTime.Now;
		public DateTime executionDate = DateTime.MinValue;
		public ConsultationData consultationData=new ConsultationData();
		#endregion

		#region Properties
		public int Id { get { return id; } }
		#endregion

		#region Construction
		public static PatientConsultation GetPatientConsultation(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from PatientConsultations where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new PatientConsultation(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from PatientConsultations where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public PatientConsultation(int patientId)
		{
			this.patientId = patientId;
		}
		public PatientConsultation(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
			int i = 0;
			id = dr.GetInt32(i++);
			patientId = dr.GetInt32(i++);
			requestDate = dr.GetDateTime(i++);
			executionDate = gr.GetDateTime(i++);
			consultationData = ConsultationData.Create(gr.GetString(i++));
		}
		#endregion

		#region Serialization
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("PatientId", patientId);
			cmd.AddDateTime("RequestDate", requestDate);
			cmd.AddNullableDateTime("ExecutionDate", executionDate);
			cmd.AddString("ConsultationData", consultationData.GetXmlString());
			if (id == 0)
			{
				cmd.CommandText = "insert into PatientConsultations values (@PatientId,@RequestDate,@ExecutionDate,@ConsultationData) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update PatientConsultations set PatientId=@PatientId,RequestDate=@RequestDate,ExecutionDate=@ExecutionDate,ConsultationData=@ConsultationData where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		#endregion
	}
}