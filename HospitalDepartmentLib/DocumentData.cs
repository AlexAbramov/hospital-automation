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
	public class DocumentData: HandbooksInfo
	{
		[XmlAttribute]
		public string XMLPatients { get { return XmlUtils.ToString(patients); } set { XmlUtils.FromString(patients, value); } }
		[XmlAttribute]
		public string XMLPrescriptionTypes { get { return XmlUtils.ToString(prescriptionTypes); } set { XmlUtils.FromString(prescriptionTypes,value); } }
		[XmlIgnore]
		public List<int> patients = new List<int>();
		[XmlIgnore]
		public List<int> prescriptionTypes = new List<int>();
		#region Construction
		public static DocumentData Create(string xmlText)
		{
            if (xmlText == null || xmlText.Length == 0) return new DocumentData();
            return (DocumentData)XmlUtils.Deserialize(typeof(DocumentData), xmlText);
		}
        public DocumentData()
		{
		}
		#endregion

        public bool HasPrescriptionType(int prescriptionTypeId)
        {
            return prescriptionTypes.Contains(prescriptionTypeId);
        }
    }
}