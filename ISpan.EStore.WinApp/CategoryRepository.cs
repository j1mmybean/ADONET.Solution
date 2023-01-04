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
        public Category GetCategory(int categoryId)
        {
            using (var conn = SqlDb.GetConnection())
            {
                Category category = null;
                string sql = $"Select * from Categories where Id = {categoryId}";
                using (var command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return Category.GetInstance(reader);
                        //category = new Category
                        //{
                        //    Id = categoryId,
                        //    Name = reader.GetFieldValue<string>("Name"),
                        //    DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
                        //    //Name = reader["Name"].ToString(),
                        //    //DisplayOrder = int.Parse(reader["DisplayOrder"].ToString())
                        //    //此處使用擴充方法優化
                        //};
                    }
                }
                return category;
            }
        
        }
        public int GetProductCount(int categoryId)
        {
            using (var conn = SqlDb.GetConnection())
            {
                string sql = $"Select count(*) from Products where CategoryId = {categoryId}";
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
        public int DisplayOrder { get; set; }

        public static Category GetInstance(SqlDataReader reader)
        {
            return new Category
            {
                Id = reader.GetFieldValue<int>("Id"),
                Name = reader.GetFieldValue<string>("Name"),
                DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
            };
        }
    }
}
