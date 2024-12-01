using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles;

namespace Сourse_WorkEX21.AllForms
{
    public partial class Orders : Form
    {
        private Database database;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        public Orders()
        {
            InitializeComponent();
            database = new Database();
            adapter = new MySqlDataAdapter();
            dataTable = new DataTable();

            DataGridOrdersPanel.DataSource = database.GetOrders();
        }

        private void btUpdateTableOrders_Click(object sender, EventArgs e)
        {
            DataGridOrdersPanel.DataSource = database.GetOrders();
        }

        private void btEditOrderStatus_Click(object sender, EventArgs e)
        {
            if (DataGridOrdersPanel.SelectedRows.Count > 0)
            {
                int idClient = Convert.ToInt32(DataGridOrdersPanel.SelectedRows[0].Cells["id"].Value);
                string currentStatus = DataGridOrdersPanel.SelectedRows[0].Cells["status"].Value.ToString();
                string clientEmail = DataGridOrdersPanel.SelectedRows[0].Cells["email"].Value.ToString();
                new EditStatusOrder(idClient, currentStatus, clientEmail, DataGridOrdersPanel).ShowDialog();
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            DataGridOrdersPanel.DataSource = database.GetOrders();
        }

        private void btDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbIdDeleteOrder.Text))
                {
                    MessageBox.Show("Рядок id порожній", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (isFirstDeleteNameAssortiment() == false)
                    {
                        return;
                    }
                    else
                    {
                        string query = "DELETE FROM orderss WHERE id  = @id";

                        database.openConnection();
                        MySqlCommand command = new MySqlCommand(query, database.getConnection());
                        command.Parameters.AddWithValue("@id", int.Parse(tbIdDeleteOrder.Text));
                        command.ExecuteNonQuery();
                        database.closeConnection();
                        MessageBox.Show("Замовлення видалено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbIdDeleteOrder.Text = string.Empty;

                        Orders_Load(DataGridOrdersPanel, null);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть цифру", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean isFirstDeleteNameAssortiment()
        {
            string query = "SELECT id FROM `orderss` WHERE `id` = @id";
            using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
            {
                command.Parameters.AddWithValue("@id", int.Parse(tbIdDeleteOrder.Text));
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                if (DataGridOrdersPanel.Rows.Count > 0)
                    return true;
                else
                {
                    MessageBox.Show("Такого замовлення немає", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
