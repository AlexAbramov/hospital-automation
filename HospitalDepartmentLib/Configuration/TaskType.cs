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
    public class TaskType : ICloneable
	{
		#region Fields
		[XmlAttribute]
        public TaskTypeId id = TaskTypeId.Null;
        [XmlAttribute]
		public string name = "";
		#endregion

		public TaskType()
		{
		}

        public TaskType(TaskType t)
        {
            id = t.id;
            name = t.name;
        }

        public TaskType(TaskTypeId id, string name)
        {
            this.id = id;
            this.name = name;
        }

		#region Properties
		[XmlIgnore]
        public TaskTypeId Id { get { return id; } }
        [XmlIgnore]
		public string Name { get { return name; } }
		#endregion

		#region ICloneable Members

		public object Clone()
		{
            return (TaskType)this.MemberwiseClone();
		}

		#endregion

		public override string ToString()
		{
			return name;
		}
	}
}
