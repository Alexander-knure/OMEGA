using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NLog;

namespace NURESCADA
{
    static class DBUtils
    {

        public static MySqlConnection conn;
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "simplescada";
            string username = "root";
            string password = "root";
            conn = new MySqlConnection();
            

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

        public static bool OpenConnection(MetroFramework.Controls.MetroLabel lbStatus, Logger logger)
        {
            try
            {
                conn = GetDBConnection();
                lbStatus.Text = String.Empty;
                lbStatus.ForeColor = Color.Yellow;
                lbStatus.Text += "Openning connection";
                conn.Open();

                lbStatus.ForeColor = Color.GreenYellow;
                lbStatus.Text = String.Empty;
                lbStatus.Text += "Connection successful";

                logger.Info("connection successful");
                return true;
            }
            catch (MySqlException exc)
            {
                lbStatus.ForeColor = Color.Red;

                lbStatus.Text = "Error (check server)";

                logger.Error("open connection:" + exc);
                return false;
            }
        }
    }
}