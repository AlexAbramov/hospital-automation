using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;
using Geomethod;
using System.IO;
using System.Xml.Serialization;

namespace HospitalDepartment
{
	[XmlRootAttribute]
	public class PatientData: HandbooksInfo
	{
		public DateTime sickListStartDate = DateTime.Now;
		public DateTime descriptionTime = DateTime.Now;

		#region Construction
		public static PatientData Create(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new PatientData();
			return (PatientData)XmlUtils.DeserializeString(typeof(PatientData), xmlString);
		}
		public PatientData()
		{
		}
		#endregion
	}
}