using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles;
using Сourse_WorkEX21.SupportingFiles.Checks;

namespace Сourse_WorkEX21.AllForms
{
    public partial class ResetPassword : Form
    {
        private string codeReset;

        private string Passwod { get { return tbPasswordResetPassForm.Text; } }
        private string ConfirmationPasswod { get { return tbConfirmPasswordResetPassForm.Text; } }
        private string Email { get { return tbEmailResetPassForm.Text; } }
        private string ConfirmationResetCode { get { return tbConfirmCodeResetPassForm.Text; } }

        private GeneralVerificationClass verificationClass;
        private CheakConfirmEmail cheakConfirmEmaill;
        private MessageFromEmail autorizationEmail;
        private ValidationPassword validationPassword;
        private Database database;
        private Random random;

        private void GenerateConfirmationCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            codeReset = new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public ResetPassword()
        {
            InitializeComponent();
            tbPasswordResetPassForm.UseSystemPasswordChar = true;
            tbConfirmPasswordResetPassForm.UseSystemPasswordChar = true;

            verificationClass = new GeneralVerificationClass(Passwod, ConfirmationPasswod, Email);
            validationPassword = new ValidationPassword();
            autorizationEmail = new MessageFromEmail();
            cheakConfirmEmaill = new CheakConfirmEmail();
            database = new Database();
            random = new Random();
        }

        private void cbShowPassResetPassForm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassResetPassForm.Checked)
            {
                tbPasswordResetPassForm.UseSystemPasswordChar = false;
                tbConfirmPasswordResetPassForm.UseSystemPasswordChar = false;
            }
            else
            {
                tbPasswordResetPassForm.UseSystemPasswordChar = true;
                tbConfirmPasswordResetPassForm.UseSystemPasswordChar = true;
            }
        }

        private void EnterCodeReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Email))
                    MessageBox.Show($"Рядок електронної пошти пуcта. Заповніть її", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    GenerateConfirmationCode();
                    autorizationEmail.SendCodeResetPassword(Email, codeReset);
                    MessageBox.Show($"Код для скидання пароля {Email}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void btResetResetPassForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Passwod) || string.IsNullOrEmpty(ConfirmationPasswod) || string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(ConfirmationResetCode))
                    MessageBox.Show("Введіть код перевірки.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (verificationClass.checkPassword())
                    return;
                if (cheakConfirmEmaill.cheakConfirmCodeEmail(ConfirmationResetCode, codeReset))
                    return;
                if (!validationPassword.Validate(Passwod))
                    return;
                else
                {
                    database.ResetPassword(Passwod, Email);
                    codeReset = string.Empty;
                    Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Пароль не змінено\n {ex.Message}", "Помилка бази даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.closeConnection();
            }
        }
        private void btCloseResetPassForm_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
