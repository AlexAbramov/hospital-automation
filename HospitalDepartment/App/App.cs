using System;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
//using System.Security.Principal;
using Geomethod;
using Geomethod.Data;
using Geomethod.Windows.Forms;
using Geomethod.Data.Windows.Forms;
using HospitalDepartment.Forms;
using HospitalDepartment.Reports;
using HospitalDepartment.Data;
using HospitalDepartment.Utils;

namespace HospitalDepartment
{
	public sealed class App
	{
		#region Static
		private static App instance = null;
		public static bool Init() { return new App().InitInstance(); }
		public static App Instance { get { if (instance == null) throw new HospitalDepartmentException("Приложение не инициализировано."); return instance; } }
        public static ConfigRecord ConfigRecord { get { return Instance.configRecord; } }
        public static Config Config { get { return Instance.configRecord.config; } }
        public static GuiConfig GuiConfig { get { return Config.guiConfig; } }
		public static DepartmentConfig DepartmentConfig { get { return Config.departmentConfig; } }
		public static AppConfig AppConfig { get { return Instance.appConfig; } }
        public static GmConnection CreateConnection() { return Instance.connectionFactory.CreateConnection(); }
        public static ConnectionFactory ConnectionFactory { get { return Instance.connectionFactory; } }
		public static MainForm MainForm { get { return Instance.mainForm; } set { Instance.mainForm = value; } }
		public static int DebugMode { get { return Instance.appConfig.debugMode; } }
		public static bool IsConfigLoaded { get { return instance != null && Config!=null; } }
        public static AssemblyInfo AssemblyInfo { get { return Instance.assemblyInfo; } }
        public static TaskManager TaskManager { get { return Instance.taskManager; } }
        internal static bool HasPermission(PermissionId permissionId) { return instance.Role.HasPermission(permissionId);}
        
        #endregion

		#region Fields
		AppConfig appConfig;
        ConfigRecord configRecord;
        ConnectionFactory connectionFactory;
		MainForm mainForm;
		AssemblyInfo assemblyInfo;
		AppCache appCache;
		UserInfo userInfo;
        TaskManager taskManager;
        Icon icon;
		#endregion

		#region Properties
		public int UserId { get { return userInfo.UserId; } }
		public AppCache AppCache { get { return appCache; } }
		public UserInfo UserInfo { get { return userInfo; } }
        public Role Role { get { return userInfo.Role; } }
        public Icon Icon { get { return icon; } }
        #endregion

