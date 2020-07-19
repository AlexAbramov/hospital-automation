using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.UserControls
{
	public partial class ConfigRecordUserControl : UserControl
	{
		bool readOnly=false;
		public string Comment { get { return tbComment.Text; } set { tbComment.Text = value; } }
		ConfigRecord configRecord;
		public void Init(ConfigRecord configRecord, bool readOnly) { this.configRecord = configRecord; this.readOnly = readOnly; }
		public ConfigRecordUserControl()
		{
			InitializeComponent();
		}

		private void ConfigRecordUserControl_Load(object sender, EventArgs e)
		{
            if (!DesignMode)
            {
				LoadData();
                UpdateControls();
            }
		}

		private void LoadData()
		{
			StringBuilder sb = new StringBuilder(200);
			sb.AppendLine("Номер конфигурации: " + configRecord.Id);
			sb.AppendLine("Номер восстановленной конфигурации: " + configRecord.restoredId);
			sb.AppendLine("Пользователь: " + App.Instance.AppCache.GetUserName(configRecord.userId));
			sb.AppendLine("Версия схемы: " + configRecord.version);
			sb.AppendLine("Дата изменения: " + configRecord.time.ToString());
			if (readOnly)
			{
				tbComment.ReadOnly = true;
				tbComment.Text = configRecord.comment;
			}
			else sb.AppendLine("Комментарий: " + configRecord.comment);
			tbInfo.Text = sb.ToString();
		}

		private void UpdateControls()
		{
		}

	}
}
