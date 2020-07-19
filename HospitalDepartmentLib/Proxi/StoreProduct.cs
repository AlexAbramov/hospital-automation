using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
	public class StoreProduct
	{
		int id;
		public int productId;
		public decimal price;
		public DateTime expiredDate;
		public decimal currentCount;
		public decimal reservedCount;
        public string series;

		public int Id { get { return id; } }

		#region Construction
/*		public static StoreProduct GetStoreProduct(GmConnection conn, int id)
		{
			if (id == 0) return null;
			GmCommand cmd = conn.CreateCommand("select * from StoreProducts where Id=@Id");
			cmd.AddInt("Id", id);
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read()) return new StoreProduct(dr);
			}
			return null;
		}*/
        public static int Remove(GmConnection conn, int id, DbTransaction trans)
		{
            GmCommand cmd = conn.CreateCommand("delete from StoreProducts where Id=@Id", trans);
			cmd.AddInt("Id", id);
			return cmd.ExecuteNonQuery();
		}
		public StoreProduct()
		{ 
		}
		public StoreProduct(DataRow dr)
		{
			id=(int)dr["StoreProductId"];
			productId=(int)dr["ProductId"];
			price=(decimal)dr["Price"];
			expiredDate = DateTimeUtils.GetNullableTime(dr["ExpiredDate"]);
			currentCount = (decimal)dr["CurrentCount"];
			reservedCount = (decimal)dr["ReservedCount"];
            series = (string)dr["Series"];
		}
		#endregion

        public void Save(DataRow dr)
        {
            dr["ProductId"] = productId;
            dr["Price"] = price;
            dr["ExpiredDate"] = DateTimeUtils.GetNullableTime(expiredDate);
            dr["CurrentCount"] = currentCount;
            dr["ReservedCount"] = reservedCount;
            dr["Series"] = series;
        }

		public void Save(GmConnection conn,DbTransaction trans)
		{
			GmCommand cmd = conn.CreateCommand(trans);
			cmd.AddInt("Id", id);
			cmd.AddInt("ProductId", productId);
			cmd.AddDecimal("Price", price);
			cmd.AddNullableDateTime("ExpiredDate", expiredDate);
			cmd.AddDecimal("CurrentCount", currentCount);
            cmd.AddDecimal("ReservedCount", reservedCount);
            cmd.AddString("Series", series);
            if (id == 0)
			{
				cmd.CommandText = "insert into StoreProducts values (@ProductId,@Price,@ExpiredDate,@CurrentCount,@ReservedCount,@Series) select @@Identity";
				id = (int)(decimal)cmd.ExecuteScalar();
			}
			else
			{
                cmd.CommandText = "update StoreProducts set ProductId=@ProductId,Price=@Price,ExpiredDate=@ExpiredDate,CurrentCount=@CurrentCount,ReservedCount=@ReservedCount,Series=@Series where Id=@Id";
				cmd.ExecuteNonQuery();
			}
		}
	}
}