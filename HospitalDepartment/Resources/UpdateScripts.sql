-- ScriptId=3

update Patients set Status=1
update Medicaments set Status=1
update MedicamentGroups set Status=1

-- ScriptId=2

CREATE TABLE [ConfigRecords](
	[Id] [int] NOT NULL PRIMARY KEY,
	[RestoredId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Version] [int] NOT NULL,
	[Time] [datetime] NOT NULL,
	[Config] [varchar](max) NOT NULL,
	[Comment] [varchar](8000) NOT NULL
	)

-- ScriptId=1

insert into WatchingGroups values ('Врачи')
insert into WatchingGroups values ('Медсестры')

insert into BaseUnits values ('мг.','мг.')
insert into BaseUnits values ('мл.','мл.')
insert into BaseUnits values ('шт.','шт.')
insert into BaseUnits values ('г.','г.')

insert into AnalysisTypes values ('Анализ мочи по Ничипаренко','','UrineAnalysisN')
insert into AnalysisTypes values ('Анализ мочи по Земницкому','','UrineAnalysisZ')
insert into AnalysisTypes values ('Анализ мочи','3','UrineAnalysis')
insert into AnalysisTypes values ('Общий анализ крови','12','BloodTest')
insert into AnalysisTypes values ('Биохимический анализ крови','27','BiochemicalBloodTest')
insert into AnalysisTypes values ('Биохимическая коагулограмма','17','BiochemicalCoagulogram')
insert into AnalysisTypes values ('АПТВ','','APTV')
insert into AnalysisTypes values ('КФК','','KFK')
insert into AnalysisTypes values ('ПТИ','18','PTI')
insert into AnalysisTypes values ('ЭКГ','','ECG')
insert into AnalysisTypes values ('RW','','RW')
insert into AnalysisTypes values ('МНО','','MNO')
insert into AnalysisTypes values ('Группа крови и резус фактор','','BloodGroupAndRhesusFactor')

insert into LogTypes values(1,'Информация')
insert into LogTypes values(2,'Предупреждение')
insert into LogTypes values(3,'Ошибка')
insert into LogTypes values(4,'Исключительная ситуация')
insert into LogTypes values(5,'Пользовательское сообщение')

insert into DocumentTypes values(1,'Приход')
insert into DocumentTypes values(2,'Расход')
insert into DocumentTypes values(3,'Требование на получение медикаментов')

insert into DischargeTypes values(1,'Выписка')
insert into DischargeTypes values(2,'Перевод в другое отделение')
insert into DischargeTypes values(3,'Перевод в санаторий')
insert into DischargeTypes values(4,'Посмертный')

insert into ObservationTypes values(1,'Дневник наблюдения')
insert into ObservationTypes values(2,'Этапный эпикриз')
insert into ObservationTypes values(3,'Обход заведующего')
insert into ObservationTypes values(4,'Температура')

insert into PrescriptionTypes values(1,'Внутривенная инъекциия','в/в')
insert into PrescriptionTypes values(2,'Внутримышечная инъекция','в/м')
insert into PrescriptionTypes values(3,'Подкожная инъекция','п/к')
insert into PrescriptionTypes values(4,'Внутреннее','вн')
insert into PrescriptionTypes values(5,'Наружное','нар')

insert into PatientTypes values(1,'Обычный')
insert into PatientTypes values(2,'ПИТ')
insert into PatientTypes values(3,'Реанимационный')

insert into WardTypes values(1,'Общая')
insert into WardTypes values(2,'ПИТ')
insert into WardTypes values(3,'Реанимация')
insert into WardTypes values(4,'Коридор')

insert into TaskStates values(1,'Новая')
insert into TaskStates values(2,'Принята')
insert into TaskStates values(3,'Завершена')

insert into Genders values(1,'Мужской')
insert into Genders values(2,'Женский')


-- ScriptId=0

CREATE TABLE [Patients](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[PassportId] [int] NOT NULL,
	[InsuranceId] [int] NOT NULL,
	[PatientIdentificationId] [int] NOT NULL,
	[DoctorId] [int] NOT NULL,
	[DiagnosisId] [int] NOT NULL DEFAULT ((0)),
	[PatientData] [varchar](max) NOT NULL DEFAULT (''),
	[PatientDescription] [varchar](max) NOT NULL DEFAULT (''),
	[AdmissionDate] [datetime] NOT NULL,
	[WardId] [int] NOT NULL,
	[PatientTypeId] [int] NOT NULL DEFAULT ((0)),
	[DischargeTypeId] [int] NOT NULL DEFAULT ((0)),
	[DischargeData] [varchar](max) NULL,
	[DischargeDate] [datetime] NULL,
	[PatientDiagnoses] [varchar](max) NULL,
	[DietNumber] [varchar](10) NOT NULL DEFAULT (''),
	[Status] [int] NOT NULL DEFAULT ((1))
	)

