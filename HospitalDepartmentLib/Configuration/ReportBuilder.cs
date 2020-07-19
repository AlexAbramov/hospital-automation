using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Geomethod.Data;
using Geomethod;

namespace HospitalDepartment
{
	public class ReportBuilder : ICloneable
	{
		#region Fields
		[XmlAttribute]
		public string id="";
		[XmlAttribute]
		public string name = "";
		#endregion

		public ReportBuilder()
		{
		}

        public ReportBuilder(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

		#region Properties
		[XmlIgnore]
		public string Name { get { return name; } }
		[XmlIgnore]
		public string Id { get { return id; } }
		#endregion

		#region ICloneable Members

		public object Clone()
		{
			return (ReportBuilder)this.MemberwiseClone();
		}

		#endregion

		public override string ToString()
		{
			return name;
		}
	}
}
