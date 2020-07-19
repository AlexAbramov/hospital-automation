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
	public class UserConfig: BaseConfig
	{
		public const int currentVersion = 3;// should be incremented at each config schema change!

		#region Static
		public const string fileName = "User.xml";
		public static string FilePath{get{return PathUtils.DataDirectory+fileName;}}
		public static UserConfig DeserializeFile() { return DeserializeFile(FilePath); }
		public static UserConfig DeserializeFile(string filePath) { return (UserConfig)BaseConfig.DeserializeFile(typeof(UserConfig), filePath); }
		#endregion

        public override int CurrentVersion { get { return currentVersion; } }

		#region Fields
		public int debugMode = 0;
		AdminConfig adminConfig = new AdminConfig();
		#endregion

		#region Construction
		public UserConfig()
		{
		}
		#endregion


		#region ICloneable Members

		public override object Clone()
		{
			UserConfig config = (UserConfig)this.MemberwiseClone();
			config.adminConfig = (AdminConfig)adminConfig.Clone();
			return config;
		}

		#endregion
	}
}
