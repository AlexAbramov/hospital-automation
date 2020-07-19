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
	public class ConfigRecord
	{
        #region Static
        public static ConfigRecord GetConfigRecord(GmConnection conn, int id)
        {
            if (id == 0) return null;
            GmCommand cmd = conn.CreateCommand("select * from ConfigRecords where Id=@Id");
            cmd.AddInt("Id", id);
            using (DbDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read()) return new ConfigRecord(dr);
            }
            return null;
        }
        public static ConfigRecord GetLastConfigRecord(GmConnection conn)
        {
            GmCommand cmd = conn.CreateCommand("select top 1 * from ConfigRecords order by Id desc");
            using (DbDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read()) return new ConfigRecord(dr);
            }
            return null;
        }
        public static int Remove(GmConnection conn, int id)
        {
            GmCommand cmd = conn.CreateCommand("delete from ConfigRecords where Id=@Id");
            cmd.AddInt("Id", id);
            return cmd.ExecuteNonQuery();
        }
        #endregion

        #region Fields
        int id;
        public int restoredId;
        public int userId;
        public int version;
        public DateTime time;
		public Config config;
        public string comment;
        #endregion

		#region Properties
        public int Id { get { return id; } }
//        public Config Config { get { return config; } set { config = value; } }
        #endregion 

		#region Construction
		public ConfigRecord(int id, Config config)
		{
			this.id = id;
            restoredId=0;
            userId=0;
            version=config.CurrentVersion;
            time=DateTime.Now;
		    this.config=config;
            comment="";
        }
		public ConfigRecord(DbDataReader dr)
		{
			GmDataReader gr = new GmDataReader(dr);
            id = gr.GetInt32();
            restoredId = gr.GetInt32();
            userId = gr.GetInt32();
            version = gr.GetInt32();
            time = gr.GetDateTime();
			config = Config.DeserializeString(gr.GetString());
            comment = gr.GetString();
        }
		#endregion

		#region Serialization
		public int Save(GmConnection conn, bool newRecord)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
            cmd.AddInt("RestoredId", restoredId);
            cmd.AddInt("UserId", userId);
            cmd.AddInt("Version", version);
            cmd.AddDateTime("Time", time);
            cmd.AddString("Config", config.Serialize());
            cmd.AddString("Comment", comment);
            if (newRecord)
			{
				cmd.CommandText = "insert into ConfigRecords values (@Id,@RestoredId,@UserId,@Version,@Time,@Config,@Comment)";
			}
			else
			{
                cmd.CommandText = "update ConfigRecords set RestoredId=@RestoredId,UserId=@UserId,Version=@Version,Time=@Time,Config=@Config,Comment=@Comment where Id=@Id";
			}
			return cmd.ExecuteNonQuery();
		}
		#endregion

		#region Methods

		#endregion

		#region ICloneable Members

		public object Clone()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}