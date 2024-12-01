using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWorckAdminPanel
{
    public abstract class BaseValidation : IValidation 
    {
        public abstract bool Validate(string input); 

        protected bool ValidateInput(string input, string emptyFieldMessage, string errorMessage, Regex rule)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show(emptyFieldMessage, "Помилка");
                return false;
            }

            if (!rule.IsMatch(input))
            {
                MessageBox.Show(errorMessage, "Помилка");
                return false;
            }

            return true;
        }
    }
}
