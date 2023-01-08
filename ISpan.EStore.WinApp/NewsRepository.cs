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
		private readonly string _tableName = "News";
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, NewsInfo> funcAssembler = NewsInfo.GetInstance;

		public int Create(NewsInfo news)
		{
			string sql = @"
insert into News
(Title, Description, CreatedTime, ModifiedTime)
values
(@Title, @Description, @CreatedTime, @ModifiedTime)";
			//SqlParameter[] parameters = new SqlParameter[]
			//{
			//	new SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50){Value = news.Title},
			//	new SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 3000){Value = news.Description},
			//	new SqlParameter("@CreatedTime", System.Data.SqlDbType.DateTime){Value = news.CreatedTime},
			//	new SqlParameter("@ModifiedTime", System.Data.SqlDbType.DateTime){Value = news.ModifiedTime},

			//	new SqlParameter("@newId", System.Data.SqlDbType.Int){Direction = System.Data.ParameterDirection.Output},
			//};

			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("@Title", news.Title, 50)
				.AddNVarchar("@Description", news.Description, 3000)
				.AddDateTime("@CreatedTime", news.CreatedTime)
				.AddDateTime("@ModifiedTime", news.ModifiedTime)
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

		public NewsInfo GetNews(int newsId)
		{
			var sql = $"select * from News where Id = {newsId}";
			return SqlDb.Get(SqlDb.GetConnection, NewsInfo.GetInstance, sql);

			//using (var conn = SqlDb.GetConnection())
			//{
			//	using (var cmd = new SqlCommand(sql, conn))
			//	{
			//		conn.Open();
			//		var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			//		return reader.Read()
			//		?NewsInfo.GetInstance(reader)
			//		: null;
			//	}
			//}
		}

		public int Update(NewsInfo news)
		{
			//在此不更新CreateTime
			string sql = @"update News set
Title = @Title,
Description = @Description,
ModifiedTime = @ModifiedTime
where Id = @Id";
			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("@Title", news.Title, 50)
				.AddNVarchar("@Description", news.Description, 3000)
				.AddDateTime("@ModifiedTime", news.ModifiedTime)
				.AddInt("@Id", news.Id)
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
		public IEnumerable<NewsInfo> Search(string title, string description)
		{
			#region 生成sql statement
			string sql = $@"Select * from {_tableName}";

			string where = string.Empty;

			var parameters = new List<SqlParameter>();

			if (string.IsNullOrEmpty(title) == false)
			{
				where += $" And Title like '%' + @Title + '%'";
				parameters.Add(new SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50) { Value = title });
			}

			if (string.IsNullOrEmpty(description) == false)
			{
				where += $" And Description like '%' + @Description + '%'";
				parameters.Add(new SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 50) { Value = description });
			}

			where = where == string.Empty ? where : where = " where " + where.Substring(5);
			sql += where;
			#endregion

			return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
		}
	}
	public class NewsInfo
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedTime { get; set; }
		public DateTime ModifiedTime { get; set; }

		internal static NewsInfo GetInstance(SqlDataReader reader)
		{
			var news = new NewsInfo();
			news.Id = reader.GetFieldValue<int>("Id");
			news.Title = reader.GetFieldValue<string>("Title");
			news.Description = reader.GetFieldValue<string>("Description");
			news.CreatedTime = reader.GetFieldValue<DateTime>("CreatedTime");
			news.ModifiedTime = reader.GetFieldValue<DateTime>("ModifiedTime");

			return news;
		}
	}
}
