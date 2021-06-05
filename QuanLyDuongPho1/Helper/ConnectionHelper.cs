using System.Data;
using MySql.Data.MySqlClient;

namespace QuanLyDuongPho1.Helper
{
    public class ConnectionHelper
    {
        private static string _server = "localhost";
        private static string _database = "quanlyduongpho";
        private static string _uid = "root";
        private static string _password = "";
        private static MySqlConnection _connection;
        public static MySqlConnection GetConnection()
        {
            if (_connection == null || _connection.State == ConnectionState.Closed)
            {
                string connectionString;
                connectionString = "SERVER=" + _server + ";" + "DATABASE=" + 
                                   _database + ";" + "UID=" + _uid + ";" + "PASSWORD=" + _password + ";" + "convert zero datetime=True" + ";";
                _connection = new MySqlConnection(connectionString);
            }
            return _connection;
        }
    }
}