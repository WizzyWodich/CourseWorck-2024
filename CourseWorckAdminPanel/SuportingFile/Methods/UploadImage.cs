using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Сourse_WorkEX21.SupportingFiles.Methods
{
    class ImageUploader
    {
        private Database database;

        public ImageUploader(Database db)
        {
            database = db;
        }

        public Database Database
        {
            get => default;
            set
            {
            }
        }

        public void Upload(int userId, PictureBox pictureBox)
        {
            MySqlConnection connection = database.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE userpersonaldata SET Image = @Image WHERE RegistUserId = @UserId";

            Bitmap image = new Bitmap(pictureBox.Image);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                memoryStream.Position = 0;

                byte[] imageBytes = memoryStream.ToArray();

                MySqlParameter sqlParameter = new MySqlParameter("@Image", MySqlDbType.VarBinary, imageBytes.Length)
                {
                    Value = imageBytes
                };
                command.Parameters.Add(sqlParameter);
                command.Parameters.AddWithValue("@UserId", userId);
            }

            try
            {
                database.openConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Фото профиля успешно установлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
        }
    }
}
