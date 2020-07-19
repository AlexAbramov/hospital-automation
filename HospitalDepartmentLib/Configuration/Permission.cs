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
    public class Permission : ICloneable
	{
		#region Fields
		[XmlAttribute]
        public PermissionId id = PermissionId.Null;
        [XmlAttribute]
        public string group = "";
        [XmlAttribute]
		public string name = "";
		#endregion

		public Permission()
		{
		}

        public Permission(Permission p)
        {
            id = p.id;
            group = p.group;
            name = p.name;
        }

		#region Properties
		[XmlIgnore]
        public PermissionId Id { get { return id; } }
        [XmlIgnore]
        public string Group { get { return group; } }
        [XmlIgnore]
		public string Name { get { return name; } }
		#endregion

		#region ICloneable Members

		public object Clone()
		{
            return (Permission)this.MemberwiseClone();
		}

		#endregion

		public override string ToString()
		{
			return name;
		}
	}
}
