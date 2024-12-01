using System.Text.RegularExpressions;
using Сourse_WorkEX21.SupportingFiles.Checks;

public class ValidationPassword : BaseValidation
{
    public override bool Validate(string password) 
    {
        var hasLowerChar = new Regex(@"[a-z]+");
        var hasUpperChar = new Regex(@"[A-Z]+");
        var hasMiniMaxChars = new Regex(@".{6,12}");
        var hasNumber = new Regex(@"[0-9]+");

        return ValidateInput(password, "Поле з паролем порожнє", "Пароль має містити хоча б одну малу літеру," +
            " одну велику літеру, одне число та бути довшим за 6 символів", hasLowerChar) &&
               ValidateInput(password, "Поле з паролем порожнє", "Пароль має містити хоча б одну малу літеру," +
               " одну велику літеру, одне число та бути довшим за 6 символів", hasUpperChar) &&
               ValidateInput(password, "Поле з паролем порожнє", "Пароль має містити хоча б одну малу літеру," +
               " одну велику літеру, одне число та бути довшим за 6 символів", hasMiniMaxChars) &&
               ValidateInput(password, "Поле з паролем порожнє", "Пароль має містити хоча б одну малу літеру," +
               " одну велику літеру, одне число та бути довшим за 6 символів", hasNumber);
    }
}