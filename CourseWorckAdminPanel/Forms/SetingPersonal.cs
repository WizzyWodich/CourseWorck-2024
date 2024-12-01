using System;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles;

namespace CourseWorckAdminPanel.Forms
{
    public partial class SetingPersonal : Form
    {
        private Database database;
        public SetingPersonal()
        {
            InitializeComponent();
            database = new Database();
        }

        public Database Database
        {
            get => default;
            set
            {
            }
        }

        private void SetingPersonal_Load(object sender, EventArgs e)
        {
            LoadPanelPersonal();
        }

        private void LoadPanelPersonal()
        {
            DataGridAdminPanel.DataSource = database.GetAdminPanelPersonal();
        }

        private void btEditStatus_Click(object sender, EventArgs e)
        {
            if (DataGridAdminPanel.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(DataGridAdminPanel.SelectedRows[0].Cells["Id"].Value);
                string currentStatus = DataGridAdminPanel.SelectedRows[0].Cells["Status"].Value.ToString();
                string newStatus = null;

                if (rbAdmin.Checked)
                    newStatus = rbAdmin.Text;
                else if (rbOrder.Checked)
                    newStatus = "Курєр";
                else if (rbUser.Checked)
                    newStatus = rbUser.Text;

                if (newStatus != currentStatus)
                {
                    database.EditStatus(newStatus, userId);
                    rbAdmin.Checked = false;
                    rbOrder.Checked = false;
                    rbUser.Checked = false;
                    LoadPanelPersonal();
                }
                else
                    MessageBox.Show("Вибраний статус збігається з поточним.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Виберіть користувача, щоб змінити статус.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
