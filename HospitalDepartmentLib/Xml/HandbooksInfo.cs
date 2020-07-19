using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
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
	public abstract class HandbooksInfo
	{
		[XmlIgnore]
		public Dictionary<string, string> items = new Dictionary<string, string>();
		public StringPair[] StringPairs
		{
			get
			{
				return XmlUtils.GetStringPairs(items);
			}
			set
			{
				XmlUtils.InitDictionary(items, value);
			}
		}
		
		public string this[string handbookId]
		{
			get 
			{ 
				return items.ContainsKey(handbookId)?items[handbookId]:""; 
			}
			set { items[handbookId] = value; }
		}

		#region Construction
/*		public HandbooksInfo()
		{
		}*/
		#endregion

		public string GetXmlString()
		{
			return XmlUtils.Serialize(this);
		}

		public void Init(HandbookGroup hg, HandbooksInfo hi)
		{
			foreach (Handbook hb in hg.GetAllHandbooks())
			{
				string val = hi[hb.id];
				if (val.Length > 0) this[hb.id] = val;
			}
		}
		public bool ContainsKey(string key)
		{
			return items.ContainsKey(key);
		}
		public string GetText(HandbookGroup hg)
		{
			StringBuilder sb = new StringBuilder();
			if (hg != null)
			{
				foreach (Handbook hb in hg.GetAllHandbooks())
				{
					string val = this[hb.id];
					if (val.Trim().Length > 0)
					{
						if (sb.Length > 0) sb.Append("; ");
						sb.AppendFormat("{0}: {1}", hb.name, val);
					}
				}
				if (sb.Length > 0) sb.Append(".");
			}
			return sb.ToString();
		}

		public string GetText()
		{
			StringBuilder sb = new StringBuilder();
			foreach (KeyValuePair<string, string> pair in items)
			{
				if (pair.Value.Trim().Length > 0)
				{
					if (sb.Length > 0) sb.Append("; ");
					sb.AppendFormat("{0}: {1}", pair.Key, pair.Value);
				}
			}
			if (sb.Length > 0) sb.Append(".");
			return sb.ToString();
		}
	}
}