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
	public class WatchingSchemeData
	{
		[XmlAttribute]
		public string XMLWards { get { return XmlUtils.ToString(wards); } set { XmlUtils.FromString(wards, value); } }
		[XmlIgnore]
		public List<int> wards = new List<int>();
		#region Construction
		public static WatchingSchemeData DeserializeString(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new WatchingSchemeData();
			return (WatchingSchemeData)XmlUtils.DeserializeString(typeof(WatchingSchemeData), xmlString);
		}
		public string GetXmlString()
		{
			return XmlUtils.Serialize(this);
		}
		public WatchingSchemeData()
		{
		}
		#endregion
	}
}