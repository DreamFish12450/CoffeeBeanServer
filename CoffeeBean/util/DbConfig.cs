using System.Data;
using MySql.Data.MySqlClient;

namespace CoffeeBean.util
{
    public class DbConfig
    {
        //ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        private static string DefaultSqlConnectionString =
            @"server=118.25.154.83;port=3306;database=ZKY_coffee;user=root;password=123456";

        public static IDbConnection GetSqlConnection(string sqlConnectionString = null)
        {
            if (string.IsNullOrWhiteSpace(sqlConnectionString))
            {
                sqlConnectionString = DefaultSqlConnectionString;
            }

            IDbConnection conn = new MySqlConnection(sqlConnectionString);
            conn.Open();
            return conn;
        }
    }
}