using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;
using Geomethod;
using System.IO;
using System.Xml.Serialization;

namespace HospitalDepartment
{
	public class Observation
	{
		#region Fields
		int id = 0;
		public int patientId=0;
		public int doctorId=0;
		public DateTime time=DateTime.Now;
		public ObservationData description = new ObservationData();
		public ObservationTypeId observationTypeId = ObservationTypeId.Diary;
		#endregion

		#region Properties
		public int Id { get { return id;} }
		#endregion 

		#region Construction
		public Observation()
		{
		}
        public Observation(ObservationTypeId observationTypeId)
        {
            this.observationTypeId = observationTypeId;
        }
        public Observation(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
			id = gr.GetInt32();
			patientId = gr.GetInt32();
			doctorId = gr.GetInt32();
			time = gr.GetDateTime();
			description = ObservationData.Create(gr.GetString());
			observationTypeId = (ObservationTypeId)gr.GetInt32();
		}
		public static Observation GetObservation(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Observations where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Observation(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Observations where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		#endregion

		#region Serialization
		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("PatientId", patientId);
			cmd.AddInt("DoctorId", doctorId);
			cmd.AddDateTime("Time", time);
			cmd.AddString("Description", description.GetXmlString());
			cmd.AddInt("ObservationTypeId", (int)observationTypeId);
			
			if (id == 0)
			{
				cmd.CommandText = "insert into Observations values (@PatientId,@DoctorId,@Time,@Description,@ObservationTypeId) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Observations set PatientId=@PatientId,DoctorId=@DoctorId,Time=@Time,Description=@Description,ObservationTypeId=@ObservationTypeId where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
		#endregion

        public static HandbookGroupId GetHandbookGroupId(ObservationTypeId observationTypeId)
        {
            switch (observationTypeId)
            {
                case ObservationTypeId.Diary: return HandbookGroupId.Observation;
                case ObservationTypeId.DoctorRound: return HandbookGroupId.DoctorRound;
                case ObservationTypeId.ChiefRound: return HandbookGroupId.ChiefRound;
                case ObservationTypeId.TemperatureCard: return HandbookGroupId.TemperatureCard;
                default: throw new HospitalDepartmentException("Unsupported argument in GetHandbookGroupId: " + observationTypeId.ToString());
            }
        }
    }
}