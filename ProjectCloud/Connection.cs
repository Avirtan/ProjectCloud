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
            string host = "localhost";
            int port = 3306;
            string database = "cloudproject";
            string username = "root";
            string password = "root";
            String connString = "Server=" + host + ";Database=" + database
                    + ";port=" + port + ";User Id=" + username + ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
