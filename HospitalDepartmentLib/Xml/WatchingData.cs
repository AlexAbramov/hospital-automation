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
	public class WatchingData
	{
//		[XmlArray("WardsArray", IsNullable = true)]
		[XmlAttribute]
		public string XMLPatients { get { return XmlUtils.ToString(patients); } set { XmlUtils.FromString(patients, value); } }
		[XmlAttribute]
		public string XMLWards { get { return XmlUtils.ToString(wards); } set { XmlUtils.FromString(wards,value); } }
		[XmlIgnore]
		public List<int> wards = new List<int>();
		[XmlIgnore]
		public List<int> patients = new List<int>();
		#region Construction
		public static WatchingData DeserializeString(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new WatchingData();
			return (WatchingData)XmlUtils.DeserializeString(typeof(WatchingData), xmlString);
		}
		public string Serialize()
		{
			return XmlUtils.Serialize(this);
		}
		public WatchingData()
		{
		}
		#endregion
	}
}