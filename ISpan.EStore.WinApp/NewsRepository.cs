using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.WinApp
{
	public class NewsRepository
	{
		public int Create(News entity)
		{
			string sql = @"
insert into News
(Title, Description, CreatedTime, ModifiedTime)
values
(@Title, @Description, @CreatedTime, @ModifiedTime)";
			//SqlParameter[] parameters = new SqlParameter[]
			//{
			//	new SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50){Value = entity.Title},
			//	new SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 3000){Value = entity.Description},
			//	new SqlParameter("@CreatedTime", System.Data.SqlDbType.DateTime){Value = entity.CreatedTime},
			//	new SqlParameter("@ModifiedTime", System.Data.SqlDbType.DateTime){Value = entity.ModifiedTime},

			//	new SqlParameter("@newId", System.Data.SqlDbType.Int){Direction = System.Data.ParameterDirection.Output},
			//};

			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("@Title", entity.Title, 50)
				.AddNVarchar("@Description", entity.Description, 3000)
				.AddDateTime("@CreatedTime", entity.CreatedTime)
				.AddDateTime("@ModifiedTime", entity.ModifiedTime)
				//.AddInt("@newId", null, System.Data.ParameterDirection.Output )
				.Build();

			return SqlDb.Create(SqlDb.GetConnection, sql, parameters);

			//using (var conn = SqlDb.GetConnection())
			//{
			//	using (var cmd = conn.CreateCommand())
			//	{
			//		conn.Open();
			//		cmd.CommandText = sql;
			//		cmd.Parameters.AddRange(parameters);

			//		cmd.ExecuteNonQuery();

			//		return (int)cmd.Parameters["@newId"].Value;
			//	}
			//}
		}

		public News GetNews(int newsId)
		{
			var sql = $"select * from News where Id = {newsId}";
			return SqlDb.Get(SqlDb.GetConnection, News.GetInstance, sql);

			//using (var conn = SqlDb.GetConnection())
			//{
			//	using (var cmd = new SqlCommand(sql, conn))
			//	{
			//		conn.Open();
			//		var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			//		return reader.Read()
			//		?News.GetInstance(reader)
			//		: null;
			//	}
			//}
		}

		public int Update(News entity)
		{
			//在此不更新CreateTime
			string sql = @"update News set
Title = @Title,
Description = @Description,
ModifiedTime = @ModifiedTime
where Id = @Id";
			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("@Title", entity.Title, 50)
				.AddNVarchar("@Description", entity.Description, 3000)
				.AddDateTime("@ModifiedTime", entity.ModifiedTime)
				.AddInt("@Id", entity.Id)
				.Build();
			return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);

			//using (var conn = SqlDb.GetConnection())
			//{
			//	conn.Open();
			//	using (var cmd = new SqlCommand(sql, conn))
			//	{
			//		cmd.Parameters.AddRange(parameters);
			//		return cmd.ExecuteNonQuery();//傳回被異動的筆數,若為零表示沒有異動
			//	}
			//}

		}
		public int Delete(int newsId)
		{
			string sql = @"Delete News where Id = @Id";

			var parameters = SqlParameterBuilder.Create()
				.AddInt("@Id", newsId)
				.Build();

			return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);

			//using (var conn = SqlDb.GetConnection())
			//{
			//	conn.Open();
			//	using (var cmd = new SqlCommand(sql, conn))
			//	{
			//		cmd.Parameters.AddRange(parameters);
			//		return cmd.ExecuteNonQuery();//傳回被異動的筆數
			//	}
			//}

		}
	}
	public class News
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedTime { get; set; }
		public DateTime ModifiedTime { get; set; }

		internal static News GetInstance(SqlDataReader reader)
		{
			var news = new News();
			news.Id = reader.GetFieldValue<int>("Id");
			news.Title = reader.GetFieldValue<string>("Title");
			news.Description = reader.GetFieldValue<string>("Description");
			news.CreatedTime = reader.GetFieldValue<DateTime>("CreatedTime");
			news.ModifiedTime = reader.GetFieldValue<DateTime>("ModifiedTime");

			return news;
		}
	}
}
