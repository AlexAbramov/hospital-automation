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
	public class AdminConfig: BaseConfig
	{
		#region Fields
		public int debugMode = 0;
		public int autoBackupPeriod = 0;//hours
		public string autoBackupPath = "";
		public string autoBackupSecondPath = "";
		#endregion

		#region Construction
		public AdminConfig()
		{
		}

        public override int CurrentVersion => 0;
        #endregion


        #region ICloneable Members

        public override object Clone()
		{
			AdminConfig config = (AdminConfig)this.MemberwiseClone();
//			config.guiConfig = (GuiConfig)guiConfig.Clone();
//			config.reports = CollectionUtils.Clone(reports);
			return config;
		}

		#endregion
	}
}
