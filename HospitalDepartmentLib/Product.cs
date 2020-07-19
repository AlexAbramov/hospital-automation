using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class Product
	{
		int id=0;
		public string code="";
		public string name="";
		public int packedNumber=1;
		public int medicamentId = 0;
		public string maker = "";
		public int baseUnitId = 0;
		public decimal unitCount = 0;
        public string medLists = "";

		public int Id { get { return id; } }

		#region Construction
		public static Product GetProduct(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from Products where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new Product(dr);
			}
			return null;
		}
		public static int Remove(GmConnection conn, int id)
		{
			GmCommand cmd = conn.CreateCommand("delete from Products where Id=@Id");
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public Product()
		{ 
		}
		public Product(DbDataReader dr)
		{
			int i = 0;
			id = dr.GetInt32(i++);
			code = dr.GetString(i++);
			name = dr.GetString(i++);
			packedNumber = dr.GetInt32(i++);
			medicamentId = dr.GetInt32(i++);
			maker = dr.GetString(i++);
			baseUnitId = dr.GetInt32(i++);
			unitCount = dr.GetDecimal(i++);
            medLists = dr.GetString(i++);
        }
		#endregion

		public void Save(GmConnection conn)
		{
			GmCommand cmd = conn.CreateCommand();
			cmd.AddInt("Id", id);
			cmd.AddString("Name", name);
			cmd.AddString("Code", code);
			cmd.AddInt("PackedNumber", packedNumber);
			cmd.AddInt("MedicamentId", medicamentId);
			cmd.AddString("Maker", maker);
			cmd.AddInt("BaseUnitId", baseUnitId);
			cmd.AddDecimal("UnitCount", unitCount);
            cmd.AddString("MedLists", medLists);
            if (id == 0)
			{
                cmd.CommandText = "insert into Products values (@Code,@Name,@PackedNumber,@MedicamentId,@Maker,@BaseUnitId,@UnitCount,@MedLists) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
                cmd.CommandText = "update Products set Code=@Code,Name=@Name,PackedNumber=@PackedNumber,MedicamentId=@MedicamentId,Maker=@Maker,BaseUnitId=@BaseUnitId,UnitCount=@UnitCount,MedLists=@MedLists where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
	}
}