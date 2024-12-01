using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles.Methods;
using Сourse_WorkEX21.SupportingFiles;

namespace CourseWorckAdminPanel.Forms
{
    public partial class Home : Form
    {
        private Database database;

        MessageFromEmail messageFrom;
        public Home()
        {
            InitializeComponent();
            database = new Database();

            DataGridMain.DataSource = database.GetAssortment();
            DataGridMain.ReadOnly = false;
            DataGridViewCheckBoxColumn checkBoxColumn = CreateCheckboxColumn();
            int columnIndexToInsertAfter = 1;
            DataGridMain.Columns.Insert(columnIndexToInsertAfter + 1, checkBoxColumn);


            messageFrom = new MessageFromEmail();
        }

        public MessageFromEmail MessageFromEmail
        {
            get => default;
            set
            {
            }
        }

        public Database Database
        {
            get => default;
            set
            {
            }
        }

        private DataGridViewCheckBoxColumn CreateCheckboxColumn()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Выбор";
            checkBoxColumn.Name = "checkBoxColumn";
            checkBoxColumn.Width = 50;
            return checkBoxColumn;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            DataGridMain.DataSource = database.GetAssortment();
        }

        private void DataGridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridMain.Columns["checkBoxColumn"].Index && e.RowIndex != -1)
            {
                string selectedDish = DataGridMain.Rows[e.RowIndex].Cells["Name"].Value.ToString();

                if (DataGridMain.Rows[e.RowIndex].Cells["checkBoxColumn"].Value != null &&
                    (bool)DataGridMain.Rows[e.RowIndex].Cells["checkBoxColumn"].Value)
                {
                    if (clbBasket.Items.Contains(selectedDish))
                    {
                        // MessageBox.Show("Товар вже у корзині");
                        return;
                    }
                    DataGridMain.Rows[e.RowIndex].Cells["checkBoxColumn"].Value = false;
                }
                else
                {
                    clbBasket.Items.Add(selectedDish);
                    DataGridMain.Rows[e.RowIndex].Cells["checkBoxColumn"].Value = true;
                }
            }
        }

        private void btDeleteBasket_Click(object sender, EventArgs e)
        {
            for (int i = clbBasket.Items.Count - 1; i >= 0; i--)
            {
                if (clbBasket.GetItemChecked(i))
                {
                    clbBasket.Items.RemoveAt(i);
                }
            }
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            PersonalData personalData = new PersonalData();
            List<string> selectedDishes = new List<string>();
            foreach (var item in clbBasket.CheckedItems)
            {
                selectedDishes.Add(item.ToString());
            }

            if (selectedDishes.Count > 0)
            {
                string userEmail = personalData.getEmailUser();
                messageFrom.SendOrderConfirmation(userEmail, selectedDishes);

                string firstName = personalData.getFirstName();
                string lastName = personalData.getLastName();
                string adres = personalData.getAdresUser();
                string orderText = GetOrderTextFromListBox();
                string email = personalData.getEmailUser();
                string status = "Очікування";

                database.AddOrderToDatabase(firstName, lastName, orderText, status, email, adres);

                clbBasket.Items.Clear();

                MessageBox.Show("Замовлення успішно відправлено.");
            }
            else
            {
                MessageBox.Show("Виберіть хоча б одне блюдо для замовлення.");
            }


        }

        private string GetOrderTextFromListBox()
        {
            string orderText = "";
            foreach (var item in clbBasket.Items)
            {
                orderText += item.ToString() + "\n";
            }
            return orderText;
        }
    }
}
