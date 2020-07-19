using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment
{
	public class PatientIdentification
	{
		int id=0;
		public string surname = "";
		public string name = "";
		public string middleName = "";
		public GenderId gender = GenderId.Null;
		public DateTime birthday = DateTime.MinValue;
		public IdentificationData identificationData = new IdentificationData();

		public int Id { get { return id; } }
		public string PatientName { get { return surname + " " + name + " " + middleName; } }
		public string Registration { get { return identificationData["Registration"]; } }
//		public int Age { get { return birthday != DateTime.MinValue ? DateTimeUtils.Age(birthday) : -1; } }

		#region Construction
		public static PatientIdentification GetPatientIdentification(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from PatientIdentifications where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new PatientIdentification(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from PatientIdentifications where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public PatientIdentification()
		{
		}
		public PatientIdentification(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
			id = gr.GetInt32();
			surname = gr.GetString();
			name = gr.GetString();
			middleName = gr.GetString();
			gender = (GenderId)gr.GetInt();
			birthday = gr.GetDateTime();
			identificationData = IdentificationData.Create(gr.GetString());
		}
		#endregion

		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("Surname", surname);
			cmd.AddString("Name", name);
			cmd.AddString("MiddleName", middleName);
			cmd.AddInt("Gender", (int)gender);
			cmd.AddNullableDateTime("Birthday", birthday);
			cmd.AddString("IdentificationData", identificationData.GetXmlString());
			if (id == 0)
			{
				cmd.CommandText = "insert into PatientIdentifications values (@Surname,@Name,@MiddleName,@Gender,@Birthday,@IdentificationData) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				cmd.CommandText = "update PatientIdentifications set Surname=@Surname,Name=@Name,MiddleName=@MiddleName,Gender=@Gender,Birthday=@Birthday,IdentificationData=@IdentificationData where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
	}
}