using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Сourse_WorkEX21.SupportingFiles.Checks
{
    public class GeneralVerificationClass
    {
        private string Login;
        private string Password;
        private string RepeatPassword;
        private string Email;
        private Database database = new Database();
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();



        public GeneralVerificationClass(string Login, string Password, string RepeatPassword, string Email)
        {
            this.Login = Login;
            this.Password = Password;
            this.RepeatPassword = RepeatPassword;
            this.Email = Email;
        }

        public GeneralVerificationClass(string Password, string RepeatPassword, string Email)
        {
            this.Password = Password;
            this.RepeatPassword = RepeatPassword;
            this.Email = Email;
        }

        public Database Database
        {
            get => default;
            set
            {
            }
        }

        //

        // 2. Проверка БД на наличие записей
        public Boolean isFirstUser()
        {
            string query = "SELECT COUNT(*) FROM usersregist";
            using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
            {
                database.openConnection();
                int userCount = Convert.ToInt32(command.ExecuteScalar());
                database.closeConnection();

                if (userCount == 0)
                    return true;
                else
                    return false;
            }
        }

        // 4. Проверка БД на дубликат логина
        public Boolean isUserExist()
        {
            string query = "SELECT * FROM `usersregist` WHERE `Login` = @Login";
            using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
            {
                command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такий логін вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }

        // 5. Проверка логина и пароля на схожость
        public Boolean checkLoginAndPassword()
        {
            if (this.Login == this.Password)
            {
                MessageBox.Show("Паролм і логін не повинні збігатися", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                return false;
        }

        // 6. Проверка паролей на совпадение
        public Boolean checkPassword()
        {
            if (this.Password != this.RepeatPassword)
            {
                MessageBox.Show("Паролі не співпадають", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                return false;

        }
    }
}
