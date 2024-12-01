using System;
using System.Drawing;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles;
using Сourse_WorkEX21.SupportingFiles.Methods;

namespace Сourse_WorkEX21.AllForms
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

        private void lbRegistrationNewUser_MouseMove(object sender, MouseEventArgs e)
        {
            lbRegistrationNewUser.ForeColor = MyColors.x72_LightBlackkActive;
        }

        private void lbRegistrationNewUser_MouseLeave(object sender, EventArgs e)
        {
            lbRegistrationNewUser.ForeColor = MyColors.defaultForeColorColorButton;
        }

        private void lbRegistrationNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistationForm registationForm = new RegistationForm();
            registationForm.Show();
        }

        private void btInputLoginForm_Click(object sender, EventArgs e)
        {
            try
            {
                var login = tbLoginUserForm.Text;
                var password = tbPasswordLoginForm.Text;

                var personalData = new PersonalData();
                string role = personalData.GetUserRole(login, password);

                if (personalData.getPersonalData(login, password))
                {
                    if (!string.IsNullOrEmpty(role))
                    {
                        if (role == "Користувач")
                        {
                            MessageBox.Show("Ви увійшли як користувач!", "Успіх", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Hide();
                            GForm gForm = new GForm();
                            gForm.Show();
                        }
                        else if (role == "Курєр")
                        {
                            MessageBox.Show("Ви увійшли як кур'єр!", "Успіх", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Hide();
                            GForm gForm = new GForm();
                            gForm.pnOrderGFVise = true;
                            gForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Невідома роль користувача!\n " +
                                "Якщо ви є адміністратором, цей клієнт не підтримує панель адміністратора.\n " +
                                "Для адміністраторів було створено окремий клієнт програми.", "Помилка", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Користувача не знайдено або роль не визначена.", "Помилка", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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
            lbResetPassword.ForeColor = MyColors.x72_LightBlackkActive;
        }

        private void lbResetPassword_MouseLeave(object sender, EventArgs e)
        {
            lbResetPassword.ForeColor = MyColors.defaultForeColorColorButton;
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
    }
}
