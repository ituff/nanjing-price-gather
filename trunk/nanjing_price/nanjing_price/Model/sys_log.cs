using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using org.nutlab.DBUtility;//Please add references
namespace org.nutlab
{
	/// <summary>
	/// 类sys_log。
	/// </summary>
	[Serializable]
	public partial class sys_log
	{
		public sys_log()
		{}
		#region Model
		private long _id;
		private DateTime? _time;
		private string _content;
		/// <summary>
		/// auto_increment
		/// </summary>
		public long id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public sys_log(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,time,content ");
			strSql.Append(" FROM [sys_log] ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)};
			parameters[0].Value = id;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					this.id=Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
				if(ds.Tables[0].Rows[0]["time"]!=null && ds.Tables[0].Rows[0]["time"].ToString()!="")
				{
					this.time=DateTime.Parse(ds.Tables[0].Rows[0]["time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["content"]!=null)
				{
					this.content=ds.Tables[0].Rows[0]["content"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [sys_log]");
			strSql.Append(" where id=@id ");

			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [sys_log] (");
			strSql.Append("time,content)");
			strSql.Append(" values (");
			strSql.Append("@time,@content)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@time", MySqlDbType.DateTime),
					new MySqlParameter("@content", MySqlDbType.VarChar,500)};
			parameters[0].Value = time;
			parameters[1].Value = content;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [sys_log] set ");
			strSql.Append("time=@time,");
			strSql.Append("content=@content");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@time", MySqlDbType.DateTime),
					new MySqlParameter("@content", MySqlDbType.VarChar,500),
					new MySqlParameter("@id", MySqlDbType.Int32,20)};
			parameters[0].Value = time;
			parameters[1].Value = content;
			parameters[2].Value = id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [sys_log] ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)};
			parameters[0].Value = id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,time,content ");
			strSql.Append(" FROM [sys_log] ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)};
			parameters[0].Value = id;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.id=long.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["time"]!=null && ds.Tables[0].Rows[0]["time"].ToString()!="")
				{
					this.time=DateTime.Parse(ds.Tables[0].Rows[0]["time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["content"]!=null )
				{
					this.content=ds.Tables[0].Rows[0]["content"].ToString();
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [sys_log] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