		#region Construction
		public App(){}
		bool InitInstance()
	    {
            if (App.instance == null)
            {
                Log.LogSystem.LogSystemFlags = LogSystemFlags.UseIp | LogSystemFlags.UseUserId;
                Log.LogSystem.AddLogHandlers(new MessageFormLogInformer());
            }
			using (WaitCursor wc = new WaitCursor())
			{
				if (App.instance != null) throw new HospitalDepartmentException("Приложение уже инициализировано.");
				Locale.StringSet = new StringSet("ru");
                Locale.StringSet.Load();
				instance = this;
				assemblyInfo = new AssemblyInfo();
				appCache = new AppCache();
				userInfo = new UserInfo();		
		
				// App config
//                appConfig = File.Exists(AppConfig.FilePath) ? AppConfig.Load() : new AppConfig();
                appConfig = AppConfig.DeserializeFile();

                // DB
                if (appConfig.dataProvider.Trim().Length == 0 || appConfig.connStr.Trim().Length == 0 || appConfig.debugMode == 2)
                {
/*                    ConnectForm connectForm = new ConnectForm();
                    connectForm.DataProviders.Add(SqlServerProvider.name);
                    connectForm.CheckTable = "Medicaments";
                    if (connectForm.ShowDialog() == DialogResult.OK)
                    {
                        if (connectForm.ConnectMode)
                        {
                            appConfig.dataProvider = SqlServerProvider.name;
                            appConfig.connStr = connectForm.ConnectionString;
                            appConfig.Serialize(AppConfig.FilePath);
                            connectionFactory = new ConnectionFactory(appConfig.dataProvider, appConfig.connStr);
                        }
                        else
                        {
                            CreateDbForm form = new CreateDbForm("Data", "HospitalDepartment");
                            form.DataProviders.Add(SqlServerProvider.name);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                connectionFactory = form.DbCreationProperties.CreateDb();

                                // create database
                                UpdateScripts.UpdateDb(connectionFactory, null, "HospitalDepartment.Resources.UpdateScripts.sql");
                                appConfig.dataProvider = connectionFactory.ProviderFactory.Name;
                                appConfig.connStr = connectionFactory.ConnectionString;
                                appConfig.Serialize(AppConfig.FilePath);

                                // import tables
                                ImportTable.ImportData(connectionFactory, PathUtils.BaseDirectory + "Import");
                            }
                            else return false;
                        }
                    }
                    else*/ return false;
                }
                else
                {
                    connectionFactory = new ConnectionFactory(appConfig.dataProvider, appConfig.connStr);
                }

                // Log
                Log.LogSystem.AddLogHandlers(new SqlLog(connectionFactory));
                Log.LogSystem.OnLogMessage += new EventHandler<LogMessageEventArgs>(LogHandler_OnLogMessage);
				Log.Info("AppStart", "Запуск программы.");
				
                // Update database
				UpdateScripts.UpdateDb(connectionFactory, null,"HospitalDepartment.Resources.UpdateScripts.sql");

				// Configuration
				using (GmConnection conn = App.CreateConnection())
				{
                    configRecord = ConfigRecord.GetLastConfigRecord(conn);
                    if (configRecord == null)
                    {
                        Config config = Config.DeserializeFile();
                        ConfigUpdate.CheckUpdate(config);
                        configRecord = new ConfigRecord(1, config);
                        configRecord.Save(conn, true);
                    }
                    else
                    {
                        Config config = configRecord.config;
                        if (ConfigUpdate.CheckUpdate(config))
                        {
                            configRecord = new ConfigRecord(configRecord.Id+1, config);
                            configRecord.Save(conn, true);
                        }
                    }
				}

                // Load icon
                Assembly assembly = Assembly.GetExecutingAssembly();
                using (Stream stream = assembly.GetManifestResourceStream(App.DepartmentConfig.iconName))
                {
                    icon = new Icon(stream);
                }            
            }
			// Login
			if (App.DebugMode > 0 && System.Diagnostics.Debugger.IsAttached)// autologin
			{
                Login("1", "1");
			}
			else
			{
				LoginForm form = new LoginForm(false); 
				form.ShowDialog();
			}

			if (UserId == 0 || Role == null) return false;

            Log.Info("Пользователь вошел в систему", "UserId={0} RoleId={1}", UserId, Role.Id);

			// App cache
			using (WaitCursor wc = new WaitCursor())
			{
				using (GmConnection conn = App.CreateConnection())
				{
					appCache.Update(conn, this.Role.watchingGroupId);
				}
			}

			// Check watching
			if(userInfo.HasWatching)
			{
				if (userInfo.Watching.Id == 0)
				{
					WatchingForm watchingForm = new WatchingForm(this);
					if (watchingForm.ShowDialog() != DialogResult.OK) return false;
				}
				if (userInfo.Watching.Id == 0) return false;
			}

            taskManager = new TaskManager(userInfo, configRecord.config, appCache);
			return true;
		}

		#endregion

		#region Methods
		public bool Login(string login, string psw)
		{
            Log.Info("Login", "Авторизация пользователя '{0}'", login);
            bool res;
            using (GmConnection conn = App.CreateConnection())
			{
				res= userInfo.Login(conn, login, psw);
			}
            if(res) Log.LogSystem.UserId = UserId;
            return res;
		}

/*		internal bool IsWinAdmin()
		{
			bool isAdmin=false;
			try
			{
				WindowsIdentity user = WindowsIdentity.GetCurrent();
				WindowsPrincipal principal = new WindowsPrincipal(user);
				isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch
			{
			}
			return isAdmin;
		}*/
		internal void SetConfig(Config config, string comment, int restoredId)
		{
			ConfigRecord newConfigRecord=new ConfigRecord(configRecord.Id+1, config);
            newConfigRecord.userId = UserId;
			newConfigRecord.comment = comment;
			newConfigRecord.restoredId = restoredId;
            using (GmConnection conn = App.CreateConnection())
            {
                newConfigRecord.Save(conn, true);
            }
            configRecord=newConfigRecord;
        }

		public void Exit()
		{
			if (userInfo.HasWatching && !userInfo.Watching.IsCompleted)
			{
				if(FormUtils.Ask("Завершить дежурство?"))
				{
					userInfo.Watching.endTime = DateTime.Now;
					using (GmConnection conn = App.CreateConnection())
					{
						userInfo.Watching.SaveEndTime(conn);
					}
				}
			}
		}
		#endregion

		#region Handlers
		void LogHandler_OnLogMessage(object sender, LogMessageEventArgs e)
		{
			if (e.logRecord.logType == LogType.Exception)
			{
				if (e.logRecord.exception is DbException)
				{
                    e.logRecord.message = "Ошибка соединения с базой данных:\r\n" + e.logRecord.exception.Message;
				}
			}
		}
		#endregion

	}

	public interface IPrintable
	{
		void Print(PageSetupDialog dlgPageSetup);
	}
}
