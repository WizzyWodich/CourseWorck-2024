using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Сourse_WorkEX21.SupportingFiles.Checks
{
    public class ValidationLogin : BaseValidation 
    {
        public override bool Validate(string input) 
        {
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{4,12}");

            return ValidateInput(input, "Поле з логіном порожнє", "Логін має містити хоча б одну малу літеру," +
                " одну велику літеру та бути довшим за 4 символи", hasLowerChar) &&
                   ValidateInput(input, "Поле з логіном порожнє", "Логін має містити хоча б одну малу літеру," +
                   " одну велику літеру та бути довшим за 4 символи", hasUpperChar) &&
                   ValidateInput(input, "Поле з логіном порожнє", "Логін має містити хоча б одну малу літеру," +
                   " одну велику літеру та бути довшим за 4 символи", hasMiniMaxChars);
        }
    }
}
