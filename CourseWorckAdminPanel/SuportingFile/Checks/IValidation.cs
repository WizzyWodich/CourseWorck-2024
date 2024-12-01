using System.Text.RegularExpressions;

namespace CourseWorckAdminPanel
{
    public interface IValidation 
    {
        bool Validate(string input); 
    }
}
