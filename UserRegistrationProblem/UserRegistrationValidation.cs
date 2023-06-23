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
        private static string REGEX_MOBILENUMBER = "^[1-9]{1,3}[ ][1-9][0-9]{9}$";


        public bool ValidateMobileNumber(string mobNumber)
        {
            return Regex.IsMatch(mobNumber, REGEX_MOBILENUMBER);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid Mobile Number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
            }
        }
    }
}
