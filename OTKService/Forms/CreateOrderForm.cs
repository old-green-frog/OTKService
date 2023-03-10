using OTKService.Entities;
using System.Xml.Linq;

namespace OTKService.Forms
{
    public partial class CreateOrderForm : Form
    {
        private AuthorizeForm parent;

        public CreateOrderForm(AuthorizeForm parentForm, string username)
        {
            parent = parentForm;
            InitializeComponent();

            HelloLabel.Text += $", {username}";

            UserSelector.Items.AddRange(User.GetAllNames());
            ServiceSelector.Items.AddRange(Service.GetAllNames());

            DataGridView table = (DataGridView)Controls.Find("Table", true)[0];
            Order.GetAll(table);
        }

        private void OnReturnButtonClick(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }

        private string[] CheckFields()
        {
            TextBox orderId = (TextBox)Controls.Find("OrderId", true)[0];
            DateTimePicker date = (DateTimePicker)Controls.Find("OrderDatePicker", true)[0];
            ComboBox user = (ComboBox)Controls.Find("UserSelector", true)[0];
            ComboBox service = (ComboBox)Controls.Find("ServiceSelector", true)[0];
            TextBox percent = (TextBox)Controls.Find("PercentBox", true)[0];
            var actualPercent = percent.Text.Length == 0 ? "0" : percent.Text;
            TextBox price = (TextBox)Controls.Find("PriceBox", true)[0];

            string user_id = User.GetIdByName(user.Text);
            string service_id = Service.GetIdByName(service.Text);

            int oid = 0;
            bool result = int.TryParse(orderId.Text, out oid);
            if (result == false)
            {
                MessageBox.Show("Пожалуйста, вводите в поле 'Номер заказа' только числа", "Ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new string[] { };
            }

            if (service_id.Length == 0 || user_id.Length == 0) 
            {
                MessageBox.Show("Вы не заполнили все поля", "Ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new string[] {};
            }


            return new string[] {
                oid.ToString(),  date.Value.ToString().Substring(0, 10), user_id, service_id, actualPercent,  price.Text
            };
        }

        private void OnSaveOrderButtonClick(object sender, EventArgs e)
        {
            var fields = CheckFields();
            if (fields.Length == 0)
            {
                return;
            }

            string queryString = "";
            for (int i = 0; i < fields.Length; i++)
            {
                queryString += $"'{fields[i]}',";
            }
            queryString = queryString.Remove(queryString.Length - 1);
            Order.Create(queryString);
            MessageBox.Show("Заказ успешно создан");

            string[] fieldNames = { "OrdersId", "Date", "UserField", "ServiceField", "PercentField", "PriceField" };
            DataGridView table = (DataGridView)Controls.Find("Table", true)[0];
            DataGridViewRow row = table.Rows[table.Rows.Count - 1];
            
            for (int i = 0; i < fieldNames.Length; i++)
            {
                row.Cells[fieldNames[i]].Value = fields[i];
            }
        }

        private void ServiceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox service = (ComboBox)Controls.Find("ServiceSelector", true)[0];
            var servicePrice = Service.GetPriceByName(service.Text);

            TextBox price = (TextBox)Controls.Find("PriceBox", true)[0];
            price.Text = servicePrice;
        }

        private void PercentBox_TextChanged(object sender, EventArgs e)
        {
            TextBox percent = (TextBox)Controls.Find("PercentBox", true)[0];
            TextBox price = (TextBox)Controls.Find("PriceBox", true)[0];
            if (percent.Text == "")
            {
                ComboBox service = (ComboBox)Controls.Find("ServiceSelector", true)[0];
                var servicePrice = Service.GetPriceByName(service.Text);

                TextBox prices = (TextBox)Controls.Find("PriceBox", true)[0];
                prices.Text = servicePrice;
                return;
            } else
            {
                if (price.Text == "")
                {
                    MessageBox.Show("Для начала заполните поле 'Услуга'", "Ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    percent.Text = "";
                    return;
                }
                else
                {
                    var actualPercent = int.Parse(percent.Text);
                    var actualPrice = int.Parse(price.Text);
                    actualPrice -= (actualPrice * actualPercent / 100);
                    price.Text = actualPrice.ToString();
                }
            }
        }
    }
}
