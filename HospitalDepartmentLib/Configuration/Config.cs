using System;
using System.Drawing;
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
    public class Config : BaseConfig
    {
        public const int currentVersion = 5;// should be incremented at each config schema change!

        #region Static
        public static readonly string fileName = "HospitalDepartment.xml";
        public static readonly string prevFileName = "HospitalDepartmentPrev.xml";
        public static string FilePath { get { return PathUtils.BaseDirectory + fileName; } }
        public static string PrevFilePath { get { return PathUtils.BaseDirectory + prevFileName; } }
		public static Config DeserializeFile() { return DeserializeFile(FilePath); }
		public static Config DeserializeFile(string filePath) { return (Config)BaseConfig.DeserializeFile(typeof(Config), filePath); }
		public static Config DeserializeString(string xmlString) { return (Config)BaseConfig.DeserializeString(typeof(Config), xmlString); }
		#endregion

        public override int CurrentVersion { get { return currentVersion; } }

        #region Fields
        public int timerInterval = 5000;
        public GuiConfig guiConfig = new GuiConfig();
        public DepartmentConfig departmentConfig = new DepartmentConfig();
        public List<HandbookGroup> handbookGroups = new List<HandbookGroup>();
        public List<ReportBuilder> reportBuilders = new List<ReportBuilder>();
        public List<Report> reports = new List<Report>();
        public List<ExportTable> exportTables = new List<ExportTable>();
        public List<Permission> permissions = new List<Permission>();
        public List<TaskType> taskTypes = new List<TaskType>();
        #endregion

        #region Properties
        public string DepartmentFullName { get { return departmentConfig.departmentName + " " + departmentConfig.hospitalName; } }
        #endregion

        #region Construction
        public Config()
        {
        }
        public void Init()
        {
            foreach (HandbookGroup hg in handbookGroups)
            {
                hg.handbookRefs.Clear();
                foreach (string handbookId in hg.refs.Split("; ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                {
                    Handbook hb = GetHandbook(handbookId);
                    if (hb != null) hg.handbookRefs.Add(hb);
                }
            }
        }
		protected override void OnDeserialized()
        {
            Init();
        }
        #endregion

		#region ICloneable Members

		public override object Clone()
		{
			Config config = (Config)this.MemberwiseClone();
			config.guiConfig = (GuiConfig)guiConfig.Clone();
			config.departmentConfig = (DepartmentConfig)departmentConfig.Clone();
			config.handbookGroups = CollectionUtils.Clone(handbookGroups);
			config.reportBuilders = CollectionUtils.Clone(reportBuilders);
			config.reports = CollectionUtils.Clone(reports);
			config.exportTables = CollectionUtils.Clone(exportTables);
			config.permissions = CollectionUtils.Clone(permissions);
			config.taskTypes = CollectionUtils.Clone(taskTypes);
			return config;
		}

		#endregion

        #region Methods
/*        public void Save()
        {
            base.SaveAs(FilePath, false);
        }*/
        public List<Report> GetVisibleReports(string[] reportBuilderIds)
        {
            List<Report> list = new List<Report>();
            foreach (string reportBuilderId in reportBuilderIds)
            {
                list.AddRange(GetVisibleReports(reportBuilderId));
            }
            return list;
        }
        public List<Report> GetVisibleReports(string reportBuilderId) { return GetReports(reportBuilderId, true); }
        public List<Report> GetReports(string reportBuilderId, bool visibleFilter)
        {
            List<Report> list = new List<Report>();
            foreach (Report r in reports)
            {
                if (r.reportBuilderId == reportBuilderId)
                    if (!visibleFilter || r.visible)
                        list.Add(r);
            }
            return list;
        }
        public List<HandbookGroup> GetHandbookGroups(string token)
        {
            List<HandbookGroup> list = new List<HandbookGroup>();
            foreach (HandbookGroup hg in handbookGroups)
            {
                if (hg.HasToken(token))
                    list.Add(hg);
            }
            return list;
        }
        public HandbookGroup GetHandbookGroup(HandbookGroupId id) { return GetHandbookGroup(id.ToString()); }
        public HandbookGroup GetHandbookGroup(string id)
        {
            if (id != null)
            {
                foreach (HandbookGroup hg in handbookGroups)
                {
                    if (hg.id == id)
                        return hg;
                }
            }
            return null;
            //			throw new HospitalDepartmentException("HandbookGroup not found: " + id.ToString());
        }
        public HandbookGroup this[HandbookGroupId id]
        {
            get
            {
                return GetHandbookGroup(id.ToString());
            }
        }
        public IEnumerable<string> GetHandbookItems(string handbookId)
        {
            Handbook hb = GetHandbook(handbookId);
            return hb == null ? null : hb.Items;
        }
        public Handbook GetHandbook(string handbookId)
        {
            foreach (HandbookGroup hg in handbookGroups)
            {
                Handbook hb = hg[handbookId];
                if (hb != null) return hb;
            }
            return null;
        }

        public TaskType GetTaskType(TaskTypeId taskTypeId)
        {
            foreach (TaskType taskType in taskTypes)
            {
                if (taskType.Id == taskTypeId) return taskType;
            }
            return new TaskType();
        }

        public bool AddHandbook(HandbookGroupId gid, Handbook hb)
        {
            HandbookGroup hg=GetHandbookGroup(gid);
            if (hg != null)
            {
                return hg.AddHandbook(hb);
            }
            return false;
        }
        #endregion
    }
}
