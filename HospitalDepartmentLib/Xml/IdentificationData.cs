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
	public class IdentificationData : HandbooksInfo
	{
		#region Construction
		public static IdentificationData Create(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new IdentificationData();
			return (IdentificationData)XmlUtils.DeserializeString(typeof(IdentificationData), xmlString);
		}
		public IdentificationData()
		{
		}
		#endregion
	}
}