using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.WinApp
{
    public class CategoryRepository
    {
		private readonly string _tableName = "Categories";
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, Category> funcAssembler = Category.GetInstance;
		public int Create(Category category)
		{
			string sql = $@"insert into {_tableName}
(Name, DisplayOrder)
values
(@Name, @DisplayOrder)";

			var parameters = SqlParameterBuilder.Create()
					.AddNVarchar("@Name", category.Name, 50)
					.AddInt("@DisplayOrder", category.DisplayOrder)
					.Build();

			return SqlDb.Create(funcConn, sql, parameters);
		}

		public int Delete(int categoryId)
		{
			string sql = $@"DELETE FROM {_tableName} WHERE Id = @Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("Id", categoryId)
				.Build();
			return SqlDb.UpdateOrDelete(funcConn, sql, parameters);
		}

		public int Update(Category category)
		{
			string sql = $@"Update {_tableName} set
Name = @Name,
DisplayOrder = @DisplayOrder
where Id = {category.Id} ";

			var parameters = SqlParameterBuilder.Create()
					.AddNVarchar("@Name", category.Name, 50)
					.AddInt("@DisplayOrder", category.DisplayOrder)
					.Build();
			int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql, parameters);
			return rowsAffected;
		}

		public IEnumerable<Category> Search(string name, int? displayOrder = null)
		{
			#region 生成sql statement
			string sql = $@"Select * from {_tableName}";

			string where = string.Empty;

			var parameters = new List<SqlParameter>();

			if (string.IsNullOrEmpty(name) == false)
			{
				where += $" And Name like '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
			}

			if (displayOrder.HasValue)
			{
				//前面要加空白,才不會跟上面黏在一起,sql會錯
				where += $" And DisplayOrder = {displayOrder.Value}";
			}

			where = where == string.Empty ? where : where = " where " + where.Substring(5);
			sql += where;
			#endregion

			return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
		}
		public Category GetCategory(int categoryId)
        {
            string sql = $"Select * from Categories where Id = {categoryId}";

			return SqlDb.Get(funcConn, funcAssembler, sql);

			//using (var conn = SqlDb.GetConnection())
			//{
			//    Category category = null;
			//    using (var command = new SqlCommand(sql, conn))
			//    {
			//        conn.Open();

			//        var reader = command.ExecuteReader();

			//        if (reader.Read())
			//        {
			//            return Category.GetInstance(reader);
			//            //category = new Category
			//            //{
			//            //    Id = categoryId,
			//            //    Name = reader.GetFieldValue<string>("Name"),
			//            //    DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
			//            //    //Name = reader["Name"].ToString(),
			//            //    //DisplayOrder = int.Parse(reader["DisplayOrder"].ToString())
			//            //    //此處使用擴充方法優化
			//            //};
			//        }
			//    }
			//    return category;
			//}

		}
		public int GetProductCount(int categoryId)
        {
			string sql = $"Select count(*) from Products where CategoryId = {categoryId}";
			using (var conn = SqlDb.GetConnection())
            {
                using (var command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DisplayOrder { get; set; }

        public static Category GetInstance(SqlDataReader reader)
        {
            return new Category
            {
                Id = reader.GetFieldValue<int>("Id"),
                Name = reader.GetFieldValue<string>("Name"),
                DisplayOrder = reader.GetFieldValue<int?>("DisplayOrder")
            };
        }
    }
}
