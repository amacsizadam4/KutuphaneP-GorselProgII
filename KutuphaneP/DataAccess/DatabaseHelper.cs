using System;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.DataAccess
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=localhost;Database=LibraryDB;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("Veritabanı bağlandı!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veritabanına bağlanırken hata: " + ex.Message);
            }
            return conn;
        }
    }
}
