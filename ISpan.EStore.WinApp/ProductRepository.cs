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
		private readonly string _tableName = "Products";
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, ProductDto> funcAssembler = ProductDto.GetInstance;

		public int Create(ProductDto productDto)
		{
			string sql = $@"insert into {_tableName}
(CategoryId, Name, Price)
values
(@CategoryId, @Name, @Price)";

			var parameters = SqlParameterBuilder.Create()
					.AddInt("@CategoryId", productDto.CategoryId)
					.AddNVarchar("@Name", productDto.Name, 50)
					.AddInt("@Price", productDto.Price)
					.Build();
			
			return SqlDb.Create(funcConn, sql, parameters);

		}
		public int Update(ProductDto productDto)
		{
			string sql = $@"Update {_tableName} set
Name = @Name,
CategoryId = @CategoryId,
Price = @Price
where Id = {productDto.Id} ";

			var parameters = SqlParameterBuilder.Create()
					.AddNVarchar("@Name", productDto.Name, 50)
					.AddInt("@CategoryId", productDto.CategoryId)
					.AddInt("@Price", productDto.Price)
					.Build();
			int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql, parameters);
			return rowsAffected;
		}

		public int Delete(int productId)
		{
			string sql = $@"DELETE FROM {_tableName} WHERE Id = @Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("Id", productId)
				.Build();
			return SqlDb.UpdateOrDelete(funcConn, sql, parameters);
		}

		public ProductDto GetProduct(int productId)
		{
			string sql = $@"SELECT P.*, C.Name as CategoryName 
FROM {_tableName} as P inner join Categories as C
on P.categoryId = c.Id 
WHERE P.Id = {productId}";

			return SqlDb.Get(funcConn, funcAssembler, sql);
		}

		public IEnumerable<ProductDto> Search(int? categoryId = null, string productName = null)
		{
			SqlDb.ApplicationName = "demo:search products";//方便sql profiler查看

			#region 生成sql statement
			string sql = $@"
Select P.*, C.Name as CategoryName 
from {_tableName} as P
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
		public int? Price { get; set; }
		public int? CategoryId { get; set; }
		public static ProductDto GetInstance(SqlDataReader reader)
		{
			return new ProductDto
			{
				CategoryId = reader.GetFieldValue<int>("CategoryId"),
				Id = reader.GetFieldValue<int>("Id"),
				CategoryName = reader.GetFieldValue<string>("CategoryName"),
				Name = reader.GetFieldValue<string>("Name"),
				Price = reader.GetFieldValue<int>("Price")
			};
		}
	}
}
