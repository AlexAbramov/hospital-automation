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
	public class ExpertBoardData : HandbooksInfo
	{
		public DiagnosisInfo diagnosisInfo = DiagnosisInfo.Empty;
		#region Construction
		public static ExpertBoardData DeserializeString(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new ExpertBoardData();
			return (ExpertBoardData)XmlUtils.DeserializeString(typeof(ExpertBoardData), xmlString);
		}
		public ExpertBoardData()
		{
		}
		#endregion
	}
}