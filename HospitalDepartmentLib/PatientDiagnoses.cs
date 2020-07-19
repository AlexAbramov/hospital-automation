using System;
using System.ComponentModel;
using System.Collections.Generic;
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
	public class PatientDiagnoses
	{
		public string directionalDiagnosis = "";
		public DiagnosisInfo admissionDiagnosis=DiagnosisInfo.Empty;
		public DiagnosisInfo clinicalDiagnosis = DiagnosisInfo.Empty;
		public DiagnosisInfo finalDiagnosis = DiagnosisInfo.Empty;
		public string complicationDiagnosis = "";
		public string concomitantDiagnosis = "";

		#region Construction
		public static PatientDiagnoses Create(string xmlText)
		{
			if (xmlText == null || xmlText.Length == 0) return new PatientDiagnoses();
			return (PatientDiagnoses)XmlUtils.Deserialize(typeof(PatientDiagnoses), xmlText);
		}
		public PatientDiagnoses()
		{
		}
		#endregion

		public string GetXmlString()
		{
			return XmlUtils.Serialize(this);
		}

		public DiagnosisInfo LatestDiagnosisInfo
		{
			get
			{
				if (finalDiagnosis.id != 0) return finalDiagnosis;
				if (clinicalDiagnosis.id != 0) return clinicalDiagnosis;
				return admissionDiagnosis;
			}
		}
	}
}