using System;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles;

namespace Сourse_WorkEX21.AllForms
{
    public partial class EditStatusOrder : Form
    {
        private int idClient;
        private string curentStatus;
        private string email;
        private string newStatus;
        private DataGridView data;
        private Database database;
        private MessageFromEmail messageFromEmail;
        public EditStatusOrder(int idClient, string curentStatus, string email, DataGridView dataGridView)
        {
            InitializeComponent();
            this.idClient = idClient;
            this.curentStatus = curentStatus;
            this.email = email;
            data = dataGridView;

            database = new Database();
            messageFromEmail = new MessageFromEmail();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAcept.Checked)
                {
                    newStatus = rbAcept.Text;
                    if (newStatus != curentStatus)
                    {
                        database.EditStatusOrders(newStatus, idClient, email);
                        data.DataSource = database.GetOrders();
                        Close();
                    }
                    else
                    {
                        database.closeConnection();
                        MessageBox.Show("Вибраний статус збігається з поточним.", "Повідомлення",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rbDelivered.Checked)
                {
                    newStatus = rbDelivered.Text;
                    if (newStatus != curentStatus)
                    {
                        database.EditStatusOrders(newStatus, idClient, email);
                        data.DataSource = database.GetOrders();
                        Close();
                    }
                    else
                    {
                        database.closeConnection();
                        MessageBox.Show("Вибраний статус збігається з поточним.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show($"Оберіть статус замовлення або закрийте вікно", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка\n {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.closeConnection();
            }
            finally
            { database.closeConnection(); }
        }
    }
}
