using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sharplist
{
    public class Validation : IValidation
    {
        public bool IsValidEmail(string enteredEmail)
        {
            try
            {
                string email = Regex.Replace(enteredEmail, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(enteredEmail,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public bool IgnoreWhiteSpace(char keyChar)
        {
            return char.IsWhiteSpace(keyChar);
        }
        public bool IsValidPassword(string password)
        {
            return password.Length > 7 && password.Length < 17;
        }
        public bool IsMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
        public bool IsValidInput(char keyChar)
        {
            return char.IsControl(keyChar) || char.IsDigit(keyChar);
        }
    }
}
