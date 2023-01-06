using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.WinApp
{
	public class ProductRepository
	{
		public IEnumerable<ProductDto> Search(int? categoryId = null, string productName = null)
		{
			SqlDb.ApplicationName = "demo:search products";//方便sql profiler查看

			#region 生成sql statement
			string sql = $@"
Select P.*, C.Name as CategoryName 
from Products as P
inner join Categories as C on P.categoryId = c.Id";

			string where = string.Empty;

			var parameters = new List<SqlParameter>();

			if (categoryId.HasValue)
			{
				//前面要加空白,才不會跟上面黏在一起,sql會錯
				where += $" And P.categoryId = {categoryId.Value}";
			}
			if (string.IsNullOrEmpty(productName) == false)
				{
					//前面要加空白,才不會跟上面黏在一起,sql會錯
					where += $" And P.Name like '%' + @productName + '%'";
					parameters.Add(new SqlParameter("@productName", System.Data.SqlDbType.NVarChar, 50) { Value = productName });

				}
			where = where == string.Empty ? where : where = " where " + where.Substring(5);
			sql += where;
			
			//前面要加空白,才不會跟上面黏在一起,sql會錯
			sql += " Order by c.DisplayOrder";
			#endregion
			return SqlDb.Search(SqlDb.GetConnection, ProductDto.GetInstance, sql, parameters.ToArray());
			//using (var conn = SqlDb.GetConnection())
			//{
			//	using (var cmd = conn.CreateCommand())
			//	{
			//		conn.Open();
			//		cmd.CommandText = sql;
			//		cmd.Parameters.AddRange(parameters.ToArray());

			//		var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

			//		//List<ProductDto> items = new List<ProductDto>();

			//		while (reader.Read())
			//		{
			//			var dto = ProductDto.GetInstance(reader);
			//			yield return dto;
			//			//items.Add(dto);
			//		}
			//		//return items
			//	}
			//}
		}

	}
	public class ProductDto
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public static ProductDto GetInstance(SqlDataReader reader)
		{
			return new ProductDto
			{
				Id = reader.GetFieldValue<int>("Id"),
				CategoryName = reader.GetFieldValue<string>("CategoryName"),
				Name = reader.GetFieldValue<string>("Name"),
				Price = reader.GetFieldValue<int>("Price")
			};
		}
	}
}
