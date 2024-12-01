using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles;

namespace CourseWorckAdminPanel.Forms
{
    public partial class AdminPanel : Form
    {
        private Database database;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        public AdminPanel()
        {
            InitializeComponent();
            database = new Database();
            adapter = new MySqlDataAdapter();
            dataTable = new DataTable();
        }

        public Database Database
        {
            get => default;
            set
            {
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadAssortmentData();
        }

        private void LoadAssortmentData()
        {
            DataGridAdminPanel.DataSource = database.GetAdminPanelAssortment();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            RefreshAssortmentData();
        }

        private void RefreshAssortmentData()
        {
            DataGridAdminPanel.DataSource = null;
            LoadAssortmentData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string description = tbDescription.Text;

            database.AddAssortiment(name, description);
            tbName.Text = string.Empty;
            tbDescription.Text = string.Empty;

            LoadAssortmentData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbIdDeleteProd.Text))
                {
                    MessageBox.Show("Рядок id порожній", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (database.isFirstDeleteNameAssortiment(int.Parse(tbIdDeleteProd.Text)) == false)
                    {
                        return;
                    }
                    else
                    {
                        database.DeleteProduct(int.Parse(tbIdDeleteProd.Text));
                        tbIdDeleteProd.Text = string.Empty;
                        LoadAssortmentData();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть цифру", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
