using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles.Checks;

namespace Сourse_WorkEX21.SupportingFiles.Methods
{
    public class Registration
    {
        private string Login;
        private string Password;
        private string ConfirmationPasswod;
        private string PhoneNumber;
        private string Email;
        private string ConfirmationEmail;
        private string CodeToEmail;
        private bool isFirstUser;
        private string Status;

        private DateTime RegistrationDateTime;
        private Database database;
        private ValidationPassword validationPassword;
        private ValidationLogin validationLogin;
        private GeneralVerificationClass verificationClass;

        public Registration(string Login, string Password, string ConfirmationPasswod, string PhoneNumber, string Email, string ConfirmationEmail, string CodeToEmail)
        {
            this.Login = Login;
            this.Password = Password;
            this.ConfirmationPasswod = ConfirmationPasswod;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.ConfirmationEmail = ConfirmationEmail;
            this.RegistrationDateTime = DateTime.Now;
            this.CodeToEmail = CodeToEmail;
        }

        public void RegistrationMethod()
        {
            try
            {
                database = new Database();
                validationLogin = new ValidationLogin();
                validationPassword = new ValidationPassword();
                verificationClass = new GeneralVerificationClass(Login, Password, ConfirmationPasswod, Email);

                if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmationPasswod) || string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(ConfirmationEmail))
                    MessageBox.Show("Введіть код перевірки.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (verificationClass.checkLoginAndPassword())
                    return;
                if (verificationClass.checkPassword())
                    return;
                if (verificationClass.isUserExist())
                    return;
                if (!validationPassword.Validate(Password)) // Если вернет лож тогда будет вывод строчек 
                    return;
                if (!validationLogin.Validate(Login))
                    return;

                isFirstUser = verificationClass.isFirstUser();
                Status = isFirstUser ? "Адміністратор" : "Користувач";

                int newUserId = 0;
                string query = "INSERT INTO `usersregist` ( `Login`, `Password`, `Email`, `PhoneNumber`, `Status`, `DataRegistration`) VALUES ( @login, @password, @email, @numberPhone, @status, @dataRegistration)";
                using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
                {
                    command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
                    command.Parameters.Add("@numberPhone", MySqlDbType.Int32).Value = PhoneNumber;
                    command.Parameters.Add("@status", MySqlDbType.VarChar).Value = Status;
                    command.Parameters.Add("@dataRegistration", MySqlDbType.DateTime).Value = RegistrationDateTime;

                    database.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        newUserId = (int)command.LastInsertedId;
                        MessageBox.Show($"Обліковий запис успішно створено", "Успіх.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CodeToEmail = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show($"Обліковий запис не створено", "Помилка.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                string queryUserPersonalData = "INSERT INTO `userpersonaldata` (`RegistUserId`, `FirstName`, `LastName`, `Adres`) VALUES (@userId, '', '', '')";
                using (MySqlCommand commandUserPersonalData = new MySqlCommand(queryUserPersonalData, database.getConnection()))
                {
                    commandUserPersonalData.Parameters.AddWithValue("@userId", newUserId);
                    commandUserPersonalData.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Обліковий запис не було створено\n {ex.Message}", "Помилка бази даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка\n {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }
    }
}
