using System;
using System.Data;
using System.Configuration;

namespace HospitalDepartment
{
	// Database
    public enum Status { Removed=-1, Normal=0}
	public enum RoleId { Admin=1, Chief=2 }
	public enum GenderId { Null=0, Male = 1, Female = 2 }
	public enum TaskStateId { Created = 1, Accepted = 2, Completed = 3 }
    public enum WardTypeId { Common = 1, IntensiveCare = 2, Reanimation = 3, Corridor=4 }
	public enum PatientTypeId { Common = 1, IntensiveCare = 2, Reanimation = 3 }
	public enum PrescriptionTypeId { IntravenousInjection = 1, IntramuscularInjection = 2, HypodermicInjection=3, Inner = 4, Outer = 5}
	public enum ObservationTypeId { Diary = 1, DoctorRound = 2, ChiefRound = 3, TemperatureCard=4 }
	public enum PermissionId// Permission, Action, Permission, Access, Function, TaskType
	{
        Null=0,
        File=100, FileDataExchange,
        Patient = 200, PatientAdmission, PatientList, PatientListNurse,
        Medicaments=300, MedicamentList, MedicamentGroups, Medicament, MedicamentGroup,
        Store=400, StoreProducts=401, StoreDocuments=402,
        Department = 500, DepartmentUsers = 501, DepartmentRoles = 502, DepartmentWards = 503, DepartmentWatchingGroups = 504,
        Admin = 600, AdminConfig = 601, AdminAnalysisTypes = 602, AdminDiagnoses = 603, AdminInsuranceCompanies=604, AdminBackup=605, AdminLog = 606
/*		Roles = 1, Role = 2, Users = 4, User = 5, Log = 6,
		Medicament = 8, Medicaments = 9, MedicamentGroup = 10, MedicamentGroups = 11,
		Upload = 13, PatientAdmission = 15, Patient = 16*/
	}
    public enum TaskTypeId 
    { 
        Null=0,
        Diary = 1, DoctorRound, ChiefRound, TemperatureCard,
        SetClinicDiagnosis=100,
        CommonDuration=200, IntensiveCareDuration, ReanimationDuration
    }
	public enum DischargeTypeId { None = 0, Discharge = 1, DepartmentTransfer = 2, SanatoriumTransfer=3, Postmortal=4  }
	public enum DocumentTypeId { Incoming=1, Outgoing=2, PrescriptionsOrder=3}
	
	// Configuration
	public enum HospitalType { High, First, Second, Day }
	public enum HandbookGroupId { PatientData, PatientDescription, Observation, DoctorRound, ChiefRound, PatientIdentification, Discharge, DepartmentTransfer, SanatoriumTransfer, Postmortal, PatientDiagnoses, ConsultationData, TemperatureCard, ReacardData }
//	public enum PatientDataHandbookId { Company, Profession, Regimen, SickListCause }
	public enum PatientDiagnosesHandbookId { DirectionalDiagnosis, ComplicationDiagnosis, ConcomitantDiagnosis }
}