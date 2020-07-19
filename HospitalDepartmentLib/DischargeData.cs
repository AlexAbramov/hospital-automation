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
		public static DischargeData Create(string xmlText)
		{
			if (xmlText == null || xmlText.Length == 0) return new DischargeData();
			return (DischargeData)XmlUtils.Deserialize(typeof(DischargeData), xmlText);
		}
		public DischargeData()
		{
		}
		#endregion
	}
}