CREATE TABLE [BaseUnits](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL,
	[ShortName] [varchar](50) NOT NULL
	)

CREATE TABLE [Medicaments](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL,
	[Status] [int] NOT NULL DEFAULT ((1))
	)

CREATE TABLE [Watching](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[UserId] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NULL,
	[Data] [varchar](8000) NULL
	)

CREATE TABLE [Units](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL,
	[ProductId] [int] NOT NULL,
	[BaseUnitId] [int] NOT NULL,
	[Coef] [decimal](18, 0) NOT NULL
	)

CREATE TABLE [InsuranceCompanies](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL
	)

CREATE TABLE [WatchingSchemes](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[UserId] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Data] [varchar](8000) NULL
	)

CREATE TABLE [WatchingGroups](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [varchar](200) NULL
	)

CREATE TABLE [PrescriptionTypes](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL,
	[ShortName] [varchar](50) NOT NULL DEFAULT ('')
	)

CREATE TABLE [WardTypes](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL
	)

CREATE TABLE [MedicamentGroups](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL,
	[Status] [int] NOT NULL DEFAULT ((1))
	)

CREATE TABLE [MedicamentGroupTies](
	[MedicamentId] [int] NOT NULL,
	[MedicamentGroupId] [int] NOT NULL
	)

CREATE TABLE [Log](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Time] [datetime] NOT NULL,
	[Ip] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[LogType] [int] NOT NULL,
	[Header] [varchar](200) NULL,
	[Message] [varchar](8000) NULL
	)

CREATE TABLE [Complaints](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Time] [datetime] NOT NULL,
	[CaseHistoryId] [int] NOT NULL,
	[Complaint] [varchar](max) NOT NULL
	)

CREATE TABLE [DocumentTypes](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](200) NULL
	)

CREATE TABLE [Products](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY ,
	[Code] [varchar](10) NOT NULL UNIQUE,
	[Name] [varchar](50) NOT NULL,
	[PackedNumber] [int] NOT NULL,
	[MedicamentId] [int] NOT NULL,
	[Maker] [varchar](50) NOT NULL DEFAULT (''),
	[BaseUnitId] [int] NOT NULL DEFAULT ((0)),
	[UnitCount] [decimal](18, 0) NOT NULL DEFAULT ((1)),
	[MedLists] [varchar](50) NOT NULL DEFAULT ('')
	)

CREATE TABLE [Insurances](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY ,
	[InsuranceCompanyId] [int] NOT NULL,
	[Number] [varchar](50) NOT NULL,
	[Series] [varchar](50) NOT NULL,
	[Delo] [varchar](50) NOT NULL
	)


CREATE TABLE [Prescriptions](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[PatientId] [int] NOT NULL,
	[PrescriptionTypeId] [int] NOT NULL,
	[StoreProductId] [int] NOT NULL,
	[Dose] [decimal](18, 0) NOT NULL,
	[Multiplicity] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Duration] [int] NOT NULL DEFAULT ((0)),
	[ReanimationFlag] [bit] NOT NULL DEFAULT ((0))
	)

CREATE TABLE [StoreProducts](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY ,
	[ProductId] [int] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[ExpiredDate] [datetime] NULL,
	[CurrentCount] [decimal](18, 0) NOT NULL DEFAULT ((0)),
	[ReservedCount] [decimal](18, 0) NOT NULL DEFAULT ((0)),
	[Series] [varchar](50) NOT NULL DEFAULT ('')
	)


CREATE TABLE [DiagnosisGroupTies](
	[DiagnosisId] [int] NOT NULL,
	[MedicamentGroupId] [int] NOT NULL
	)


CREATE TABLE [TaskTypes](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL
	)

CREATE TABLE [Tasks](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[TaskTypeId] [int] NOT NULL,
	[SenderId] [int] NOT NULL DEFAULT ((0)),
	[ReceiverId] [int] NOT NULL DEFAULT ((0)),
	[Text] [varchar](500) NOT NULL DEFAULT (''),
	[TaskStateId] [int] NOT NULL,
	[WhenCreated] [datetime] NOT NULL,
	[WhenAccepted] [datetime] NULL,
	[WhenCompleted] [datetime] NULL
	)

CREATE TABLE [TaskStates](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL
	)

