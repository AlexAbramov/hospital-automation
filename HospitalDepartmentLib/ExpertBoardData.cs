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
		public static ExpertBoardData Create(string xmlText)
		{
			if (xmlText == null || xmlText.Length == 0) return new ExpertBoardData();
			return (ExpertBoardData)XmlUtils.Deserialize(typeof(ExpertBoardData), xmlText);
		}
		public ExpertBoardData()
		{
		}
		#endregion
	}
}