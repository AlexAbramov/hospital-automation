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
		public static IdentificationData Create(string xmlText)
		{
			if (xmlText == null || xmlText.Length == 0) return new IdentificationData();
			return (IdentificationData)XmlUtils.Deserialize(typeof(IdentificationData), xmlText);
		}
		public IdentificationData()
		{
		}
		#endregion
	}
}