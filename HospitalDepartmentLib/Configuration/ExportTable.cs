using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;

namespace HospitalDepartment
{
	public class ExportTable: ICloneable
	{
		#region Fields
		[XmlAttribute]
		public string name = "";
		[XmlAttribute]
		public bool visible = true;
		[XmlAttribute]
		public bool import = true;
		[XmlAttribute]
		public string key = "";
		#endregion

		public ExportTable() { }
		public override string ToString()
		{
 			 return name;
		}

		#region Properties
		[XmlIgnore]
		public string Name { get { return name; } }
		[XmlIgnore]
		public bool Visible { get { return visible; } set { visible = value; } }
		#endregion

		#region ICloneable Members

		public object Clone()
		{
			ExportTable et = (ExportTable)this.MemberwiseClone();
			return et;
		}

		#endregion
	}
}
