using MySqlConnector;

namespace OTKService.Entities
{
    static class Order
    {
        public static void GetAll(DataGridView table)
        {
            MySqlConnection connection = new MySqlConnection(Helper.connectionString);
            connection.Open();
            MySqlCommand loginSelect = connection.CreateCommand();
            loginSelect.CommandText = $"SELECT * FROM `order`";
            MySqlDataReader reader = loginSelect.ExecuteReader();

            while (reader.Read())
            {
                var newrow = table.Rows.Add();
                table.Rows[newrow].Cells["OrdersId"].Value = reader.GetValue(0);
                table.Rows[newrow].Cells["Date"].Value = reader.GetValue(1);
                table.Rows[newrow].Cells["UserField"].Value = reader.GetValue(2);
                table.Rows[newrow].Cells["ServiceField"].Value = reader.GetValue(3);
                table.Rows[newrow].Cells["PercentField"].Value = reader.GetValue(4);
                table.Rows[newrow].Cells["PriceField"].Value = reader.GetValue(5);
            }

            
        }

        public static void Create(string fields) 
        {
            MySqlConnection connection = new MySqlConnection(Helper.connectionString);
            connection.Open();
            MySqlCommand loginSelect = connection.CreateCommand();
            loginSelect.CommandText = $"INSERT INTO `order` VALUES({fields})";
            loginSelect.ExecuteNonQuery();
        }
    }
}
