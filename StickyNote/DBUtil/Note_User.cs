using System;
using System.Data;
using System.Data.SQLite;
using System.Text;
namespace StickyNote.DBUtil
{
	/// <summary>
	/// 类Note_User。
	/// </summary>
	[Serializable]
	public partial class Note_User
	{
		public Note_User()
		{}
		#region Model
		private string _id;
		private string _username;
		private string _name;
		private string _password;
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Note_User(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,UserName,Name,Password ");
			strSql.Append(" FROM [Note_User] ");
			strSql.Append(" where ID=@ID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", SqlDbType.Text)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null)
				{
					this.ID=ds.Tables[0].Rows[0]["ID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null)
				{
					this.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Name"]!=null)
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Password"]!=null)
				{
					this.Password=ds.Tables[0].Rows[0]["Password"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Note_User]");
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [Note_User] (");
			strSql.Append("ID,UserName,Name,Password)");
			strSql.Append(" values (");
			strSql.Append("@ID,@UserName,@Name,@Password)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", SqlDbType.Text),
					new SQLiteParameter("@UserName", SqlDbType.Text),
					new SQLiteParameter("@Name", SqlDbType.Text),
					new SQLiteParameter("@Password", SqlDbType.Text)};
			parameters[0].Value = ID;
			parameters[1].Value = UserName;
			parameters[2].Value = Name;
			parameters[3].Value = Password;

			DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [Note_User] set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Name=@Name,");
			strSql.Append("Password=@Password");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@UserName", SqlDbType.Text),
					new SQLiteParameter("@Name", SqlDbType.Text),
					new SQLiteParameter("@Password", SqlDbType.Text),
					new SQLiteParameter("@ID", SqlDbType.Text)};
			parameters[0].Value = UserName;
			parameters[1].Value = Name;
			parameters[2].Value = Password;
			parameters[3].Value = ID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
			strSql.Append("delete from [Note_User] ");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", SqlDbType.Text)};
			parameters[0].Value = ID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,UserName,Name,Password ");
			strSql.Append(" FROM [Note_User] ");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", SqlDbType.Text)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null )
				{
					this.ID=ds.Tables[0].Rows[0]["ID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null )
				{
					this.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Name"]!=null )
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Password"]!=null )
				{
					this.Password=ds.Tables[0].Rows[0]["Password"].ToString();
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
			strSql.Append(" FROM [Note_User] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

