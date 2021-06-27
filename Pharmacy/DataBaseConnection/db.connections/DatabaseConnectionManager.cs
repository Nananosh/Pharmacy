﻿using System.Data.SQLite;
using System.IO;

namespace Pharmacy.DataBaseConnection
{
    public class DatabaseConnectionManager
    {
        private DatabaseConnectionManager()
        {
        }

        private static string GetConnectionString()
        {
            return
                $@"Data Source={Path.GetFullPath("DataBaseConnection/pharmacy.sqlite")}";
        }

        public static SQLiteConnection GetSqlConnection()
        {
            return new(GetConnectionString(), true);
        }
    }
}