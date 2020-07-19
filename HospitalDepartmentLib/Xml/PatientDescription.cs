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
	[XmlRootAttribute]
	public class PatientDescription : HandbooksInfo
	{
		#region Construction
		public static PatientDescription Create(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new PatientDescription();
			return (PatientDescription)XmlUtils.DeserializeString(typeof(PatientDescription), xmlString);
		}
		public PatientDescription()
		{
		}
		#endregion
	}
}