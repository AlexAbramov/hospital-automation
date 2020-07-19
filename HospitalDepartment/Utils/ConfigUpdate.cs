using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDepartment.Utils
{
    class ConfigUpdate
    {
        Config config;
        DepartmentConfig depConfig;
        internal static bool CheckUpdate(Config config)
        {
            ConfigUpdate configUpdate=new ConfigUpdate(config);
            return configUpdate.Update();
        }

        #region Construction
        ConfigUpdate(Config config)
        {
            this.config = config;
            depConfig = config.departmentConfig;
        }
        #endregion

        bool Update()
        {
            int prevVersion = config.version;
            if (config.version < Config.currentVersion)
            {
                for (int ver = config.version + 1; ver <= Config.currentVersion; ver++)
                {
                    Update(ver);
                }
            }
            return prevVersion < config.version;
        }
        void Update(int ver)
        {
            switch (ver)
            {
                case 1:
                    depConfig.temperatureObservationPeriod = 12;
                    config.taskTypes.Add(new TaskType(TaskTypeId.CommonDuration, "Превышен срок пребывания больного в общем отделении"));                    
                    config.taskTypes.Add(new TaskType(TaskTypeId.IntensiveCareDuration, "Превышен срок пребывания больного в ПИТ"));
                    config.taskTypes.Add(new TaskType(TaskTypeId.ReanimationDuration, "Превышен срок пребывания больного в реанимации"));
                    break;
                case 2:
                    config.reportBuilders.Add(new ReportBuilder("PrescriptionsOrder","Требование на получение медикаментов"));
                    config.reports.Add(new Report("Требование на получение медикаментов", "", "HospitalDepartment.Reports.PrescriptionsOrder.rdlc", "PrescriptionsOrder", true));
                    break;
                case 3:
                    Handbook hb = new Handbook("DateAndDurationOfFormerTreatment", "Дата и длительность нахождения на лечении по поводу этого же заболевания",HandbookType.String);
                    config.AddHandbook(HandbookGroupId.PatientData,hb);
                    
                    hb = new Handbook("CentralVenousPressure", "ЦВД", HandbookType.Number);
                    config.AddHandbook(HandbookGroupId.Observation,hb);
                    
                    hb = new Handbook("AccountDate", "Дата счета", HandbookType.Date);
                    hb.nullable = true;
                    config.AddHandbook(HandbookGroupId.PatientIdentification,hb);
                    
                    config.GetHandbookGroup(HandbookGroupId.TemperatureCard).handbooks.Clear();
                    hb = new Handbook("Temperature", "Температура", HandbookType.Number);
                    hb.decimalPlaces=1;
                    hb.defaultValue="36,6";
                    hb.minValue="20";
                    hb.maxValue="45";
                    hb.ItemsList = "35,9;36,9";//morning="35,9;36,5", evening="36,3;36,9"
                    config.AddHandbook(HandbookGroupId.TemperatureCard,hb);
                    break;
                case 4:
                    config.reportBuilders.Add(new ReportBuilder("PatientMedicaments", "Карта персонифицированного учета"));
                    config.reports.Add(new Report("Карта персонифицированного учета", "", "HospitalDepartment.Reports.PatientMedicaments.rdlc", "PatientMedicaments", true));
                    break;
				case 5:
					config.GetHandbookGroup(HandbookGroupId.ConsultationData).handbooks.Add(new Handbook("Conclusion", "Заключение", HandbookType.String, 5));
					config.GetHandbookGroup(HandbookGroupId.SanatoriumTransfer).handbooks.Add(new Handbook("PatientState", "Состояние больного", HandbookType.String, 3));
					break;
				default: 
                    return;
            }
            System.Diagnostics.Debug.Assert(config.version < ver);
            config.version = ver;
        }
    }
}
