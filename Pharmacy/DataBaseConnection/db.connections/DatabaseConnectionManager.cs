using System.Data.SQLite;
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
                @"Data Source=C:\Users\nanan\RiderProjects\Pharmacy\Pharmacy\DataBaseConnection\pharmacy.sqlite";
        }

        public static SQLiteConnection GetSqlConnection()
        {
            return new(GetConnectionString(), true);
        }
    }
}