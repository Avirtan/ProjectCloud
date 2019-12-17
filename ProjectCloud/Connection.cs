using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectCloud
{
    class Connection
    {
        public static MySqlConnection GetDBConnection()//string host, int port, string database, string username, string password)
        {
            string host = "remotemysql.com";// remotemysql.com
            int port = 3306;
            string database = "fxHGRqKFD9";//RrXmwWwcgV
            string username = "fxHGRqKFD9";//RrXmwWwcgV
            string password = "xRrt2UP7De";//v7Sf1gi1Pd
            String connString = "Server=" + host + ";Database=" + database
                    + ";port=" + port + ";User Id=" + username + ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
