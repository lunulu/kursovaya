using MySql.Data.MySqlClient;

namespace Kursovaya
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=Rus20051999;database=kursovaya");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
