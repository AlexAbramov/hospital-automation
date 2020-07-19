using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class Prescription
	{
		#region Fields
		int id;
		public int patientId;
		public PrescriptionTypeId prescriptionTypeId;
		public int storeProductId;
		public decimal dose;
		public int multiplicity;
		public DateTime startDate;
		public DateTime endDate;
        public int duration;
        public bool reanimationFlag;
		#endregion

		#region Properties
        public int Id { get { return id; } }
        #endregion

		#region Construction
        public static void GetPrescriptions(GmConnection conn, List<Prescription> prescriptions, IEnumerable<int> patients, IEnumerable<int> prescriptionTypes, DateTime startDate, DateTime endDate, bool reanimationFlag)
        {
            string cmdText = @"select * from Prescriptions 
where PatientId in ({0})
and PrescriptionTypeId in ({1})
and StartDate<@EndDate
and EndDate>@StartDate
and ReanimationFlag=@ReanimationFlag
";
            cmdText=string.Format(cmdText,CollectionUtils.GetCommaSeparatedList(patients),CollectionUtils.GetCommaSeparatedList(prescriptionTypes));
            GmCommand cmd = conn.CreateCommand(cmdText);
            cmd.AddDateTime("StartDate", startDate);
            cmd.AddDateTime("EndDate", endDate);
            cmd.AddBoolean("ReanimationFlag", reanimationFlag);
            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read()) prescriptions.Add( new Prescription(dr));
            }
        }
        public static Prescription GetPrescription(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Prescriptions where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Prescription(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Prescriptions where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public Prescription(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
			int i = 0;
			id = dr.GetInt32(i++);
            patientId = dr.GetInt32(i++);
            prescriptionTypeId = (PrescriptionTypeId)dr.GetInt32(i++);
            storeProductId = dr.GetInt32(i++);
			dose = dr.GetDecimal(i++);
            multiplicity = dr.GetInt32(i++);
			startDate = dr.GetDateTime(i++);
			endDate = dr.GetDateTime(i++);
            duration = dr.GetInt32(i++);
            reanimationFlag = dr.GetBoolean(i++);
        }
/*		public Prescription(DataRow dr)
		{
			int i = 0;
			id = (int)dr.getint[i++];
			patientId = (int)dr[i++];
			prescriptionTypeId = (PrescriptionTypeId)dr[i++];
			storeProductId = (int)dr[i++];
			dose = (decimal)dr[i++];
			multiplicity = (int)dr[i++];
			startDate = (DateTime)dr[i++];
			endDate = (DateTime)dr[i++];
            duration = (int)dr[i++];
            reanimationFlag = (bool)dr[i++];
        }*/
		#endregion

		#region Serialization
/*		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("PatientId", patientId);
			cmd.AddInt("PrescriptionTypeId", prescriptionTypeId);
			cmd.AddDateTime("RequestDate", requestDate);
			cmd.AddNullableDateTime("ExecutionDate", executionDate);
			cmd.AddString("PrescriptionData", prescriptionData.GetXmlString());
			if (id == 0)
			{
				cmd.CommandText = "insert into Prescriptions values (@PatientId,@PrescriptionTypeId,@RequestDate,@ExecutionDate,@PrescriptionData) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update Prescriptions set PatientId=@PatientId,PrescriptionTypeId=@PrescriptionTypeId,RequestDate=@RequestDate,ExecutionDate=@ExecutionDate,PrescriptionData=@PrescriptionData where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}*/
		#endregion

		#region Methods
/*		public PrescriptionType GetPrescriptionType(GmConnection conn)
		{
			return PrescriptionType.GetPrescriptionType(conn, prescriptionTypeId);
		}*/
        public decimal GetCount(DateTime startDate, int duration)
        {
            decimal res=0;
            if (multiplicity > 0)
            {
                if(reanimationFlag)
                {
                }
                else
                {
                    int ndays = GetDays(startDate, duration);
                    if (ndays > 0)
                    {
                        res = dose * ndays;
                        if (multiplicity > 1) res *= multiplicity;
                    }
                }
            }
            return res;
        }
        int GetDays(DateTime startDate, int duration)
        {
            TimeSpan ts = startDate.Date - this.startDate.Date;
            int x0 = (int)ts.TotalDays;
            int x1=x0+duration;
            int left=x0>0?x0:0;
            int right=x1<this.duration?x1:this.duration;
            return left<=right ?right-left+1 : 0;
        }
		#endregion

	}
}
