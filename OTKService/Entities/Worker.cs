using MySqlConnector;

namespace OTKService.Entities
{
    static class Worker
    {
        public static string GetNameByLoginAndPassword(string login, string password)
        {
            MySqlConnection connection = new MySqlConnection(Helper.connectionString);
            connection.Open();
            MySqlCommand loginSelect = connection.CreateCommand();
            loginSelect.CommandText = $"SELECT name FROM worker WHERE login='{login}' AND password='{password}'";
            MySqlDataReader reader = loginSelect.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Неправильный логин или пароль!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }
            else
            {
                reader.Read();
                return (string)reader.GetValue(0);
            }
        }
    }
}
