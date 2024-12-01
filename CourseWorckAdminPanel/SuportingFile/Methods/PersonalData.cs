using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using CourseWorckAdminPanel.Forms;
using System.Drawing.Imaging;
using CourseWorckAdminPanel.Properties;

namespace Сourse_WorkEX21.SupportingFiles.Methods
{
    public class PersonalData 
    {
        public static int IdUser { get; set; }
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string Status { get; set; }
        public static string LastName { get; set; }
        public static string FirstName { get; set; }
        public static string NumberPhone { get; set; }
        public static string Adres { get; set; }
        public static string Email { get; set; }
        public static string DataRegistration { get; set; }


        public int getUserID() => IdUser;
        public string getLastName() => LastName;
        public string getFirstName() => FirstName;
        public string getEmailUser() => Email;
        public string getAdresUser() => Adres;

        private Database database = new Database();

        public bool SetPersonalData(string login, string password)
        {
            try
            {
                string query = "SELECT * FROM usersregist ur LEFT JOIN userpersonaldata upd ON upd.RegistUserId = ur.Id WHERE ur.Login = @Login AND ur.Password = @Password LIMIT 1";

                using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    database.openConnection();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            IdUser = reader.IsDBNull(reader.GetOrdinal("RegistUserId")) ? 0 : reader.GetInt32(reader.GetOrdinal("RegistUserId"));
                            Login = reader.IsDBNull(reader.GetOrdinal("Login")) ? string.Empty : reader["Login"].ToString();
                            Password = reader.IsDBNull(reader.GetOrdinal("Password")) ? string.Empty : reader["Password"].ToString();
                            Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? string.Empty : reader["Status"].ToString();
                            LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? string.Empty : reader["LastName"].ToString();
                            FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? string.Empty : reader["FirstName"].ToString();
                            NumberPhone = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? string.Empty : reader["PhoneNumber"].ToString();
                            Adres = reader.IsDBNull(reader.GetOrdinal("Adres")) ? string.Empty : reader["Adres"].ToString();
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader["Email"].ToString();
                            DataRegistration = reader.IsDBNull(reader.GetOrdinal("DataRegistration")) ? string.Empty : DateTime.Parse(reader["DataRegistration"].ToString()).ToString("yyyy-MM-dd");
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (MySqlException)
            {
                database.closeConnection();
                return false;
            }
            finally
            {
                database.closeConnection();
            }
        }

        public void UpdateRegistrationlData(string login, string password)
        {
            if (SetPersonalData(login, password))
            {
                SetingsForm setingsForm = new SetingsForm();
                if (setingsForm != null)
                {
                    database.closeConnection();

                    setingsForm.Login = Login;
                    setingsForm.Password = Password;
                }
            }
        }

        public void UpdatePersonalData(string login, string password)
        {
            if (SetPersonalData(login, password))
            {
                SetingsForm setingsForm = new SetingsForm();
                if (setingsForm != null)
                {
                    database.closeConnection();

                    setingsForm.FName = FirstName;
                    setingsForm.Sname = LastName;
                    setingsForm.Adres = Adres;
                    setingsForm.Email = Email;
                    setingsForm.NumberPhone = NumberPhone;
                }
            }
        }

        public Image LoadProfileImage()
        {
            try
            {
                string query = "SELECT Image FROM userpersonaldata WHERE RegistUserId = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@UserId", IdUser);

                    database.openConnection();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                byte[] imageBytes = (byte[])reader["Image"];
                                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                                {
                                    return Image.FromStream(memoryStream);
                                }
                            }
                        }
                    }
                    return LoadDefaultImage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні фото профіля: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }

            return null;
        }

        private Image LoadDefaultImage()
        {
            try
            {
                return Resources.UserIcon;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні базового фото профіля: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public string GetUserRole(string login, string password)
        {
            try
            {
                string query = "SELECT Status FROM usersregist ur LEFT JOIN userpersonaldata upd ON upd.RegistUserId = ur.Id WHERE ur.Login = @Login AND ur.Password = @Password LIMIT 1";

                using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    database.openConnection();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.IsDBNull(reader.GetOrdinal("Status")) ? string.Empty : reader["Status"].ToString();
                        }
                    }
                    return string.Empty;
                }
            }
            catch (MySqlException)
            {
                database.closeConnection();
                return string.Empty;
            }
            finally
            {
                database.closeConnection();
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
