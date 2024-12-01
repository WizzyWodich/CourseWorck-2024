using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Сourse_WorkEX21.SupportingFiles.Checks;
using Сourse_WorkEX21.SupportingFiles.Methods;
using Сourse_WorkEX21.SupportingFiles;
using MySql.Data.MySqlClient;

namespace CourseWorckAdminPanel.Forms
{
    public partial class SetingsForm : Form
    {
        private string CodeToEmail;
        protected Database database;
        private PersonalData personalData;
        private CheakConfirmEmail confirmationClass;

        public string FName { get { return tbNameSF.Text; } set { } }
        public string Sname { get { return tbSnameSF.Text; } set { } }
        public string Adres { get { return tbAdresSF.Text; } set { } }
        public string Email { get { return tbEmailSF.Text; } set { } }
        public string NumberPhone { get { return tbNumberPhoneSF.Text; } set { } }
        public string Login { get { return tbLoginSF.Text; } set { } }
        public string Password { get { return tbPasswordSF.Text; } set { } }
        public string CodeConfirm { get { return tbCodeSF.Text; } set { } }

        public MessageFromEmail MessageFromEmail
        {
            get => default;
            set
            {
            }
        }

        public Database Database
        {
            get => default;
            set
            {
            }
        }

        public PersonalData PersonalData
        {
            get => default;
            set
            {
            }
        }

        public SetingsForm()
        {
            InitializeComponent();
            database = new Database();
            personalData = new PersonalData();
            confirmationClass = new CheakConfirmEmail();
            tbPasswordSF.UseSystemPasswordChar = true;
        }

        private void GenerateConfirmationCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            CodeToEmail = new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SetingsForm_Load(object sender, EventArgs e)
        {
            LoadPersonalData();
            tbLoginSF.Enabled = false;
            tbPasswordSF.Enabled = false;
            tbStatusSF.Enabled = false;
            tbNameSF.Enabled = false;
            tbSnameSF.Enabled = false;
            tbAdresSF.Enabled = false;
            tbEmailSF.Enabled = false;
            tbNumberPhoneSF.Enabled = false;
            cbShowPass.Enabled = true;

            btSaveLogData.Enabled = false;
            btSavePersonalData.Enabled = false;
        }

        private void LoadPersonalData()
        {
            tbLoginSF.Text = PersonalData.Login;
            tbPasswordSF.Text = PersonalData.Password;
            tbStatusSF.Text = PersonalData.Status;
            tbNameSF.Text = PersonalData.FirstName;
            tbSnameSF.Text = PersonalData.LastName;
            tbAdresSF.Text = PersonalData.Adres;
            tbEmailSF.Text = PersonalData.Email;
            tbNumberPhoneSF.Text = PersonalData.NumberPhone;

            pbImageProfilSF.Image = personalData.LoadProfileImage();
            pbImageProfilSF.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbPasswordSF.UseSystemPasswordChar = false;
            }
            else
            {
                tbPasswordSF.UseSystemPasswordChar = true;
            }
        }
        private bool checkConfirmationCode(string ConfirmationEmail, string CodeToEmail) => ConfirmationEmail == CodeToEmail;

        private void btConfirmCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeSF.Text))
            {
                GenerateConfirmationCode();

                MessageFromEmail autorizationEmail = new MessageFromEmail();
                autorizationEmail.SendCodeEditSetings(Email, CodeToEmail);
                MessageBox.Show($"Код надіслано на пошту {Email}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btConfirmCode.Text = "Перевірити код";
            }
            else if (checkConfirmationCode(CodeConfirm, CodeToEmail))
            {
                MessageBox.Show("Код введений вірно.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLoginSF.Enabled = true;
                tbPasswordSF.Enabled = true;
                tbNameSF.Enabled = true;
                tbSnameSF.Enabled = true;
                tbAdresSF.Enabled = true;
                tbEmailSF.Enabled = true;
                tbNumberPhoneSF.Enabled = true;
                cbShowPass.Enabled = true;

                btSaveLogData.Enabled = true;
                btSavePersonalData.Enabled = true;

                tbCodeSF.Enabled = false;
                btConfirmCode.Enabled = false;
                btConfirmCode.Text = "Надіслати код";
            }
            else if (!checkConfirmationCode(CodeConfirm, CodeToEmail))
            {
                MessageBox.Show($"Перевірте код ще раз", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSaveLogData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoginSF.Text) || string.IsNullOrEmpty(tbPasswordSF.Text))
            {
                MessageBox.Show("Всі поля необхідно заповнити", "Уведомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Змінити логін і пароль?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (database.ResetRegistredData(Login, Password, personalData.getUserID()))
                    {
                        MessageBox.Show("Дані успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        personalData.UpdateRegistrationlData(Login, Password);

                        tbLoginSF.Enabled = false;
                        tbPasswordSF.Enabled = false;
                        tbCodeSF.Text = string.Empty;

                        LoadPersonalData();
                    }
                    else
                    {
                        MessageBox.Show("Дані не було оновлено. Перевірте правильність введених даних.", "Помилка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при оновленні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Дія була скасована!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btSavePersonalData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameSF.Text) || string.IsNullOrEmpty(tbSnameSF.Text) || string.IsNullOrEmpty(tbAdresSF.Text) ||
                string.IsNullOrEmpty(tbEmailSF.Text) || string.IsNullOrEmpty(tbNumberPhoneSF.Text))
            {
                MessageBox.Show("Всі поля необхідно заповнити", "Уведомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!confirmationClass.confirmEmail(Email))
            {
                MessageBox.Show("Підтримується лише пошта gmail.com");
                return;
            }
            DialogResult result = MessageBox.Show("Оновити персональні дані?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (database.ResetPersonalData(FName, Sname, Adres, personalData.getUserID(),
                        int.Parse(NumberPhone), personalData.getUserID()))
                    {
                        MessageBox.Show("Дані успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        personalData.UpdatePersonalData(Login, Password);

                        tbAdresSF.Enabled = false;
                        tbEmailSF.Enabled = false;
                        tbNumberPhoneSF.Enabled = false;
                        tbSnameSF.Enabled = false;
                        tbNameSF.Enabled = false;
                        tbCodeSF.Text = string.Empty;

                        LoadPersonalData();
                    }
                    else
                        MessageBox.Show("Дані не було оновлено. Перевірте правильність введених даних.", "Помилка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Дія була скасована!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btImageSelect_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbImageProfilSF.SizeMode = PictureBoxSizeMode.Zoom;
                    pbImageProfilSF.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
        private void btSaveImage_Click(object sender, EventArgs e)
        {
            ImageUploader uploader = new ImageUploader(database);
            uploader.Upload(PersonalData.IdUser, pbImageProfilSF);
        }
    }
}
