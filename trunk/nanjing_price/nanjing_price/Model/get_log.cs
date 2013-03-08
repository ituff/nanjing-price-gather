using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using org.nutlab.DBUtility;//Please add references
namespace org.nutlab
{
	/// <summary>
	/// 类get_log。
	/// </summary>
	[Serializable]
	public partial class get_log
	{
		public get_log()
		{}
		#region Model
		private long _id;
		private string _gain_url;
		private string _gain_id;
		private int _type_id;
		private string _type_name;
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
		public string gain_url
		{
			set{ _gain_url=value;}
			get{return _gain_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gain_id
		{
			set{ _gain_id=value;}
			get{return _gain_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int type_id
		{
			set{ _type_id=value;}
			get{return _type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type_name
		{
			set{ _type_name=value;}
			get{return _type_name;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public get_log(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,gain_url,gain_id,type_id,type_name ");
			strSql.Append(" FROM `get_log` ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)};
			parameters[0].Value = id;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					this.id=Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
				if(ds.Tables[0].Rows[0]["gain_url"]!=null)
				{
					this.gain_url=ds.Tables[0].Rows[0]["gain_url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["gain_id"]!=null)
				{
					this.gain_id=ds.Tables[0].Rows[0]["gain_id"].ToString();
				}
				if(ds.Tables[0].Rows[0]["type_id"]!=null && ds.Tables[0].Rows[0]["type_id"].ToString()!="")
				{
					this.type_id=int.Parse(ds.Tables[0].Rows[0]["type_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["type_name"]!=null)
				{
					this.type_name=ds.Tables[0].Rows[0]["type_name"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from `get_log`");
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
			strSql.Append("insert into `get_log` (");
			strSql.Append("gain_url,gain_id,type_id,type_name)");
			strSql.Append(" values (");
			strSql.Append("@gain_url,@gain_id,@type_id,@type_name)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@gain_url", MySqlDbType.VarChar,300),
					new MySqlParameter("@gain_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@type_id", MySqlDbType.Int32,11),
					new MySqlParameter("@type_name", MySqlDbType.VarChar,50)};
			parameters[0].Value = gain_url;
			parameters[1].Value = gain_id;
			parameters[2].Value = type_id;
			parameters[3].Value = type_name;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update `get_log` set ");
			strSql.Append("gain_url=@gain_url,");
			strSql.Append("gain_id=@gain_id,");
			strSql.Append("type_id=@type_id,");
			strSql.Append("type_name=@type_name");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@gain_url", MySqlDbType.VarChar,300),
					new MySqlParameter("@gain_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@type_id", MySqlDbType.Int32,11),
					new MySqlParameter("@type_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int32,20)};
			parameters[0].Value = gain_url;
			parameters[1].Value = gain_id;
			parameters[2].Value = type_id;
			parameters[3].Value = type_name;
			parameters[4].Value = id;

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
			strSql.Append("delete from `get_log` ");
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
			strSql.Append("select id,gain_url,gain_id,type_id,type_name ");
			strSql.Append(" FROM `get_log` ");
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
				if(ds.Tables[0].Rows[0]["gain_url"]!=null )
				{
					this.gain_url=ds.Tables[0].Rows[0]["gain_url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["gain_id"]!=null )
				{
					this.gain_id=ds.Tables[0].Rows[0]["gain_id"].ToString();
				}
				if(ds.Tables[0].Rows[0]["type_id"]!=null && ds.Tables[0].Rows[0]["type_id"].ToString()!="")
				{
					this.type_id=int.Parse(ds.Tables[0].Rows[0]["type_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["type_name"]!=null )
				{
					this.type_name=ds.Tables[0].Rows[0]["type_name"].ToString();
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
			strSql.Append(" FROM `get_log` ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

