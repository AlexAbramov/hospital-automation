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
	public class ObservationData : HandbooksInfo
	{
		#region Construction
		public static ObservationData Create(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new ObservationData();
			return (ObservationData)XmlUtils.DeserializeString(typeof(ObservationData), xmlString);
		}
		public ObservationData()
		{
		}
		#endregion
	}
}