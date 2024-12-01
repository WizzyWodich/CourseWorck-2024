using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles;
using Сourse_WorkEX21.SupportingFiles.Checks;
using Сourse_WorkEX21.SupportingFiles.Methods;

namespace Сourse_WorkEX21.AllForms
{
    public partial class RegistationForm : Form
    {

        private string CodeToEmail;

        private string Login { get { return tbLoginUserRegistrationForm.Text; } }
        private string Passwod { get { return tbPasswordregistrationForm.Text; } }
        private string ConfirmationPasswod { get { return tbConfirmationPasswordRegistrationForm.Text; } }
        private string Email { get { return tbEmailRegistrationForm.Text; } }
        private string PhoneNumber { get { return tbPhoneNumberRegistrationForm.Text; } }
        private string ConfirmationEmail { get { return tbConfirmationEmailRegistrationForm.Text; } }

        private GeneralVerificationClass verificationClass;
        private CheakConfirmEmail confirmationClass;

        private void GenerateConfirmationCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            CodeToEmail = new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public RegistationForm()
        {
            InitializeComponent();
            tbPasswordregistrationForm.UseSystemPasswordChar = true;
            tbConfirmationPasswordRegistrationForm.UseSystemPasswordChar = true;
            tbLoginUserRegistrationForm.Enabled = false;
            tbPasswordregistrationForm.Enabled = false;
            tbConfirmationPasswordRegistrationForm.Enabled = false;

            verificationClass = new GeneralVerificationClass(Login, Passwod, ConfirmationPasswod, Email);
            confirmationClass = new CheakConfirmEmail();
        }


        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPont;


        private void lbLoginFormRegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            lbLoginFormRegistrationForm.ForeColor = MyColors.x72_LightBlackkActive;
        }

        private void lbLoginFormRegistrationForm_MouseLeave(object sender, EventArgs e)
        {
            lbLoginFormRegistrationForm.ForeColor = MyColors.defaultForeColorColorButton;
        }

        private void btCloseregistrationForm_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btMinimizeRegistrationForm_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void lbLoginFormRegistrationForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btEnterCodeAuntificationEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show($"Рядок електронної пошти пуcта. Заповніть її", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (confirmationClass.isEmailExist(Email))
                    return;
                else if (!confirmationClass.confirmEmail(Email))
                {
                    MessageBox.Show("Підтримується лише пошта gmail.com");
                    return;
                }
                else
                {
                    GenerateConfirmationCode();

                    MessageFromEmail autorizationEmail = new MessageFromEmail();
                    autorizationEmail.SendCodeAutorization(Email, CodeToEmail);
                    MessageBox.Show($"Код надіслано на пошту {Email}", "Повідомлення",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void cbShowPassLoginForm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassLoginForm.Checked)
            {
                tbPasswordregistrationForm.UseSystemPasswordChar = false;
                tbConfirmationPasswordRegistrationForm.UseSystemPasswordChar = false;
            }
            else
            {
                tbPasswordregistrationForm.UseSystemPasswordChar = true;
                tbConfirmationPasswordRegistrationForm.UseSystemPasswordChar = true;
            }

        }

        private void btRegistRegistrationForm_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(Login, Passwod, ConfirmationPasswod,
                PhoneNumber, Email, ConfirmationEmail, CodeToEmail);
            registration.RegistrationMethod();
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

        private void ibInfoRegistForm_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        // private bool checkConfirmationCode(string ConfirmationEmail, string CodeToEmail) => ConfirmationEmail == CodeToEmail;

        private void btCheckCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show($"Рядок електронної пошти пута. Заповніть її", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(ConfirmationEmail))
            {
                MessageBox.Show("Введіть код перевірки.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!confirmationClass.cheakConfirmCodeEmail(ConfirmationEmail, CodeToEmail))
            {
                MessageBox.Show("Код введений вірно.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLoginUserRegistrationForm.Enabled = true;
                tbPasswordregistrationForm.Enabled = true;
                tbConfirmationPasswordRegistrationForm.Enabled = true;
            }

            else
            {
                return;
                // MessageBox.Show("Введений код невірний.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
