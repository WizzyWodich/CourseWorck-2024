using System;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;

namespace Сourse_WorkEX21.SupportingFiles
{
    public class MessageFromEmail
    {
        public void SendCodeAutorization(string userEmail, string codeSecurity)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "your_email";
            string smtpPassword = "your_secret_password";
            string senderName = "Техпідтримка ресторану Fast";


            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername, senderName);
                    mailMessage.To.Add(userEmail);
                    mailMessage.Subject = "Код підтвердження. Реєстрація";
                    mailMessage.Body = $"Ваш код підтвердження для реєстрації. Нікому не передавайте його:\n {codeSecurity}";

                    try
                    {
                        smtpClient.Send(mailMessage);
                        Console.WriteLine("Повідомлення успішно відправлено.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка надсилання повідомлення: {ex.Message}");
                    }
                }
            }
        }

        public void SendCodeEditSetings(string userEmail, string codeSecurity)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "your_email";
            string smtpPassword = "your_secret_password";
            string senderName = "Техпідтримка ресторану Fast";


            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername, senderName);
                    mailMessage.To.Add(userEmail);
                    mailMessage.Subject = "Код підтвердження.";
                    mailMessage.Body = $"Ваш код підтвердження для зміни данних у додатку. Нікому не передавайте його:\n {codeSecurity}";

                    try
                    {
                        smtpClient.Send(mailMessage);
                        Console.WriteLine("Повідомлення успішно відправлено.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка надсилання повідомлення: {ex.Message}");
                    }
                }
            }
        }

        public void SendCodeResetPassword(string userEmail, string codeSecurity)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "your_email";
            string smtpPassword = "your_secret_password";
            string senderName = "Техпідтримка ресторану Fast";


            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername, senderName);
                    mailMessage.To.Add(userEmail);
                    mailMessage.Subject = "Код зміни пароля";
                    mailMessage.Body = $"Ваш код для зміни пароля. Нікому не передавайте його:\n {codeSecurity}";

                    try
                    {
                        smtpClient.Send(mailMessage);
                        Console.WriteLine("Повідомлення успішно відправлено.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка надсилання повідомлення: {ex.Message}");
                    }
                }
            }
        }

        public void SendOrderConfirmation(string userEmail, List<string> selectedDishes)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "your_email";
            string smtpPassword = "your_secret_password";
            string senderName = "Доставка ресторану Fast";


            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername, senderName);
                    mailMessage.To.Add(userEmail);
                    mailMessage.Subject = "Замовлення з ресторану";
                    mailMessage.Body = "Ваше замовлення:\n";
                    foreach (var dish in selectedDishes)
                    {
                        mailMessage.Body += $"{dish}\n";
                    }

                    try
                    {
                        smtpClient.Send(mailMessage);
                    }
                    catch (System.Exception ex)
                    {
                        System.Console.WriteLine($"Error sending email: {ex.Message}");
                    }
                }
            }
        }
    }
}