CREATE TABLE [Roles](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY ,
	[Name] [varchar](50) NOT NULL,
	[Permissions] [varbinary](max) NULL,
	[WatchingGroupId] [int] NOT NULL DEFAULT ((0))
	)

CREATE TABLE [Wards](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Number] [varchar](50) NOT NULL,
	[WardTypeId] [int] NOT NULL,
	[NumberOfBeds] [int] NOT NULL
	)

CREATE TABLE [PatientTypes](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL
	)

CREATE TABLE [Observations](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[PatientId] [int] NOT NULL,
	[DoctorId] [int] NOT NULL,
	[Time] [datetime] NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[ObservationTypeId] [int] NOT NULL DEFAULT ((1))
	)

CREATE TABLE [DoctorRounds](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[PatientId] [int] NOT NULL,
	[DoctorId] [int] NOT NULL,
	[Time] [datetime] NOT NULL,
	[Description] [varchar](max) NOT NULL
	)

CREATE TABLE [Passports](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[SerialNumber] [varchar](50) NOT NULL,
	[IssueDepartment] [varchar](50) NOT NULL,
	[IssueDate] [datetime] NOT NULL,
	[DepartmentCode] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NOT NULL,
	[Gender] [int] NOT NULL,
	[Birthday] [datetime] NOT NULL,
	[BirthPlace] [varchar](50) NOT NULL,
	[Registration] [varchar](50) NOT NULL
	)

CREATE TABLE [ObservationTypes](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL
	)

CREATE TABLE [Diets](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Number] [varchar](50) NOT NULL
	)

CREATE TABLE [Diagnoses](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Code] [varchar](10) NOT NULL DEFAULT (''),
	[Name] [varchar](500) NOT NULL,
	[HospitalStayHigh] [int] NOT NULL DEFAULT ((0)),
	[HospitalStayFirst] [int] NOT NULL DEFAULT ((0)),
	[HospitalStaySecond] [int] NOT NULL DEFAULT ((0)),
	[HospitalStayDay] [int] NOT NULL DEFAULT ((0)),
	[MCode] [varchar](50) NOT NULL DEFAULT ('')
	)

CREATE TABLE [PatientConsultations](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[PatientId] [int] NOT NULL,
	[RequestDate] [datetime] NOT NULL,
	[ExecutionDate] [datetime] NULL,
	[ConsultationData] [varchar](max) NOT NULL
	)

CREATE TABLE [AnalysisTypes](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL,
	[Code] [varchar](50) NULL,
	[HandbookGroupId] [varchar](50) NULL
	)

CREATE TABLE [DischargeTypes](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL
	)

CREATE TABLE [ExpertBoards](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[PatientId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[ExpertBoardData] [varchar](max) NULL
	)

CREATE TABLE [Users](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL DEFAULT (''),
	[RoleId] [int] NOT NULL,
	[Login] [varchar](50) NOT NULL UNIQUE,
	[Password] [varchar](50) NOT NULL,
	[Permissions] [varbinary](max) NULL
	)

CREATE TABLE [Analyses](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[PatientId] [int] NOT NULL,
	[AnalysisTypeId] [int] NOT NULL,
	[RequestDate] [datetime] NOT NULL,
	[ExecutionDate] [datetime] NULL,
	[AnalysisData] [varchar](max) NOT NULL
	)

CREATE TABLE [Reacards](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[PatientId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[ReacardData] [varchar](max) NULL
	)

CREATE TABLE [LogTypes](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL
	)

CREATE TABLE [PatientIdentifications](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Surname] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[Gender] [int] NULL,
	[Birthday] [datetime] NULL,
	[IdentificationData] [varchar](max) NULL
	)

CREATE TABLE [DocumentProducts](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[DocumentId] [int] NOT NULL,
	[StoreProductId] [int] NOT NULL,
	[Count] [decimal](18, 0) NOT NULL,
	[PlannedCount] [decimal](18, 0) NOT NULL DEFAULT ((0))
	)

CREATE TABLE [Documents](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Date] [datetime] NOT NULL,
	[UserId] [int] NOT NULL,
	[DocumentTypeId] [int] NOT NULL,
	[Completed] [bit] NOT NULL,
	[StorekeeperId] [int] NOT NULL,
	[NDays] [int] NOT NULL DEFAULT ((0)),
	[DocumentData] [varchar](8000) NULL
	)

CREATE TABLE [Genders](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](50) NOT NULL
	)

CREATE TABLE [PatientWardHistory](
	[Id] [int] IDENTITY NOT NULL PRIMARY KEY,
	[PatientId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[WardId] [int] NOT NULL,
	[PatientTypeId] [int] NOT NULL DEFAULT ((1))
	)
	