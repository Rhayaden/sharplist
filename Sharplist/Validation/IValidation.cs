namespace Sharplist
{
    public interface IValidation
    {
        bool IsValidEmail(string enteredEmail);
        bool IgnoreWhiteSpace(char keyChar);
        bool IsValidPassword(string password);
        bool IsMatch(string password, string confirmPassword);
        bool IsValidInput(char keyChar);
    }
}
