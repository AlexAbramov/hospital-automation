using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class Document
	{
		int id=0;
		public DateTime date = DateTime.Now;
		public int userId=0;
		public DocumentTypeId documentTypeId;
		public bool completed=false;
        public int storekeeperId = 0;
        public int nDays = 1;
        public DocumentData documentData;

        public int Id { get { return id; } }
        public bool IsNew { get { return id==0; } }

		#region Construction
		public static Document GetDocument(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Documents where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Document(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Documents where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
        public static int RemoveDocumentProducts(GmConnection conn, int documentId)
        {
            GmCommand cmd = conn.CreateCommand("delete from DocumentProducts where DocumentId=@DocumentId");
            cmd.AddInt("DocumentId", documentId);
            return cmd.ExecuteNonQuery();
        }
        public Document(DocumentTypeId documentTypeId)
		{
			this.documentTypeId = documentTypeId;
            documentData = new DocumentData();
		}
		public Document(DbDataReader dr)
		{
			GmDataReader gr=new GmDataReader(dr);
			id = gr.GetInt32();
			date = gr.GetDateTime();
			userId = gr.GetInt32();
			documentTypeId = (DocumentTypeId)gr.GetInt32();
            completed = gr.GetBoolean();
            storekeeperId = gr.GetInt32();
            nDays = gr.GetInt32();
			documentData = DocumentData.DeserializeString(gr.GetString());
        }
		#endregion

		public void Save(GmConnection conn, DbTransaction trans)
		{
			GmCommand cmd = conn.CreateCommand(trans);
			cmd.AddInt("Id", id);
			cmd.AddDateTime("Date", date);
			cmd.AddInt("UserId", userId);
			cmd.AddInt("DocumentTypeId", (int)documentTypeId);
			cmd.AddBoolean("Completed", completed);
            cmd.AddInt("StorekeeperId", storekeeperId);
            cmd.AddInt("NDays", nDays);
            cmd.AddString("DocumentData", documentData.GetXmlString());
            if (id == 0)
			{
                cmd.CommandText = "insert into Documents values (@Date,@UserId,@DocumentTypeId,@Completed,@StorekeeperId,@NDays,@DocumentData) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
                cmd.CommandText = "update Documents set Date=@Date,UserId=@UserId,DocumentTypeId=@DocumentTypeId,Completed=@Completed,StorekeeperId=@StorekeeperId,NDays=@NDays,DocumentData=@DocumentData where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
	}
}