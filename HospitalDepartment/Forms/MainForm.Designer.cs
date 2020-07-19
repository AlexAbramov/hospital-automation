namespace HospitalDepartment.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tscMain = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.ucTasks = new HospitalDepartment.UserControls.TasksUserControl();
			this.msMain = new System.Windows.Forms.MenuStrip();
			this.miFile = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.miDataExchange = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.printPreviewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.miPatient = new System.Windows.Forms.ToolStripMenuItem();
			this.miPatientAdmission = new System.Windows.Forms.ToolStripMenuItem();
			this.miPatients = new System.Windows.Forms.ToolStripMenuItem();
			this.miNursePatients = new System.Windows.Forms.ToolStripMenuItem();
			this.miMedicamentsRoot = new System.Windows.Forms.ToolStripMenuItem();
			this.miMedicaments = new System.Windows.Forms.ToolStripMenuItem();
			this.miMedicamentGroups = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.miGetMedicaments = new System.Windows.Forms.ToolStripMenuItem();
			this.miPatientsPrescriptions = new System.Windows.Forms.ToolStripMenuItem();
			this.miStore = new System.Windows.Forms.ToolStripMenuItem();
			this.miProducts = new System.Windows.Forms.ToolStripMenuItem();
			this.miDocuments = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.miIncoming = new System.Windows.Forms.ToolStripMenuItem();
			this.miOutgoing = new System.Windows.Forms.ToolStripMenuItem();
			this.miDepartment = new System.Windows.Forms.ToolStripMenuItem();
			this.miUsers = new System.Windows.Forms.ToolStripMenuItem();
			this.miRoles = new System.Windows.Forms.ToolStripMenuItem();
			this.miWards = new System.Windows.Forms.ToolStripMenuItem();
			this.miWatchingGroups = new System.Windows.Forms.ToolStripMenuItem();
			this.miAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.miConfig = new System.Windows.Forms.ToolStripMenuItem();
			this.miConfigRecords = new System.Windows.Forms.ToolStripMenuItem();
			this.miAnalysisTypes = new System.Windows.Forms.ToolStripMenuItem();
			this.miDiagnoses = new System.Windows.Forms.ToolStripMenuItem();
			this.miInsuranceCompanies = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miBackup = new System.Windows.Forms.ToolStripMenuItem();
			this.miLog = new System.Windows.Forms.ToolStripMenuItem();
			this.miUtils = new System.Windows.Forms.ToolStripMenuItem();
			this.miLock = new System.Windows.Forms.ToolStripMenuItem();
			this.miHtmlEditor = new System.Windows.Forms.ToolStripMenuItem();
			this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.miContents = new System.Windows.Forms.ToolStripMenuItem();
			this.miIndex = new System.Windows.Forms.ToolStripMenuItem();
			this.miSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.tsbPatientAdmission = new System.Windows.Forms.ToolStripButton();
			this.tsbPatients = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.tsbConfig = new System.Windows.Forms.ToolStripButton();
			this.tsbLog = new System.Windows.Forms.ToolStripButton();
			this.tsbHelp = new System.Windows.Forms.ToolStripButton();
			this.tsbLock = new System.Windows.Forms.ToolStripButton();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.dlgBackup = new System.Windows.Forms.SaveFileDialog();
			this.miAppConfig = new System.Windows.Forms.ToolStripMenuItem();
			this.tscMain.BottomToolStripPanel.SuspendLayout();
			this.tscMain.ContentPanel.SuspendLayout();
			this.tscMain.TopToolStripPanel.SuspendLayout();
			this.tscMain.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.msMain.SuspendLayout();
			this.tsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tscMain
			// 
			// 
			// tscMain.BottomToolStripPanel
			// 
			this.tscMain.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// tscMain.ContentPanel
			// 
			this.tscMain.ContentPanel.Controls.Add(this.ucTasks);
			this.tscMain.ContentPanel.Size = new System.Drawing.Size(719, 368);
			this.tscMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tscMain.Location = new System.Drawing.Point(0, 0);
			this.tscMain.Name = "tscMain";
			this.tscMain.Size = new System.Drawing.Size(719, 439);
			this.tscMain.TabIndex = 2;
			this.tscMain.Text = "toolStripContainer1";
			// 
			// tscMain.TopToolStripPanel
			// 
			this.tscMain.TopToolStripPanel.Controls.Add(this.msMain);
			this.tscMain.TopToolStripPanel.Controls.Add(this.tsMain);
			// 
			// statusStrip
			// 
			this.statusStrip.AutoSize = false;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(719, 22);
			this.statusStrip.TabIndex = 0;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(52, 17);
			this.lblStatus.Tag = "";
			this.lblStatus.Text = "lblStatus";
			// 
			// ucTasks
			// 
			this.ucTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucTasks.Location = new System.Drawing.Point(13, 4);
			this.ucTasks.Name = "ucTasks";
			this.ucTasks.Size = new System.Drawing.Size(694, 352);
			this.ucTasks.TabIndex = 0;
			this.ucTasks.Load += new System.EventHandler(this.ucTasks_Load);
			// 
			// msMain
			// 
			this.msMain.Dock = System.Windows.Forms.DockStyle.None;
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miPatient,
            this.miMedicamentsRoot,
            this.miStore,
            this.miDepartment,
            this.miAdmin,
            this.miUtils,
            this.miSettings,
            this.miHelp});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(719, 24);
			this.msMain.TabIndex = 2;
			this.msMain.Text = "menuStrip1";
			// 
			// miFile
			// 
			this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.miDataExchange,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.toolStripSeparator4,
            this.printToolStripMenuItem1,
            this.printPreviewToolStripMenuItem1,
            this.toolStripSeparator6,
            this.miExit});
			this.miFile.Name = "miFile";
			this.miFile.Size = new System.Drawing.Size(48, 20);
			this.miFile.Text = "&Файл";
			// 
			// newToolStripMenuItem1
			// 
			this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
			this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
			this.newToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
			this.newToolStripMenuItem1.Text = "&Новый";
			this.newToolStripMenuItem1.Visible = false;
			// 
			// openToolStripMenuItem1
			// 
			this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
			this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
			this.openToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
			this.openToolStripMenuItem1.Text = "&Открыть";
			this.openToolStripMenuItem1.Visible = false;
			// 
			// miDataExchange
			// 
			this.miDataExchange.Name = "miDataExchange";
			this.miDataExchange.Size = new System.Drawing.Size(233, 22);
			this.miDataExchange.Text = "Обм&ен данными";
			this.miDataExchange.Click += new System.EventHandler(this.miDataExchange_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(230, 6);
			this.toolStripSeparator3.Visible = false;
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
			this.saveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
			this.saveToolStripMenuItem1.Text = "&Сохранить";
			this.saveToolStripMenuItem1.Visible = false;
			// 
			// saveAsToolStripMenuItem1
			// 
			this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
			this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
			this.saveAsToolStripMenuItem1.Text = "Сохранить &как";
			this.saveAsToolStripMenuItem1.Visible = false;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(230, 6);
			this.toolStripSeparator4.Visible = false;
			// 
			// printToolStripMenuItem1
			// 
			this.printToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem1.Image")));
			this.printToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
			this.printToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
			this.printToolStripMenuItem1.Text = "&Печать";
			this.printToolStripMenuItem1.Visible = false;
			// 
			// printPreviewToolStripMenuItem1
			// 
			this.printPreviewToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem1.Image")));
			this.printPreviewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printPreviewToolStripMenuItem1.Name = "printPreviewToolStripMenuItem1";
			this.printPreviewToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
			this.printPreviewToolStripMenuItem1.Text = "Предварительный пр&осмотр";
			this.printPreviewToolStripMenuItem1.Visible = false;
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(230, 6);
			this.toolStripSeparator6.Visible = false;
			// 
			// miExit
			// 
			this.miExit.Name = "miExit";
			this.miExit.Size = new System.Drawing.Size(233, 22);
			this.miExit.Text = "В&ыход";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// miPatient
			// 
			this.miPatient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPatientAdmission,
            this.miPatients,
            this.miNursePatients});
			this.miPatient.Name = "miPatient";
			this.miPatient.Size = new System.Drawing.Size(75, 20);
			this.miPatient.Text = "&Пациенты";
			// 
			// miPatientAdmission
			// 
			this.miPatientAdmission.Name = "miPatientAdmission";
			this.miPatientAdmission.Size = new System.Drawing.Size(266, 22);
			this.miPatientAdmission.Text = "П&риход";
			this.miPatientAdmission.Click += new System.EventHandler(this.miPatientAdmission_Click);
			// 
			// miPatients
			// 
			this.miPatients.Name = "miPatients";
			this.miPatients.Size = new System.Drawing.Size(266, 22);
			this.miPatients.Text = "&Список пациентов";
			this.miPatients.Click += new System.EventHandler(this.miPatients_Click);
			// 
			// miNursePatients
			// 
			this.miNursePatients.Name = "miNursePatients";
			this.miNursePatients.Size = new System.Drawing.Size(266, 22);
			this.miNursePatients.Text = "&Список пациентов (для медсестер)";
			this.miNursePatients.Click += new System.EventHandler(this.miNursePatients_Click);
			// 
			// miMedicamentsRoot
			// 
			this.miMedicamentsRoot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMedicaments,
            this.miMedicamentGroups,
            this.toolStripSeparator5,
            this.miGetMedicaments,
            this.miPatientsPrescriptions});
			this.miMedicamentsRoot.Name = "miMedicamentsRoot";
			this.miMedicamentsRoot.Size = new System.Drawing.Size(97, 20);
			this.miMedicamentsRoot.Text = "&Медикаменты";
			// 
			// miMedicaments
			// 
			this.miMedicaments.Name = "miMedicaments";
			this.miMedicaments.Size = new System.Drawing.Size(302, 22);
			this.miMedicaments.Text = "&Список медикаментов";
			this.miMedicaments.Click += new System.EventHandler(this.miMedicaments_Click);
			// 
			// miMedicamentGroups
			// 
			this.miMedicamentGroups.Name = "miMedicamentGroups";
			this.miMedicamentGroups.Size = new System.Drawing.Size(302, 22);
			this.miMedicamentGroups.Text = "&Группы медикаментов";
			this.miMedicamentGroups.Click += new System.EventHandler(this.miMedicamentGroups_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(299, 6);
			// 
			// miGetMedicaments
			// 
			this.miGetMedicaments.Name = "miGetMedicaments";
			this.miGetMedicaments.Size = new System.Drawing.Size(302, 22);
			this.miGetMedicaments.Text = "Требование на получение медикаментов";
			this.miGetMedicaments.Click += new System.EventHandler(this.miGetMedicaments_Click);
			// 
			// miPatientsPrescriptions
			// 
			this.miPatientsPrescriptions.Name = "miPatientsPrescriptions";
			this.miPatientsPrescriptions.Size = new System.Drawing.Size(302, 22);
			this.miPatientsPrescriptions.Text = "Раздача медикаментов";
			this.miPatientsPrescriptions.Click += new System.EventHandler(this.miPatientsPrescriptions_Click);
			// 
			// miStore
			// 
			this.miStore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProducts,
            this.miDocuments,
            this.toolStripSeparator2,
            this.miIncoming,
            this.miOutgoing});
			this.miStore.Name = "miStore";
			this.miStore.Size = new System.Drawing.Size(52, 20);
			this.miStore.Text = "Скла&д";
			// 
			// miProducts
			// 
			this.miProducts.Name = "miProducts";
			this.miProducts.Size = new System.Drawing.Size(155, 22);
			this.miProducts.Text = "&Номенклатура";
			this.miProducts.Click += new System.EventHandler(this.miProducts_Click);
			// 
			// miDocuments
			// 
			this.miDocuments.Name = "miDocuments";
			this.miDocuments.Size = new System.Drawing.Size(155, 22);
			this.miDocuments.Text = "&Документы";
			this.miDocuments.Click += new System.EventHandler(this.miDocuments_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
			// 
			// miIncoming
			// 
			this.miIncoming.Name = "miIncoming";
			this.miIncoming.Size = new System.Drawing.Size(155, 22);
			this.miIncoming.Text = "&Приход";
			this.miIncoming.Click += new System.EventHandler(this.miIncoming_Click);
			// 
			// miOutgoing
			// 
			this.miOutgoing.Name = "miOutgoing";
			this.miOutgoing.Size = new System.Drawing.Size(155, 22);
			this.miOutgoing.Text = "&Расход";
			this.miOutgoing.Click += new System.EventHandler(this.miOutgoing_Click);
			// 
			// miDepartment
			// 
			this.miDepartment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUsers,
            this.miRoles,
            this.miWards,
            this.miWatchingGroups});
			this.miDepartment.Name = "miDepartment";
			this.miDepartment.Size = new System.Drawing.Size(78, 20);
			this.miDepartment.Text = "&Отделение";
			// 
			// miUsers
			// 
			this.miUsers.Name = "miUsers";
			this.miUsers.Size = new System.Drawing.Size(188, 22);
			this.miUsers.Text = "&Пользователи";
			this.miUsers.Click += new System.EventHandler(this.miUsers_Click);
			// 
			// miRoles
			// 
			this.miRoles.Name = "miRoles";
			this.miRoles.Size = new System.Drawing.Size(188, 22);
			this.miRoles.Text = "&Должности";
			this.miRoles.Click += new System.EventHandler(this.miRoles_Click);
			// 
			// miWards
			// 
			this.miWards.Name = "miWards";
			this.miWards.Size = new System.Drawing.Size(188, 22);
			this.miWards.Text = "Па&латы";
			this.miWards.Click += new System.EventHandler(this.miWards_Click);
			// 
			// miWatchingGroups
			// 
			this.miWatchingGroups.Name = "miWatchingGroups";
			this.miWatchingGroups.Size = new System.Drawing.Size(188, 22);
			this.miWatchingGroups.Text = "Группы наблюдения";
			this.miWatchingGroups.Click += new System.EventHandler(this.miWatchingGroups_Click);
			// 
			// miAdmin
			// 
			this.miAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConfig,
            this.miConfigRecords,
            this.miAnalysisTypes,
            this.miDiagnoses,
            this.miInsuranceCompanies,
            this.toolStripSeparator1,
            this.miAppConfig,
            this.miBackup,
            this.miLog});
			this.miAdmin.Name = "miAdmin";
			this.miAdmin.Size = new System.Drawing.Size(134, 20);
			this.miAdmin.Text = "&Администрирование";
			// 
			// miConfig
			// 
			this.miConfig.Name = "miConfig";
			this.miConfig.Size = new System.Drawing.Size(249, 22);
			this.miConfig.Text = "&Конфигурация";
			this.miConfig.Click += new System.EventHandler(this.miConfig_Click);
			// 
			// miConfigRecords
			// 
			this.miConfigRecords.Name = "miConfigRecords";
			this.miConfigRecords.Size = new System.Drawing.Size(249, 22);
			this.miConfigRecords.Text = "&Список конфигураций";
			this.miConfigRecords.Click += new System.EventHandler(this.miConfigRecords_Click);
			// 
			// miAnalysisTypes
			// 
			this.miAnalysisTypes.Name = "miAnalysisTypes";
			this.miAnalysisTypes.Size = new System.Drawing.Size(249, 22);
			this.miAnalysisTypes.Text = "&Анализы";
			this.miAnalysisTypes.ToolTipText = "Типы анализов";
			this.miAnalysisTypes.Click += new System.EventHandler(this.miAnalysisTypes_Click);
			// 
			// miDiagnoses
			// 
			this.miDiagnoses.Name = "miDiagnoses";
			this.miDiagnoses.Size = new System.Drawing.Size(249, 22);
			this.miDiagnoses.Text = "Диагно&зы";
			this.miDiagnoses.Click += new System.EventHandler(this.miDiagnoses_Click);
			// 
			// miInsuranceCompanies
			// 
			this.miInsuranceCompanies.Name = "miInsuranceCompanies";
			this.miInsuranceCompanies.Size = new System.Drawing.Size(249, 22);
			this.miInsuranceCompanies.Text = "&Страховые компании";
			this.miInsuranceCompanies.Click += new System.EventHandler(this.miInsuranceCompanies_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
			// 
			// miBackup
			// 
			this.miBackup.Name = "miBackup";
			this.miBackup.Size = new System.Drawing.Size(249, 22);
			this.miBackup.Text = "Архивировать базу";
			this.miBackup.Click += new System.EventHandler(this.miBackup_Click);
			// 
			// miLog
			// 
			this.miLog.Name = "miLog";
			this.miLog.Size = new System.Drawing.Size(249, 22);
			this.miLog.Text = "&Журнал системных сообщений";
			this.miLog.Click += new System.EventHandler(this.miLog_Click);
			// 
			// miUtils
			// 
			this.miUtils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLock,
            this.miHtmlEditor});
			this.miUtils.Name = "miUtils";
			this.miUtils.Size = new System.Drawing.Size(66, 20);
			this.miUtils.Text = "&Утилиты";
			// 
			// miLock
			// 
			this.miLock.Name = "miLock";
			this.miLock.Size = new System.Drawing.Size(209, 22);
			this.miLock.Text = "Блокировка программы";
			this.miLock.Click += new System.EventHandler(this.miLock_Click);
			// 
			// miHtmlEditor
			// 
			this.miHtmlEditor.Name = "miHtmlEditor";
			this.miHtmlEditor.Size = new System.Drawing.Size(209, 22);
			this.miHtmlEditor.Text = "Редактор HTML";
			this.miHtmlEditor.Click += new System.EventHandler(this.miHtmlEditor_Click);
			// 
			// miSettings
			// 
			this.miSettings.Name = "miSettings";
			this.miSettings.Size = new System.Drawing.Size(79, 20);
			this.miSettings.Text = "&Настройки";
			this.miSettings.Visible = false;
			// 
			// miHelp
			// 
			this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miContents,
            this.miIndex,
            this.miSearch,
            this.toolStripSeparator9,
            this.miAbout});
			this.miHelp.Name = "miHelp";
			this.miHelp.Size = new System.Drawing.Size(65, 20);
			this.miHelp.Text = "&Справка";
			// 
			// miContents
			// 
			this.miContents.Name = "miContents";
			this.miContents.Size = new System.Drawing.Size(158, 22);
			this.miContents.Text = "&Содержание";
			this.miContents.Visible = false;
			// 
			// miIndex
			// 
			this.miIndex.Name = "miIndex";
			this.miIndex.Size = new System.Drawing.Size(158, 22);
			this.miIndex.Text = "&Индекс";
			this.miIndex.Visible = false;
			// 
			// miSearch
			// 
			this.miSearch.Name = "miSearch";
			this.miSearch.Size = new System.Drawing.Size(158, 22);
			this.miSearch.Text = "&Поиск";
			this.miSearch.Visible = false;
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(155, 6);
			this.toolStripSeparator9.Visible = false;
			// 
			// miAbout
			// 
			this.miAbout.Name = "miAbout";
			this.miAbout.Size = new System.Drawing.Size(158, 22);
			this.miAbout.Text = "&О программе...";
			this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
			// 
			// tsMain
			// 
			this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPatientAdmission,
            this.tsbPatients,
            this.toolStripSeparator,
            this.tsbConfig,
            this.tsbLog,
            this.tsbHelp,
            this.tsbLock});
			this.tsMain.Location = new System.Drawing.Point(3, 24);
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new System.Drawing.Size(147, 25);
			this.tsMain.TabIndex = 0;
			this.tsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMain_ItemClicked);
			// 
			// tsbPatientAdmission
			// 
			this.tsbPatientAdmission.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPatientAdmission.Image = ((System.Drawing.Image)(resources.GetObject("tsbPatientAdmission.Image")));
			this.tsbPatientAdmission.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPatientAdmission.Name = "tsbPatientAdmission";
			this.tsbPatientAdmission.Size = new System.Drawing.Size(23, 22);
			this.tsbPatientAdmission.Text = "toolStripButton1";
			this.tsbPatientAdmission.ToolTipText = "Приход пациента";
			this.tsbPatientAdmission.Click += new System.EventHandler(this.tsbPatientAdmission_Click);
			// 
			// tsbPatients
			// 
			this.tsbPatients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPatients.Image = global::HospitalDepartment.Properties.Resources.userAccounts;
			this.tsbPatients.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPatients.Name = "tsbPatients";
			this.tsbPatients.Size = new System.Drawing.Size(23, 22);
			this.tsbPatients.Text = "toolStripButton2";
			this.tsbPatients.ToolTipText = "Пациенты";
			this.tsbPatients.Click += new System.EventHandler(this.tsbPatients_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbConfig
			// 
			this.tsbConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbConfig.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfig.Image")));
			this.tsbConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbConfig.Name = "tsbConfig";
			this.tsbConfig.Size = new System.Drawing.Size(23, 22);
			this.tsbConfig.Text = "toolStripButton1";
			this.tsbConfig.ToolTipText = "Конфигурация";
			this.tsbConfig.Click += new System.EventHandler(this.tsbConfig_Click);
			// 
			// tsbLog
			// 
			this.tsbLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbLog.Image = ((System.Drawing.Image)(resources.GetObject("tsbLog.Image")));
			this.tsbLog.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLog.Name = "tsbLog";
			this.tsbLog.Size = new System.Drawing.Size(23, 22);
			this.tsbLog.Text = "toolStripButton1";
			this.tsbLog.ToolTipText = "Журнал системных сообщений";
			this.tsbLog.Click += new System.EventHandler(this.tsbLog_Click);
			// 
			// tsbHelp
			// 
			this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
			this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbHelp.Name = "tsbHelp";
			this.tsbHelp.Size = new System.Drawing.Size(23, 22);
			this.tsbHelp.Text = "He&lp";
			this.tsbHelp.ToolTipText = "О программе";
			this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
			// 
			// tsbLock
			// 
			this.tsbLock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbLock.Image = ((System.Drawing.Image)(resources.GetObject("tsbLock.Image")));
			this.tsbLock.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLock.Name = "tsbLock";
			this.tsbLock.Size = new System.Drawing.Size(23, 22);
			this.tsbLock.Text = "Заблокировать программу";
			this.tsbLock.Click += new System.EventHandler(this.tsbLock_Click);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// dlgBackup
			// 
			this.dlgBackup.Filter = "*.bak|*.bak";
			this.dlgBackup.Title = "Архивирование базы данных";
			// 
			// miAppConfig
			// 
			this.miAppConfig.Name = "miAppConfig";
			this.miAppConfig.Size = new System.Drawing.Size(249, 22);
			this.miAppConfig.Text = "Настройки приложения";
			this.miAppConfig.Click += new System.EventHandler(this.miAppConfig_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 439);
			this.Controls.Add(this.tscMain);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.tscMain.BottomToolStripPanel.ResumeLayout(false);
			this.tscMain.ContentPanel.ResumeLayout(false);
			this.tscMain.TopToolStripPanel.ResumeLayout(false);
			this.tscMain.TopToolStripPanel.PerformLayout();
			this.tscMain.ResumeLayout(false);
			this.tscMain.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer tscMain;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ToolStripMenuItem miPatient;
		private System.Windows.Forms.ToolStripMenuItem miPatientAdmission;
		private System.Windows.Forms.ToolStripMenuItem miFile;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.ToolStripMenuItem miHelp;
		private System.Windows.Forms.ToolStripMenuItem miContents;
		private System.Windows.Forms.ToolStripMenuItem miIndex;
		private System.Windows.Forms.ToolStripMenuItem miSearch;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem miAbout;
		private System.Windows.Forms.ToolStripMenuItem miAdmin;
		private System.Windows.Forms.ToolStripMenuItem miMedicamentsRoot;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton tsbHelp;
		private System.Windows.Forms.ToolStripMenuItem miLog;
		private System.Windows.Forms.ToolStripMenuItem miMedicaments;
		private System.Windows.Forms.ToolStripMenuItem miMedicamentGroups;
		private System.Windows.Forms.ToolStripMenuItem miPatients;
		private System.Windows.Forms.ToolStripMenuItem miConfigRecords;
		private System.Windows.Forms.ToolStripMenuItem miStore;
		private System.Windows.Forms.ToolStripMenuItem miProducts;
		private System.Windows.Forms.ToolStripMenuItem miIncoming;
		private System.Windows.Forms.ToolStripMenuItem miOutgoing;
		private System.Windows.Forms.ToolStripMenuItem miDocuments;
		private HospitalDepartment.UserControls.TasksUserControl ucTasks;
		private System.Windows.Forms.ToolStripButton tsbPatients;
		private System.Windows.Forms.ToolStripButton tsbPatientAdmission;
		private System.Windows.Forms.ToolStripMenuItem miDepartment;
		private System.Windows.Forms.ToolStripMenuItem miUsers;
		private System.Windows.Forms.ToolStripMenuItem miRoles;
		private System.Windows.Forms.ToolStripMenuItem miWards;
		private System.Windows.Forms.ToolStripMenuItem miDataExchange;
		private System.Windows.Forms.ToolStripButton tsbLog;
		private System.Windows.Forms.ToolStripButton tsbConfig;
		private System.Windows.Forms.ToolStripMenuItem miDiagnoses;
		private System.Windows.Forms.ToolStripMenuItem miInsuranceCompanies;
		private System.Windows.Forms.ToolStripMenuItem miSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miAnalysisTypes;
		private System.Windows.Forms.SaveFileDialog dlgBackup;
		private System.Windows.Forms.ToolStripMenuItem miWatchingGroups;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem miNursePatients;
        private System.Windows.Forms.ToolStripButton tsbLock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem miGetMedicaments;
        private System.Windows.Forms.ToolStripMenuItem miUtils;
        private System.Windows.Forms.ToolStripMenuItem miLock;
        private System.Windows.Forms.ToolStripMenuItem miHtmlEditor;
        private System.Windows.Forms.ToolStripMenuItem miBackup;
        private System.Windows.Forms.ToolStripMenuItem miPatientsPrescriptions;
		private System.Windows.Forms.ToolStripMenuItem miConfig;
		private System.Windows.Forms.ToolStripMenuItem miAppConfig;
	}
}