using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Сourse_WorkEX21.SupportingFiles.Checks
{

    public class CheakConfirmEmail
    {
        private Database database = new Database();
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public Boolean cheakConfirmCodeEmail(string currentCode, string curentEmail)
        {
            if (curentEmail != currentCode)
            {
                MessageBox.Show("Невірний код підтвердження", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }


        public Boolean confirmEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            return Regex.IsMatch(email, pattern);
        }


        public Boolean isEmailExist(string Email)
        {
            string query = "SELECT * FROM `usersregist` WHERE `Email` = @Email";
            using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
            {
                command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Ця пошта зайнята.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
