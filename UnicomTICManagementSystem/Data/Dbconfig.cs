using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Data
{
    internal class Dbconfig
    {
        
            private static string connectionString = "Data Source=unicomticDB.db;Version=3;";

            public static SQLiteConnection GetConnection()
            {
                var conn = new SQLiteConnection(connectionString);
                conn.Open();
                return conn;
            }
        }
  }


