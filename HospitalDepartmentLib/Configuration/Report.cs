using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;

namespace HospitalDepartment
{
	public class Report: ICloneable
	{
		[XmlAttribute]
		public string name = "";
		[XmlAttribute]
		public string path = "";
		[XmlAttribute]
		public string embeddedResource = "";
		[XmlAttribute]
		public string reportBuilderId = "";
		[XmlAttribute]
		public bool visible = true;
        public Report() { }
        public Report(string name, string path, string embeddedResource, string reportBuilderId, bool visible) { this.name = name; this.path = path; this.embeddedResource = embeddedResource; this.reportBuilderId = reportBuilderId; this.visible = visible; }
        public override string ToString()
		{
 			 return name;
		}

		#region Properties
		[XmlIgnore]
		public string Name { get { return name; } }
		[XmlIgnore]
		public string Path { get { return path; } }
		[XmlIgnore]
		public bool Visible { get { return visible; } set { visible = value; } }
		[XmlIgnore]
		public string EmbeddedResource { get { return embeddedResource; } }
		[XmlIgnore]
		public string ReportBuilderId { get { return reportBuilderId; } }
		public bool IsEmbedded { get { return embeddedResource.Trim().Length>0; } }
		#endregion

		#region ICloneable Members

		public object Clone()
		{
			Report report = (Report)this.MemberwiseClone();
			return report;
		}

		#endregion
	}
}
