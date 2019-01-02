using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Media;


namespace FIPSGuideTool
{
	class DatabaseConnection
	{

		public SqlConnection dbConnect;

		public void Connection()
		{
			dbConnect = new SqlConnection("Data Source=.;Initial Catalog=TESTDB;Integrated Security=True;");
		}

		//public OleDbConnection oleDbConnect;
		//public OleDbDataAdapter oleDbAdapt;
		//public OleDbCommand oleDbComm;

		//public static ConnectionStringSettingsCollection ConnectionStrings { get; }

		//private static DatabaseConnection dbConn = null;
		//public static DatabaseConnection GetConnection()
		//{
		//	if (dbConn == null)
		//	{
		//		dbConn = new DatabaseConnection();
		//	}
		//	return dbConn;
		//}
	}
}