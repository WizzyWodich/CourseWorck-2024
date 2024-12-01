using System;
using System.Security.Cryptography;
using System.Text;

namespace Сourse_WorkEX21.SupportingFiles
{
    public class Hashing
    {
        public string Hash(string input)
        {
            using (var sha128 = SHA1.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha128.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hash);
            }
        }

        public bool Verify(string password, string hashedPassword)
        {
            string hashedInputPassword = Hash(password);
            return hashedInputPassword == hashedPassword;
        }
    }
}
