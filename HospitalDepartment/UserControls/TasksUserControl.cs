using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Data;
using HospitalDepartment.Utils;
using HospitalDepartment.Forms;
using Geomethod.Windows.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class TasksUserControl : UserControl
	{
        public void Init()
		{
		}

        public Task SelectedTask
        {
            get
            {
                return GridViewUtils.GetSelectedDataBoundItem(gridView) as Task;
            }
        }

		public TasksUserControl()
		{
			InitializeComponent();
		}

		private void TasksUserControl_Load(object sender, EventArgs e)
		{
			if (base.DesignMode) return;
        }

/*		private void LoadData()
		{
			string cmdText = @"
select Tasks.*, TaskTypes.Name as TaskTypeName, TaskStates.Name as TaskStateName
from Tasks 
left join TaskTypes on TaskTypeId=TaskTypes.Id
left join TaskStates on TaskStateId=TaskStates.Id
";
			using (GmConnection conn = App.CreateConnection())
			{
				conn.Fill(dataTable, cmdText);
			}
			gridView.DataSource = dataTable;
		}*/

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            App.MainForm.UpdateTaskList(false);
        }

        internal void UpdateTaskList()
        {
            this.SuspendLayout();
            gridView.SuspendLayout();
            bindingSource.Clear();
            lock (App.TaskManager.TaskList)
            {
                foreach (Task task in App.TaskManager.TaskList)
                {
                    bindingSource.Add(new Task(task));
                }
            }
            gridView.ResumeLayout();
            this.ResumeLayout();
            UpdateControls();
        }

        private void gridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenTask();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenTask();
        }

        void UpdateControls()
        {
            Task task = SelectedTask;
            btnOpen.Enabled = task != null;
        }

        private void OpenTask()
        {
            Task task = SelectedTask;
            if(task!=null)
            {
                var form = new Geomethod.Windows.Forms.TextForm(true);
                form.TextValue=task.text;
                form.Text = task.Header;
                form.ReadOnly = true;
                form.ShowDialog();
            }
        }
    }
}
