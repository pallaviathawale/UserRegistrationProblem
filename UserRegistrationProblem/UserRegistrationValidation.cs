using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserRegistrationValidation
    {
        private static string REGEX_PASSWORD = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$"; //regex for password Rule1-At least 8 character


        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
