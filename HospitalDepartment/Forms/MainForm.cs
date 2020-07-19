using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using Geomethod.Windows.Forms;
using HospitalDepartment.Utils;
using System.Data.SqlClient;

namespace HospitalDepartment.Forms
{
	public partial class MainForm : Form, IStatus
	{
		public MainForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
		}

		private void miAbout_Click(object sender, EventArgs e)
		{
			About();
		}

		private void About()
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
                    StringBuilder sb = new StringBuilder();
//                    sb.Append(App.Config.version);
					AboutForm form = new AboutForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miExit_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void Exit()
		{
			try
			{
				Close();
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			using (WaitCursor wc = new WaitCursor(this,""))
			{
				App.MainForm = this;
                this.Icon=App.Instance.Icon;
//                Locale.StringSet["_productName"] = App.DepartmentConfig.iconName.departmentName;
                Text = string.Format("{0} - {1} {2}",App.DepartmentConfig.departmentName, App.Instance.UserInfo.Role.name, App.Instance.UserInfo.UserName);
                SetPermissions();
                UpdateTaskList(false);
				timer.Interval = App.Config.timerInterval;
				timer.Enabled = true;
			}
		}

        void SetPermissions()
        {
            Role role=App.Instance.Role;
            if (role != null)
            {
                SetPermission(PermissionId.FileDataExchange, miDataExchange);
                
                SetPermission(PermissionId.Patient, miPatient);
                SetPermission(PermissionId.PatientAdmission, miPatientAdmission, tsbPatientAdmission);
                bool bPatientsList = role.HasPermission(PermissionId.PatientList);
                bool bPatientsListNurse = role.HasPermission(PermissionId.PatientListNurse);
                SetPermission(bPatientsList || bPatientsListNurse, miPatients, tsbPatients);
                SetPermission(bPatientsList && bPatientsListNurse, miNursePatients, null);

                SetPermission(PermissionId.Medicaments, miMedicamentsRoot);
                SetPermission(PermissionId.MedicamentList, miMedicaments);
                SetPermission(PermissionId.MedicamentGroups, miMedicamentGroups);

                SetPermission(PermissionId.Store, miStore);
                SetPermission(PermissionId.StoreProducts, miProducts);
                SetPermission(PermissionId.StoreDocuments, miDocuments);
                SetPermission(PermissionId.StoreDocuments, miIncoming);
                SetPermission(PermissionId.StoreDocuments, miOutgoing);

                SetPermission(PermissionId.Department, miDepartment);
                SetPermission(PermissionId.DepartmentUsers, miUsers);
                SetPermission(PermissionId.DepartmentRoles, miRoles);
                SetPermission(PermissionId.DepartmentWards, miWards);
                SetPermission(PermissionId.DepartmentWatchingGroups, miWatchingGroups);
                SetPermission(PermissionId.AdminAnalysisTypes, miAnalysisTypes);

                SetPermission(PermissionId.Admin, miAdmin);
				SetPermission(PermissionId.AdminConfig, miConfig, tsbConfig);
				SetPermission(PermissionId.AdminConfig, miConfigRecords);
				SetPermission(PermissionId.AdminConfig, miAppConfig);
				SetPermission(PermissionId.AdminBackup, miBackup);
                SetPermission(PermissionId.AdminInsuranceCompanies, miInsuranceCompanies);
                SetPermission(PermissionId.AdminDiagnoses, miDiagnoses);
                SetPermission(PermissionId.AdminLog, miLog, tsbLog);
            }
        }

        private void SetPermission(PermissionId pi, ToolStripMenuItem mi){SetPermission(pi, mi, null);}
        private void SetPermission(bool hasPermission, ToolStripMenuItem mi) { SetPermission(hasPermission, mi, null); }

        private void SetPermission(PermissionId pi, ToolStripMenuItem mi, ToolStripButton tsb)
        {
            bool hasPermission = App.Instance.Role.HasPermission(pi);
            SetPermission(hasPermission, mi, tsb);
        }

        private void SetPermission(bool hasPermission, ToolStripMenuItem mi, ToolStripButton tsb)
        {
            if (mi != null) mi.Visible = hasPermission;
            if (tsb != null) tsb.Visible = hasPermission;
        } 

        void timer_Tick(object sender, EventArgs e)
		{
			try
			{
				OnTimer();
			}
			catch (Exception ex)
			{
				Log.Exception(LogFlags.Hide, ex);
			}
		}

		DateTime taskGenTime = DateTime.MinValue;
		int autoBackupHour = -1;

		private void OnTimer()
		{
			int taskGenPeriod = App.DepartmentConfig.taskGenPeriod;// [minutes]
			if (taskGenPeriod > 0)
			{
				TimeSpan ts = DateTime.Now - taskGenTime;
				if (ts.TotalMinutes > taskGenPeriod)
				{
					UpdateTaskList(true);
				}
			}

			int autoBackupPeriod = App.AppConfig.autoBackupPeriod;// [hours]
			if (autoBackupPeriod > 0)
			{
				DateTime now = DateTime.Now;
				int curMin = now.Minute;
				if (curMin < 10)
				{
					int curHour = now.Hour;
					if (curHour != autoBackupHour && (curHour % autoBackupPeriod) == 0)
					{
						if (!AutoBackup(App.AppConfig.autoBackupPath))
						{
							AutoBackup(App.AppConfig.autoBackupSecondPath);
						}
					}
					autoBackupHour = curHour;
				}
			}
		}

		internal void UpdateTaskList(bool hideExceptionDialog)
        {
            try
            {
                taskGenTime = DateTime.Now;
//                Log.Info("Обновление списка задач");
                using (WaitCursor wc = new WaitCursor(this, "Обновление списка задач..."))
                {
                    ucTasks.Enabled = false;
                    using (GmConnection conn = App.CreateConnection())
                    {
                        App.TaskManager.UpdateTaskList(conn);
                        ucTasks.UpdateTaskList();
                    }
                }
            }
            catch (Exception ex)
            {
				if (hideExceptionDialog) Log.Exception(LogFlags.Hide, ex);
				else Log.Exception(ex);              
            }
            finally 
            {
                ucTasks.Enabled = true;
            }
        }

		private bool AutoBackup(string folderPath)
		{
			try
			{
//				Log.Info("Автосохранение БД");
				if(folderPath.Trim().Length>0)
				{
					string filePath=folderPath+"\\"+GetBackupFileName();
					if(!File.Exists(filePath))
					{
						using (WaitCursor wc = new WaitCursor(this, "Автосохранение БД..."))
						{
							BackupDb(filePath);
						}
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				Log.Exception(LogFlags.Hide, ex);
				return false;
			}
		}

 /*       void CheckTasks()
        {
            Role role=App.Instance.UserInfo.Role;
            if (role != null)
            {
                if(role.HasPermission(PermissionId.PatientAdmission))
                {
//                    App.Config.departmentConfig.doctorRoundPeriod
//                    CheckClinicDiagnoses();
//                    ucTasks.
                }
//                role.watchingGroupId
            }
        }*/

/*		void CheckObservations()
		{
//			DataTable dt = new DataTable();

		}*/


		private void tsbHelp_Click(object sender, EventArgs e)
		{
			About();
		}

		private void tsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void miUsers_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					UsersForm form = new UsersForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miRoles_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					RolesForm form = new RolesForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miLog_Click(object sender, EventArgs e)
		{
			ShowLog();
		}

		private void ShowLog()
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					LogForm form = new LogForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miMedicaments_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					MedicamentsForm form = new MedicamentsForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miMedicamentGroups_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					MedicamentGroupsForm form = new MedicamentGroupsForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miInsuranceCompanies_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					InsuranceCompaniesForm form = new InsuranceCompaniesForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miPatientAdmission_Click(object sender, EventArgs e)
		{
			AdmitPatient();
		}

		private void AdmitPatient()
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					Patient patient = new Patient();
					PatientAdmissionForm form = new PatientAdmissionForm(patient);
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miPatients_Click(object sender, EventArgs e)
		{
			ShowPatientsList();
		}

		private void ShowPatientsList()
		{
			try
			{
                Role role=App.Instance.Role;
                if(role!=null && role.HasPermission(PermissionId.PatientListNurse) && !role.HasPermission(PermissionId.PatientList))
                {
                    ShowNursePatientsList();
                    return;
                }
				using (WaitCursor wc = new WaitCursor())
				{
					PatientsForm form = new PatientsForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void Config()
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					ConfigForm form = new ConfigForm(App.ConfigRecord,false);
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void ConfigRecords()
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					ConfigRecordsForm form = new ConfigRecordsForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				Log.Info("AppClose", "Завершение программы.");
				App.Instance.Exit();
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miDiagnoses_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					DiagnosesForm form = new DiagnosesForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miWards_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					WardsForm form = new WardsForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miProducts_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					ProductsForm form = new ProductsForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miIncoming_Click(object sender, EventArgs e)
		{
			DocumentsForm.CreateDocument(DocumentTypeId.Incoming);
		}

		private void miDocuments_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					DocumentsForm form = new DocumentsForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void tsbPatients_Click(object sender, EventArgs e)
		{
			ShowPatientsList();
		}

		private void tsbPatientAdmission_Click(object sender, EventArgs e)
		{
			AdmitPatient();
		}

		private void miDataExchange_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					ExportTablesForm form = new ExportTablesForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void tsbLog_Click(object sender, EventArgs e)
		{
			ShowLog();
		}

		private void tsbConfig_Click(object sender, EventArgs e)
		{
			Config();
		}

		private void miOutgoing_Click(object sender, EventArgs e)
		{
			DocumentsForm.CreateDocument(DocumentTypeId.Outgoing);
		}

		private void miAnalysisTypes_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					AnalysisTypesForm form = new AnalysisTypesForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miBackup_Click(object sender, EventArgs e)
		{
			try
			{
				dlgBackup.FileName = GetBackupFileName();
				if (dlgBackup.ShowDialog() == DialogResult.OK)
				{
					using (WaitCursor wc = new WaitCursor())
					{
						BackupDb(dlgBackup.FileName);
					}
					MessageBox.Show("Архивация завершена.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Архивация не сделана. Возможно не достаточно прав доступа. \r\nДетали: "+ex.Message);
//				Log.Exception(ex);
			}
		}

		private string GetBackupFileName()
		{
			string dbName = App.AppConfig.GetDbName();
			if (dbName.Length == 0) throw new HospitalDepartmentException("Не найдено имя базы данных.");
			DateTime dt = DateTime.Now;
			string timeStr=dt.ToString("_yyyy-mmm-dd_HH");
			string fileName = dbName + timeStr+".bak";
			return fileName;
		}

		private void BackupDb(string filePath)
		{
			string dbName = App.AppConfig.GetDbName();
			if (dbName.Length == 0) throw new HospitalDepartmentException("Не найдено имя базы данных.");
			using (GmConnection conn = App.CreateConnection())
			{
				string cmdText = string.Format("BACKUP DATABASE {0} TO DISK='{1}'", dbName, filePath);
				GmCommand cmd = conn.CreateCommand(cmdText);
				cmd.ExecuteNonQuery();
				//                            SqlServerBackup bk=new SqlServerBackup(conn.DbConnection as SqlConnection);
				//							bk.BackupDatabase(dbName, dlgBackup.FileName);
			}
		}

		private void toolStripSeparator1_Click(object sender, EventArgs e)
		{

		}

		private void miWatchingGroups_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					WatchingGroupsForm form = new WatchingGroupsForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

/*		private void miDiets_Click(object sender, EventArgs e)
		{
			try
			{
				using (WaitCursor wc = new WaitCursor())
				{
					DietsForm form = new DietsForm();
					form.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}*/

        #region IStatus Members

        public string Status
        {
            get
            {
                return lblStatus.Text;
            }
            set
            {
                lblStatus.Text = value;
            }
        }

        #endregion

        private void ucTasks_Load(object sender, EventArgs e)
        {

        }

        private void miNursePatients_Click(object sender, EventArgs e)
        {
            ShowNursePatientsList();
        }

        private void ShowNursePatientsList()
        {
            try
            {
                using (WaitCursor wc = new WaitCursor())
                {
                    NursePatientsForm form = new NursePatientsForm();
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

        private void tsbLock_Click(object sender, EventArgs e)
        {
            LockProgram();
        }

        private void LockProgram()
        {
            try
            {
                base.Visible = false;
                LoginForm form = new LoginForm(true);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    base.Visible = true;
                }
                else Close();
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

        private void miGetMedicaments_Click(object sender, EventArgs e)
        {
            GetMedicaments();
        }

        private void GetMedicaments()
        {
            try
            {
              NurseDocumentsForm form = new NurseDocumentsForm();
              form.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

        private void miLock_Click(object sender, EventArgs e)
        {
            LockProgram();
        }

        private void miHtmlEditor_Click(object sender, EventArgs e)
        {
            try
            {
                ReportForm.Edit(null);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

        private void GetPatientsPrescriptions()
        {
            try
            {
                PatientsPrescriptionsForm form = new PatientsPrescriptionsForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

        private void miPatientsPrescriptions_Click(object sender, EventArgs e)
        {
            GetPatientsPrescriptions();
        }

		private void miConfig_Click(object sender, EventArgs e)
		{
			Config();
		}

		private void miConfigRecords_Click(object sender, EventArgs e)
		{
			ConfigRecords();
		}

		private void miAppConfig_Click(object sender, EventArgs e)
		{
			try
			{
				AppConfigForm form = new AppConfigForm();
				form.ShowDialog();
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}
    }
}