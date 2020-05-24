using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NURESCADA
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "simplescada";
            string username = "root";
            string password = "root";
            MySqlConnection m = new MySqlConnection();
            

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}