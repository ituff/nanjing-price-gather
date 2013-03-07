using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using org.nutlab.DBUtility;//Please add references
namespace org.nutlab
{
	/// <summary>
	/// 类good_price。
	/// </summary>
	[Serializable]
	public partial class good_price
	{
		public good_price()
		{}
		#region Model
		private long _id;
		private int? _type_id;
		private string _type_name;
		private string _name;
		private string _standard;
		private string _unit;
		private int? _district_id;
		private string _district_name;
		private int? _market_id;
		private string _market_name;
		private DateTime? _publish_time;
		private DateTime? _get_time;
		private string _get_url;
		private string _reserve1;
		private string _reserve2;
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
		public int? type_id
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
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string standard
		{
			set{ _standard=value;}
			get{return _standard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? district_id
		{
			set{ _district_id=value;}
			get{return _district_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string district_name
		{
			set{ _district_name=value;}
			get{return _district_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? market_id
		{
			set{ _market_id=value;}
			get{return _market_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string market_name
		{
			set{ _market_name=value;}
			get{return _market_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? publish_time
		{
			set{ _publish_time=value;}
			get{return _publish_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? get_time
		{
			set{ _get_time=value;}
			get{return _get_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string get_url
		{
			set{ _get_url=value;}
			get{return _get_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reserve1
		{
			set{ _reserve1=value;}
			get{return _reserve1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reserve2
		{
			set{ _reserve2=value;}
			get{return _reserve2;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public good_price(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,type_id,type_name,name,standard,unit,district_id,district_name,market_id,market_name,publish_time,get_time,get_url,reserve1,reserve2 ");
			strSql.Append(" FROM [good_price] ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)};
			parameters[0].Value = id;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					this.id=Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
				if(ds.Tables[0].Rows[0]["type_id"]!=null && ds.Tables[0].Rows[0]["type_id"].ToString()!="")
				{
					this.type_id=int.Parse(ds.Tables[0].Rows[0]["type_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["type_name"]!=null)
				{
					this.type_name=ds.Tables[0].Rows[0]["type_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["name"]!=null)
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["standard"]!=null)
				{
					this.standard=ds.Tables[0].Rows[0]["standard"].ToString();
				}
				if(ds.Tables[0].Rows[0]["unit"]!=null)
				{
					this.unit=ds.Tables[0].Rows[0]["unit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["district_id"]!=null && ds.Tables[0].Rows[0]["district_id"].ToString()!="")
				{
					this.district_id=int.Parse(ds.Tables[0].Rows[0]["district_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["district_name"]!=null)
				{
					this.district_name=ds.Tables[0].Rows[0]["district_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["market_id"]!=null && ds.Tables[0].Rows[0]["market_id"].ToString()!="")
				{
					this.market_id=int.Parse(ds.Tables[0].Rows[0]["market_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["market_name"]!=null)
				{
					this.market_name=ds.Tables[0].Rows[0]["market_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["publish_time"]!=null && ds.Tables[0].Rows[0]["publish_time"].ToString()!="")
				{
					this.publish_time=DateTime.Parse(ds.Tables[0].Rows[0]["publish_time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["get_time"]!=null && ds.Tables[0].Rows[0]["get_time"].ToString()!="")
				{
					this.get_time=DateTime.Parse(ds.Tables[0].Rows[0]["get_time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["get_url"]!=null)
				{
					this.get_url=ds.Tables[0].Rows[0]["get_url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["reserve1"]!=null)
				{
					this.reserve1=ds.Tables[0].Rows[0]["reserve1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["reserve2"]!=null)
				{
					this.reserve2=ds.Tables[0].Rows[0]["reserve2"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [good_price]");
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
			strSql.Append("insert into [good_price] (");
			strSql.Append("type_id,type_name,name,standard,unit,district_id,district_name,market_id,market_name,publish_time,get_time,get_url,reserve1,reserve2)");
			strSql.Append(" values (");
			strSql.Append("@type_id,@type_name,@name,@standard,@unit,@district_id,@district_name,@market_id,@market_name,@publish_time,@get_time,@get_url,@reserve1,@reserve2)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_id", MySqlDbType.Int32,11),
					new MySqlParameter("@type_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@name", MySqlDbType.VarChar,50),
					new MySqlParameter("@standard", MySqlDbType.VarChar,10),
					new MySqlParameter("@unit", MySqlDbType.VarChar,10),
					new MySqlParameter("@district_id", MySqlDbType.Int32,11),
					new MySqlParameter("@district_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@market_id", MySqlDbType.Int32,11),
					new MySqlParameter("@market_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@publish_time", MySqlDbType.Date),
					new MySqlParameter("@get_time", MySqlDbType.DateTime),
					new MySqlParameter("@get_url", MySqlDbType.VarChar,300),
					new MySqlParameter("@reserve1", MySqlDbType.VarChar,500),
					new MySqlParameter("@reserve2", MySqlDbType.VarChar,500)};
			parameters[0].Value = type_id;
			parameters[1].Value = type_name;
			parameters[2].Value = name;
			parameters[3].Value = standard;
			parameters[4].Value = unit;
			parameters[5].Value = district_id;
			parameters[6].Value = district_name;
			parameters[7].Value = market_id;
			parameters[8].Value = market_name;
			parameters[9].Value = publish_time;
			parameters[10].Value = get_time;
			parameters[11].Value = get_url;
			parameters[12].Value = reserve1;
			parameters[13].Value = reserve2;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [good_price] set ");
			strSql.Append("type_id=@type_id,");
			strSql.Append("type_name=@type_name,");
			strSql.Append("name=@name,");
			strSql.Append("standard=@standard,");
			strSql.Append("unit=@unit,");
			strSql.Append("district_id=@district_id,");
			strSql.Append("district_name=@district_name,");
			strSql.Append("market_id=@market_id,");
			strSql.Append("market_name=@market_name,");
			strSql.Append("publish_time=@publish_time,");
			strSql.Append("get_time=@get_time,");
			strSql.Append("get_url=@get_url,");
			strSql.Append("reserve1=@reserve1,");
			strSql.Append("reserve2=@reserve2");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_id", MySqlDbType.Int32,11),
					new MySqlParameter("@type_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@name", MySqlDbType.VarChar,50),
					new MySqlParameter("@standard", MySqlDbType.VarChar,10),
					new MySqlParameter("@unit", MySqlDbType.VarChar,10),
					new MySqlParameter("@district_id", MySqlDbType.Int32,11),
					new MySqlParameter("@district_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@market_id", MySqlDbType.Int32,11),
					new MySqlParameter("@market_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@publish_time", MySqlDbType.Date),
					new MySqlParameter("@get_time", MySqlDbType.DateTime),
					new MySqlParameter("@get_url", MySqlDbType.VarChar,300),
					new MySqlParameter("@reserve1", MySqlDbType.VarChar,500),
					new MySqlParameter("@reserve2", MySqlDbType.VarChar,500),
					new MySqlParameter("@id", MySqlDbType.Int32,20)};
			parameters[0].Value = type_id;
			parameters[1].Value = type_name;
			parameters[2].Value = name;
			parameters[3].Value = standard;
			parameters[4].Value = unit;
			parameters[5].Value = district_id;
			parameters[6].Value = district_name;
			parameters[7].Value = market_id;
			parameters[8].Value = market_name;
			parameters[9].Value = publish_time;
			parameters[10].Value = get_time;
			parameters[11].Value = get_url;
			parameters[12].Value = reserve1;
			parameters[13].Value = reserve2;
			parameters[14].Value = id;

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
			strSql.Append("delete from [good_price] ");
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
			strSql.Append("select id,type_id,type_name,name,standard,unit,district_id,district_name,market_id,market_name,publish_time,get_time,get_url,reserve1,reserve2 ");
			strSql.Append(" FROM [good_price] ");
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
				if(ds.Tables[0].Rows[0]["type_id"]!=null && ds.Tables[0].Rows[0]["type_id"].ToString()!="")
				{
					this.type_id=int.Parse(ds.Tables[0].Rows[0]["type_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["type_name"]!=null )
				{
					this.type_name=ds.Tables[0].Rows[0]["type_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["name"]!=null )
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["standard"]!=null )
				{
					this.standard=ds.Tables[0].Rows[0]["standard"].ToString();
				}
				if(ds.Tables[0].Rows[0]["unit"]!=null )
				{
					this.unit=ds.Tables[0].Rows[0]["unit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["district_id"]!=null && ds.Tables[0].Rows[0]["district_id"].ToString()!="")
				{
					this.district_id=int.Parse(ds.Tables[0].Rows[0]["district_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["district_name"]!=null )
				{
					this.district_name=ds.Tables[0].Rows[0]["district_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["market_id"]!=null && ds.Tables[0].Rows[0]["market_id"].ToString()!="")
				{
					this.market_id=int.Parse(ds.Tables[0].Rows[0]["market_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["market_name"]!=null )
				{
					this.market_name=ds.Tables[0].Rows[0]["market_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["publish_time"]!=null && ds.Tables[0].Rows[0]["publish_time"].ToString()!="")
				{
					this.publish_time=DateTime.Parse(ds.Tables[0].Rows[0]["publish_time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["get_time"]!=null && ds.Tables[0].Rows[0]["get_time"].ToString()!="")
				{
					this.get_time=DateTime.Parse(ds.Tables[0].Rows[0]["get_time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["get_url"]!=null )
				{
					this.get_url=ds.Tables[0].Rows[0]["get_url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["reserve1"]!=null )
				{
					this.reserve1=ds.Tables[0].Rows[0]["reserve1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["reserve2"]!=null )
				{
					this.reserve2=ds.Tables[0].Rows[0]["reserve2"].ToString();
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
			strSql.Append(" FROM [good_price] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

