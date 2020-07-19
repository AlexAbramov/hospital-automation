using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class ConsultationData: HandbooksInfo
	{
		public ConsultationData(){}
		public static ConsultationData Create(string xmlString)
		{
			if (String.IsNullOrEmpty(xmlString)) return new ConsultationData();
			return (ConsultationData) XmlUtils.DeserializeString(typeof(ConsultationData), xmlString);
		}
	}

}