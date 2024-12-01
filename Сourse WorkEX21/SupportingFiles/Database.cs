using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Сourse_WorkEX21.SupportingFiles
{
    public class Database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306" +
            ";user=root;password=root;database=courseworck");

        public void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Помилка бази даних\n {ex.Message}", "Помилка бази даних",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Помилка бази даних\n {ex.Message}", "Помилка бази даних",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public DataTable GetAssortment()
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                string query = "SELECT Name, Description FROM assortment";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Помилка бази даних\n {ex.Message}", "Помилка бази даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public bool ResetPersonalData(string FirstName, string LastName, string Adres, int UserId, int PhoneNumber, int UserRegistId)
        {
            try
            {
                string query = "UPDATE userpersonaldata " +
                                    "SET FirstName = @FirstName, LastName = @LastName, Adres = @Adres " +
                                    "WHERE RegistUserId = @UserId";

                string updateNumber = "UPDATE usersregist SET PhoneNumber = @PhoneNumber WHERE Id = @UserRegistId";

                openConnection();
                using (MySqlConnection connection = getConnection())
                {
                    MySqlCommand commandUpdateData = new MySqlCommand(query, connection);
                    MySqlCommand commandUpdateNumber = new MySqlCommand(updateNumber, connection);

                    commandUpdateData.Parameters.AddWithValue("@FirstName", FirstName);
                    commandUpdateData.Parameters.AddWithValue("@LastName", LastName);
                    commandUpdateData.Parameters.AddWithValue("@Adres", Adres);
                    commandUpdateData.Parameters.AddWithValue("@UserId", UserId);

                    commandUpdateNumber.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    commandUpdateNumber.Parameters.AddWithValue("@UserRegistId", UserRegistId);

                    int result1 = commandUpdateData.ExecuteNonQuery();
                    int result2 = commandUpdateNumber.ExecuteNonQuery();

                    if (result1 > 0 & result2 > 0)
                        return true;
                    else
                    {
                        MessageBox.Show("Дані не було оновлено. Перевірте правильність введених даних.",
                           "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                }
            }
            catch (Exception ex)
            {
                closeConnection();
                MessageBox.Show($"Помилка при оновленні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { closeConnection(); }
        }

        public bool ResetRegistredData(string new_login, string new_pass, int userID)
        {
            try
            {
                string query = "UPDATE usersregist " +
           "SET Login = @NewLogin, Password = @NewPassword " +
           "WHERE Id = @UserId";



                using (MySqlCommand command = new MySqlCommand(query, getConnection()))
                {
                    openConnection();

                    command.Parameters.AddWithValue("@NewLogin", new_login);
                    command.Parameters.AddWithValue("@NewPassword", new_pass);
                    command.Parameters.AddWithValue("@UserId", userID);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return true;
                    else
                    {
                        closeConnection();
                        MessageBox.Show("Дані не було оновлено. Перевірте правильність введених даних.",
                           "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                closeConnection();
                MessageBox.Show($"Помилка при оновленні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { closeConnection(); }
        }

        public void ResetPassword(string password, string email)
        {
            try
            {
                string query = "UPDATE usersregist SET Password = @password WHERE Email = @email";

                MySqlCommand command = new MySqlCommand(query, getConnection());
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);

                openConnection();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Пароль успішно змінено", "Успіх.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Пароль не змінено", "Помилка.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Пароль не змінено\n {ex.Message}", "Помилка бази даних",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла непередбачена помилка: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }

        }

        public void EditStatusOrders(string newStatus, int clientID, string email)
        {
            MessageFromEmail messageFromEmail = new MessageFromEmail();
            try
            {
                string query = $"UPDATE orderss SET status = '{newStatus}' WHERE Id = {clientID}";

                openConnection();
                MySqlCommand command = new MySqlCommand(query, getConnection());
                command.ExecuteNonQuery();

                messageFromEmail.SendMessageDeliveredOrder(email, newStatus);
                MessageBox.Show($"Статус замовлення успішно змінено на {newStatus}", "Повідомлення",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла непередбачена помилка: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
        }


        public DataTable GetOrders()
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                string query = "SELECT * FROM Orderss";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Помилка бази даних\n {ex.Message}", "Помилка бази даних",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public void AddOrderToDatabase(string firstName, string lastName, string orderText, string
            status, string email, string adres)
        {
            try
            {
                openConnection();

                string query = $"INSERT INTO Orderss (name, sname, ordersText, adres, status, email) " +
                    $"VALUES ('{firstName}', " +
                    $"'{lastName}', '{orderText}', '{adres}', '{status}', '{email}')";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                Console.WriteLine("Інформація про замовлення успішно додана до бази даних.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Помилка при додаванні інформації про замовлення до бази даних: {ex.Message}",
                    "Помилка бази даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
