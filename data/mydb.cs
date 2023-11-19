using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Dapper;
using System.Data;
using dataLearning.Model;

namespace dataLearning.data
{
	public class Mydb
	{
		private string constr = "User Id=hr;Password=hr;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl)))";
		
		IDbConnection dbCon;

		public Mydb()
		{
			dbCon = new OracleConnection(constr);
		}
		

		public IEnumerable<T> getDBData<T>(string sql)
		{
			return (dbCon.Query<T>(sql));
		}

		public T getDBDataSingle<T>(string sql)
		{
			return (dbCon.QuerySingle<T>(sql));
		}

		public bool ExecuteSql(string sql)
		{
			//int a = dbCon.Execute(sql);
			//bool ret = false;
			//if (a > 0)
			//{
			//	ret = true;
			//}
			//return (ret);
			return (dbCon.Execute(sql) > 0);
		}
	}

	 
}
