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
	public class DischargeData : HandbooksInfo
	{
		#region Construction
		public static DischargeData Create(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new DischargeData();
			return (DischargeData)XmlUtils.DeserializeString(typeof(DischargeData), xmlString);
		}
		public DischargeData()
		{
		}
		#endregion
	}
}