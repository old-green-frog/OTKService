using MySqlConnector;

namespace OTKService.Entities
{
    static class Service
    {
        public static string[] GetAllNames()
        {
            MySqlConnection connection = new MySqlConnection(Helper.connectionString);
            connection.Open();
            MySqlCommand loginSelect = connection.CreateCommand();
            loginSelect.CommandText = $"SELECT name FROM service";
            MySqlDataReader reader = loginSelect.ExecuteReader();
            List<string> names = new List<string>();

            while (reader.Read())
            {
                names.Add(reader.GetString(0));
            }

            return names.ToArray();
        }

        public static string GetIdByName(string name)
        {
            MySqlConnection connection = new MySqlConnection(Helper.connectionString);
            connection.Open();
            MySqlCommand loginSelect = connection.CreateCommand();
            loginSelect.CommandText = $"SELECT id FROM service WHERE name='{name}'";
            MySqlDataReader reader = loginSelect.ExecuteReader();
            string id = "";

            while (reader.Read())
            {
                id = $"{reader.GetInt32(0)}";
            }

            return id;
        }

        public static string GetPriceByName(string name)
        {
            MySqlConnection connection = new MySqlConnection(Helper.connectionString);
            connection.Open();
            MySqlCommand loginSelect = connection.CreateCommand();
            loginSelect.CommandText = $"SELECT price FROM service WHERE name='{name}'";
            MySqlDataReader reader = loginSelect.ExecuteReader();
            string price = "";

            while (reader.Read())
            {
                price = $"{reader.GetDouble(0)}";
            }

            return price;
        }
    }
}
