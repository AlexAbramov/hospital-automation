using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
    public class Task
    {
        TaskTypeId taskTypeId;
        public string header="";
        public string text="";
        public TaskTypeId TaskTypeId { get { return taskTypeId; } }
        public string Header { get { return header; } }
        public string Text { get { return text; } }
        public Task(TaskTypeId taskTypeId) { this.taskTypeId = taskTypeId; }
        public Task(TaskTypeId taskTypeId, string header, string text) { this.taskTypeId = taskTypeId; this.header = header; this.text = text; }
        public Task(TaskType taskType, string text) { this.taskTypeId = taskType.Id; this.header = taskType.name; this.text = text; }
        public Task(Task task) { this.taskTypeId = task.taskTypeId; this.header = task.header; this.text = task.text; }
    }
/*	public class Task
	{
		int id = 0;
		public PermissionId permission = PermissionId.Dummy;
		public int userId = 0;
		public string page = "";
		public TaskStatusId taskStatus = TaskStatusId.Created;
		public DateTime whenCreated = DateTime.Now;
		public DateTime whenAccepted = DateTime.MinValue;
		public DateTime whenCompleted = DateTime.MinValue;

		public int Id { get { return id; } }

		#region Static
		public static Patient GetTask(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Tasks where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Patient(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Tasks where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		#endregion

		#region Construction
		public Task()
		{

		}
		public Task(DbDataReader dr)
		{
			GmDataReader gr=new GmDataReader(dr);
			int i = 0;
			id = dr.GetInt32(i++);
			permission = (PermissionId)dr.GetInt32(i++);
			userId = dr.GetInt32(i++);
			page = dr.GetString(i++);
			taskStatus = (TaskStatusId)dr.GetInt32(i++);
			whenCreated = gr.GetDateTime(i++);
			whenAccepted = gr.GetDateTime(i++);
			whenCompleted = gr.GetDateTime(i++);
		}
		#endregion

		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddInt("PermissionId", (int)permission);
			cmd.AddInt("UserId", userId);
			cmd.AddString("Page", page);
			cmd.AddInt("TaskStatusId", (int)taskStatus);
			cmd.AddDateTime("WhenCreated", whenCreated);
			cmd.AddDateTime("WhenAccepted", whenAccepted);
			cmd.AddDateTime("WhenCompleted", whenCompleted);
			if (id == 0)
			{
				cmd.CommandText = "insert into Tasks values (@PermissionId,@UserId,@Page,@TaskStatusId,@WhenCreated,@WhenAccepted,@WhenCompleted) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
				//			cmd.CommandText = "update Tasks set @PermissionId,@UserId,@Page,@TaskStatusId,@WhenCreated,WhenAccepted=@WhenAccepted,WhenCompleted=@WhenCompleted where Id=@Id";
				//			cmd.ExecuteNonQuery();
			}
		}
	}*/
}