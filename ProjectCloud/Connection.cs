﻿using System;
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
            string database = "RrXmwWwcgV";//RrXmwWwcgV
            string username = "RrXmwWwcgV";//RrXmwWwcgV
            string password = "v7Sf1gi1Pd";//v7Sf1gi1Pd
            String connString = "Server=" + host + ";Database=" + database
                    + ";port=" + port + ";User Id=" + username + ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
