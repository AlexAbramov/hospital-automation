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
	public class HandbookGroup : ICloneable//, IEnumerable<Handbook>
	{
		#region Fields
		[XmlAttribute]
		public string id;
		[XmlAttribute]
		public string name = "";
		[XmlAttribute]
		public string refs = "";
		public List<Handbook> handbooks = new List<Handbook>();
		[XmlIgnore]
		public List<Handbook> handbookRefs = new List<Handbook>();
		[XmlAttribute]
		public string token = "";
		#endregion

		#region Properties
		[XmlIgnore]
		public string Id { get { return id; } }
		public string Name { get { return name; } }
		public int Count { get { return handbooks.Count; } }
		public int VisibleCount { get { int count = 0; foreach (Handbook hb in handbooks) if (hb.visible) count++; return count; } }
		public int TotalCount { get { return handbooks.Count+handbookRefs.Count; } }
		public int TotalVisibleCount { get { int count = 0; foreach (Handbook hb in handbooks) if (hb.visible) count++; foreach (Handbook hb in handbookRefs) if (hb.visible) count++; return count; } }
		#endregion

		public HandbookGroup()
		{
		}

		#region ICloneable Members

		public object Clone()
		{
			HandbookGroup handbookGroup = (HandbookGroup)this.MemberwiseClone();
			handbookGroup.handbooks = CollectionUtils.Clone(handbooks);
			handbookGroup.handbookRefs = CollectionUtils.Clone(handbookRefs);
			return handbookGroup;
		}

		#endregion

		public override string ToString()
		{
			return name;
		}

		public Handbook this[string id]
		{
			get
			{
				foreach (Handbook hb in handbooks)
				{
					if (String.Compare(hb.id,id,false)==0)
						return hb;
				}
				return null;
//				throw new HospitalDepartmentException("Handbook not found: " + id.ToString());
			}
		}

		public List<Handbook> GetAllHandbooks()
		{
			List<Handbook> list = new List<Handbook>(TotalCount);
			list.AddRange(handbooks);
			list.AddRange(handbookRefs);
			return list;
		}

		public IEnumerable<string> GetHandbookItems(string handbookName)
		{
			Handbook hb = this[handbookName];
			return hb != null ? hb.Items : null;
		}
/*		#region IEnumerable<Handbook> Members

		public IEnumerator<Handbook> GetEnumerator()
		{
			return handbooks.GetEnumerator();
		}

		#endregion

		[XmlIgnore]
		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return handbooks.GetEnumerator();
		}

		#endregion*/

		public bool HasToken(string token)
		{
			return string.Compare(this.token.Trim(), token, true)==0;
		}

        public bool AddHandbook(Handbook hb)
        {
            foreach (Handbook handbook in handbooks)
            {
                if (handbook.id == hb.id) return false;
            }
            handbooks.Add(hb);
            return true;
        }
    }
}
