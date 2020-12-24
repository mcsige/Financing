/*
 * 由SharpDevelop创建。
 * 用户： Dell
 * 日期: 2020/12/24
 * 时间: 15:12
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace test
{
	/// <summary>
	/// Description of DBhelper.
	/// </summary>
	public class DBhelper
	{
		string connstr = "data source=localhost;database=financing;user id=root;password=root;" +
				"pooling=false;charset=utf8";//pooling代表是否使用连接池
		MySqlConnection conn;
		
		public DBhelper(){
			conn = new MySqlConnection(connstr);
		}
		
		public bool onLogin(string username,string password){
			string sql = string.Format("select count(*) from user where uname='{0}' and password='{1}'"
			                          ,username,password);
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql, conn);//sqlcommand表示要向向数据库执行sql语句或存储过程
            int i = Convert.ToInt32(cmd.ExecuteScalar());//执行后返回记录行数
            conn.Close();
            return i>0;
		}
		
		public List<Kind> onKindQuery(){
			List<Kind> list = new List<Kind>();
			string sql = string.Format("select kid, kind_name from fkind");
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql, conn);//sqlcommand表示要向向数据库执行sql语句或存储过程
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()){
				list.Add(new Kind(int.Parse(reader[0].ToString()),reader[1].ToString()));
			}
            conn.Close();
            return list;
		}
		
		public void onInsertItem(Item item){
			string sql = string.Format("insert into fitem (name,kid,flag) values('{0}',{1},{2})"
			                           ,item.Name,item.Kid,item.Flag);
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql, conn);//sqlcommand表示要向向数据库执行sql语句或存储过程
			cmd.ExecuteNonQuery();
            conn.Close();
		}
	}
}
