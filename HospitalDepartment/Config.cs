using System;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace CardiologyDepartment
{
	[XmlRootAttribute]
	public class Config
	{
		#region Static
		public static readonly Version currentVersion = new Version(1, 0, 0);// should be incremented at each config schema change!

		public static Config Load()// log ignored
		{
			return Load(Config.ConfigFilePath);
		}

		public static Config Load(string filePath)// log ignored
		{
//			if(!File.Exists(filePath)) return new Config();
			Config config;
			XmlSerializer xs = new XmlSerializer(typeof(Config));
			using (TextReader reader = new StreamReader(filePath))
			{
				config = (Config)xs.Deserialize(reader);
			}
//			config.changed = !config.IsChecksumOk;

			return config;
		}

		public static string BaseDirectory{get{return AppDomain.CurrentDomain.BaseDirectory;}}// log ignored
		public static string ConfigFilePath{get{return BaseDirectory+configFileName;}}// log ignored
		public static string PreviousConfigFilePath{get{return BaseDirectory+previousConfigFileName;}}// log ignored
		#endregion

		public const string configFileName = "CardiologyDepartment.xml";
		public const string previousConfigFileName = "CardiologyDepartmentPrev.xml";
		bool changed = true;
		Version version=new Version(1,0,0);
		public DateTime lastchanged;
		public string checksum;
		public string Version{get{return version.ToString();}set{version=new Version(value);}}
		public bool Changed { get { return changed; } }

		public string connStr="";
		public int debugMode = 0;
		public int timerInterval = 5000;

		#region Construction
		public Config()
		{
		}

		#endregion

		#region Serialzation
		public void SaveAs(string filePath)
		{
			version = currentVersion;
			lastchanged = DateTime.Now;
			checksum = CheckSum;
			XmlSerializer xs = new XmlSerializer(typeof(Config));
			using (TextWriter writer = new StreamWriter(filePath))
			{
				xs.Serialize(writer, this);
			}
		}

		public void Save()
		{
			if (changed)
			{
				SaveAs(ConfigFilePath);
				changed = false;
			}
		}
		#endregion

		#region Aux
		public bool IsChanged { get { return changed; } }
		public bool IsChecksumOk// log ignored
		{
			get { return checksum == CheckSum; }
		}
		public void SetChanged()
		{
			changed = true;
		}

		string CheckSum
		{
			get
			{
				string checksum0=checksum;
				checksum="";
				try
				{
					XmlSerializer xs = new XmlSerializer(typeof(Config));
					using(MemoryStream ms=new MemoryStream(1<<16))
					{
						using(TextWriter writer = new StreamWriter(ms))
						{
							xs.Serialize(writer, this);
							long count=ms.Length;
							long sum=0;
							ms.Position=0;
							for(long i=0;i<count;i++) sum+=ms.ReadByte();
							return string.Format("{0:X}",sum);
						}
					}
				}
				finally
				{
					checksum=checksum0;
				}
			}
		}
		#endregion
	}
}
