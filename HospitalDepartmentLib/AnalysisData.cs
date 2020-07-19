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
		public static AnalysisData Create(string xmlText)
		{
			if (xmlText == null || xmlText.Length == 0) return new AnalysisData();
			return (AnalysisData)XmlUtils.Deserialize(typeof(AnalysisData), xmlText);
		}
	}
}