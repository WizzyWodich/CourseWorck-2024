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
    public partial class LoginForm : Form
    {
        private Database database;
        private string Login { get { return tbLoginUserForm.Text; } }
        private string Passwod { get { return tbPasswordLoginForm.Text; } }
        public LoginForm()
        {
            InitializeComponent();
            database = new Database();
            tbPasswordLoginForm.UseSystemPasswordChar = true;
        }
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPont;

        private void btCloseLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btMinimizeLoginForm_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }
                      

        private void btInputLoginForm_Click(object sender, EventArgs e)
        {
            try
            {
                var login = tbLoginUserForm.Text;
                var password = tbPasswordLoginForm.Text;

                var personalData = new PersonalData();
                string role = personalData.GetUserRole(login, password);

                if (personalData.SetPersonalData(login, password))
                {
                    if (!string.IsNullOrEmpty(role))
                    {
                        if (role == "Адміністратор")
                        {
                            MessageBox.Show("Ви увійшли як адміністратор!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            AdminGForm adminGForm = new AdminGForm();
                            adminGForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Цей клієнт був створений спеціально тільки для адміністраторів.\n Використовуйте звичайний клієнт програми!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Користувача не знайдено або роль не визначена.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Користувача не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cbShowPassLoginForm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassLoginForm.Checked)
            {
                tbPasswordLoginForm.UseSystemPasswordChar = false;
            }
            else
            {
                tbPasswordLoginForm.UseSystemPasswordChar = true;
            }
        }

        private void lbResetPassword_MouseMove(object sender, MouseEventArgs e)
        {
            lbResetPassword.ForeColor = Color.FromArgb(46, 46, 46);
        }

        private void lbResetPassword_MouseLeave(object sender, EventArgs e)
        {
            lbResetPassword.ForeColor = Color.WhiteSmoke;
        }

        private void lbResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.ShowDialog();
        }

        private void pnTopLoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnTopLoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPont, new Size(dif));
            }
        }

        private void pnTopLoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPont = this.Location;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btInputLoginForm.PerformClick();
            }
        }

        public Database Database
        {
            get => default;
            set
            {
            }
        }
    }
}
