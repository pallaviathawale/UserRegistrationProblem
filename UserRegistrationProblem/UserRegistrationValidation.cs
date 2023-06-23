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
        // private static string REGEX_PASSWORD = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$"; //regex for password Rule1-At least 8 character
        //  private static string REGEX_PASSWORD = "^(?=.*[A-Z])[A-Za-z0-9!@#$%^&*]{8,}$"; //regex for password Rule2- should contains at least one uppar case
        //private static string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9-+_!@#$%^&*.,?]{8,}$"; //passwordRule3-Should contain At least one numeric character
        private static string REGEX_PASSWORD = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&*+-.]*[!@#$%&*+-.][^!@#$%&*+-.]*$)[\\S]{8,}$"; //passwordRule4-Exact one special Character

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
