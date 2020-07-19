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
	public enum HandbookType { Header, String, Number, Date }
	public class Handbook : ICloneable
	{
		#region Fields
		[XmlAttribute]
		public string id="";
		[XmlAttribute]
		public string name = "";
		[XmlAttribute]
		public HandbookType handbookType = HandbookType.String;
		[XmlAttribute]
		public bool frequent = false;
		[XmlAttribute]
		public string defaultValue = "";
		[XmlAttribute]
		public string minValue = null;
		[XmlAttribute]
		public string maxValue = null;
		[XmlIgnore]
		List<string> items = new List<string>();
		[XmlAttribute]
		public int lineCount = 1;
		[XmlAttribute]
		public bool additive = false;
		[XmlAttribute]
		public bool visible = true;
		[XmlAttribute]
		public int decimalPlaces = 0;
		[XmlAttribute]
		public bool nullable = false;
		#endregion

		#region Properties
//		public int DecimalPlaces { get { return decimalPlaces == null ? 0 : decimalPlaces; } }
//		public bool Visible { get { return decimalPlaces == null ? 0 : decimalPlaces; } }
		[XmlAttribute]
		public string ItemsList
		{ 
			get
			{
				StringBuilder sb = new StringBuilder();
				foreach (string s in items)
				{
					if (sb.Length != 0) sb.Append(";");
					sb.Append(s);
				}
				return sb.ToString();
			}
			set 
			{
				items.AddRange(value.Split(";".ToCharArray(),StringSplitOptions.RemoveEmptyEntries));
			}
		}
		[XmlIgnore]
		public List<string> Items { get { return items; } }
		[XmlIgnore]
		public string Id { get { return id; } }
		[XmlIgnore]
		public string Name { get { return name; } }
		[XmlIgnore]
		public string DefaultValue { get { return defaultValue; } }
		[XmlIgnore]
		public bool Frequent { get { return frequent; } set { frequent = value; } }
		[XmlIgnore]
		public HandbookType HandbookType { get { return handbookType; } set { handbookType = value; } }
		[XmlIgnore]
		public bool IsMultiline { get { return lineCount>1; } }
		#endregion

        #region Construction
        public Handbook()
		{
		}
        public Handbook(string id, string name, HandbookType handbookType)
        {
            this.id = id;
            this.name = name;
            this.handbookType = handbookType;
        }
		public Handbook(string id, string name, HandbookType handbookType, int lineCount)
		{
			this.id = id;
			this.name = name;
			this.handbookType = handbookType;
			this.lineCount = lineCount;
		}
		#endregion

        #region ICloneable Members

        public object Clone()
		{
			Handbook handbook = (Handbook)this.MemberwiseClone();
			handbook.items = CollectionUtils.Clone(items);
			return handbook;
		}

		#endregion

		public override string ToString()
		{
			return name;
		}

		public string GetDefaultValue()
		{
			if (handbookType == HandbookType.Number && Items.Count == 2)
			{
				try
				{
					int d = decimalPlaces;
					decimal rmin = decimal.Parse(Items[0]);
					decimal rmax = decimal.Parse(Items[1]);
					Random random = new Random();
					decimal r = rmin + (decimal)random.NextDouble() * (rmax - rmin);
					r = Math.Round(r, d);
					return r.ToString();//"0:F"+d
				}
				catch
				{
				}
			}
			return defaultValue;
		}
	}
}
