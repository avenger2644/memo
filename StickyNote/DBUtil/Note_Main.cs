using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
namespace StickyNote.DBUtil
{
	/// <summary>
	/// 类Note_Main。
	/// </summary>
	[Serializable]
	public partial class Note_Main
	{
		public Note_Main()
		{}
		#region Model
		private string _id;
		private string _content;
		private int _state;
		private string _addrenid;
        private string _addtime;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddRenID
		{
			set{ _addrenid=value;}
			get{return _addrenid;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string AddTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Note_Main(string ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select ID,Content,State,AddRenID,AddTime  ");
			strSql.Append(" FROM [Note_Main] ");
			strSql.Append(" where ID=@ID ");
            string sql = strSql.ToString();
            sql = sql.Replace("@ID", "'" + ID.Replace("'", "''") + "'");

			DataSet ds=DbHelperSQLite.Query(sql);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null)
				{
					this.ID=ds.Tables[0].Rows[0]["ID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Content"]!=null)
				{
					this.Content=ds.Tables[0].Rows[0]["Content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["State"]!=null && ds.Tables[0].Rows[0]["State"].ToString()!="")
				{
					this.State=int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AddRenID"]!=null)
				{
					this.AddRenID=ds.Tables[0].Rows[0]["AddRenID"].ToString();
				}
                if (ds.Tables[0].Rows[0]["AddTime"] != null && ds.Tables[0].Rows[0]["AddTime"].ToString() != "")
                {
                    this.AddTime = ds.Tables[0].Rows[0]["AddTime"].ToString();
                }
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Note_Main]");
			strSql.Append(" where ID=@ID ");

			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", SqlDbType.Text)};
			parameters[0].Value = ID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Note_Main] (");
            strSql.Append("ID,Content,State,AddRenID,AddTime)");
            strSql.Append(" values (");
            strSql.Append("@ID,@Content,@State,@AddRenID,@AddTime)");
            string sql = strSql.ToString();
            sql = sql.Replace("@ID","'" + ID.Replace("'","''") + "'");
            sql = sql.Replace("@Content", "'" + Content.Replace("'", "''") + "'");
            sql = sql.Replace("@State", State.ToString());
            sql = sql.Replace("@AddRenID", "'" + AddRenID.Replace("'", "''") + "'");
            sql = sql.Replace("@AddTime", "'" + AddTime.Replace("'", "''") + "'");

            DbHelperSQLite.ExecuteSql(sql);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Note_Main] set ");
            strSql.Append("Content=@Content,");
            strSql.Append("State=@State,");
            strSql.Append("AddRenID=@AddRenID,");
            strSql.Append("AddTime=@AddTime");
            strSql.Append(" where ID=@ID ");

            string sql = strSql.ToString();
            sql = sql.Replace("@ID", "'" + ID.Replace("'", "''") + "'");
            sql = sql.Replace("@Content", "'" + Content.Replace("'", "''") + "'");
            sql = sql.Replace("@State", State.ToString());
            sql = sql.Replace("@AddRenID", "'" + AddRenID.Replace("'", "''") + "'");
            sql = sql.Replace("@AddTime", "'" + AddTime.Replace("'", "''") + "'");

            int rows = DbHelperSQLite.ExecuteSql(sql);
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
		public bool Delete(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [Note_Main] ");
			strSql.Append(" where ID=@ID ");
            string sql = strSql.ToString();
            sql = sql.Replace("@ID", "'" + ID.Replace("'", "''") + "'");
            int rows = DbHelperSQLite.ExecuteSql(sql);
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
        public void GetModel(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Content,State,AddRenID,AddTime ");
            strSql.Append(" FROM [Note_Main] ");
            strSql.Append(" where ID=@ID ");
            string sql = strSql.ToString();
            sql = sql.Replace("@ID", "'" + ID.Replace("'", "''") + "'");

            DataSet ds = DbHelperSQLite.Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null)
                {
                    this.ID = ds.Tables[0].Rows[0]["ID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Content"] != null)
                {
                    this.Content = ds.Tables[0].Rows[0]["Content"].ToString();
                }
                if (ds.Tables[0].Rows[0]["State"] != null && ds.Tables[0].Rows[0]["State"].ToString() != "")
                {
                    this.State = int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AddRenID"] != null)
                {
                    this.AddRenID = ds.Tables[0].Rows[0]["AddRenID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["AddTime"] != null && ds.Tables[0].Rows[0]["AddTime"].ToString() != "")
                {
                    this.AddTime = ds.Tables[0].Rows[0]["AddTime"].ToString();
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
			strSql.Append(" FROM [Note_Main] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

