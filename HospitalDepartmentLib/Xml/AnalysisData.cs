using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class AnalysisData: HandbooksInfo
	{
		public AnalysisData(){}
		public static AnalysisData DeserializeString(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new AnalysisData();
			return (AnalysisData)XmlUtils.DeserializeString(typeof(AnalysisData), xmlString);
		}
	}
}