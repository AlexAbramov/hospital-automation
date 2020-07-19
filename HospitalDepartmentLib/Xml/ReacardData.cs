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
	public class ReacardData : HandbooksInfo
	{
		#region Construction
		public static ReacardData DeserializeString(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new ReacardData();
			return (ReacardData)XmlUtils.DeserializeString(typeof(ReacardData), xmlString);
		}
		public ReacardData()
		{
		}
		#endregion
	}
}