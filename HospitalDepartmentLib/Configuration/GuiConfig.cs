using System;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;

namespace HospitalDepartment
{
	public class GuiConfig: ICloneable
	{
		#region Fields
		FontConverter fontConverter=new FontConverter();
		[XmlIgnore]
		public Font font = new Font(FontFamily.GenericSansSerif, 12);
		[XmlIgnore]
		public Font gridFont = new Font(FontFamily.GenericMonospace, 12);
		public Size formSize = new Size(600, 500);
		public int handbookControlWidth = 300;
		#endregion

		#region Properties
		public string FontString { get { return fontConverter.ConvertToString(font); } set { font = (Font)fontConverter.ConvertFromString(value); } }
		public string GridFontString { get { return fontConverter.ConvertToString(gridFont); } set { gridFont = (Font)fontConverter.ConvertFromString(value); } }
		public bool dateTimePickerShowUpDown = false;
		#endregion

		public GuiConfig() {}

		#region ICloneable Members

		public object Clone()
		{
			GuiConfig gc = (GuiConfig)this.MemberwiseClone();
			gc.font = (Font)this.font.Clone();
			gc.gridFont = (Font)this.gridFont.Clone();
			return gc;
		}

		#endregion
	}
}
