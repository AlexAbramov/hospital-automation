using System;
using System.Text;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using Geomethod;

namespace HospitalDepartment
{
	[XmlRootAttribute]
	public class AppConfig: BaseConfig
	{
		public const int currentVersion = 3;// should be incremented at each config schema change!

		#region Static
		public const string fileName = "App.xml";
		public static string FilePath{get{return PathUtils.BaseDirectory+fileName;}}//Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
		public static AppConfig DeserializeFile() { return DeserializeFile(FilePath); }
		public static AppConfig DeserializeFile(string filePath) { return (AppConfig)BaseConfig.DeserializeFile(typeof(AppConfig), filePath); }
		#endregion

        public override int CurrentVersion { get { return currentVersion; } }

		#region Fields
        public string dataProvider = "";
		public string connStr = "";
		public int debugMode = 0;
		public int autoBackupPeriod = 0;//hours
		public string autoBackupPath = "";
		public string autoBackupSecondPath = "";
		#endregion

		#region Construction
		public AppConfig()
		{
		}
		#endregion

		public string GetDbName()
		{
			string s=connStr;
			int i = s.IndexOf("initial catalog",StringComparison.OrdinalIgnoreCase);
			if (i >= 0)
			{
				i = s.IndexOf("=",i);
				if (i >= 0)
				{
					int j = s.IndexOf(';', i);
					if (j < 0) j = s.Length;
					return s.Substring(i+1, j - i-1);
				}
			}
			return "";
		}

		#region ICloneable Members

		public override object Clone()
		{
			AppConfig config = (AppConfig)this.MemberwiseClone();
//			config.guiConfig = (GuiConfig)guiConfig.Clone();
//			config.reports = CollectionUtils.Clone(reports);
			return config;
		}

		#endregion
	}
}
