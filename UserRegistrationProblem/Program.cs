﻿namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationValidation validate = new UserRegistrationValidation();
            //Console.WriteLine("Enter First Name : ");
            //string firstName = Console.ReadLine();
            //bool fNameResult = validate.ValidateFirstName(firstName);
            //validate.PrintResult(fNameResult);
            //Console.WriteLine("Enter Last Name : ");
            //string lastName = Console.ReadLine();
            //bool lNameResult = validate.ValidateLastName(lastName);
            //validate.PrintResult(lNameResult);
            Console.WriteLine("Enter Email Id : ");
            string email = Console.ReadLine();
            bool emailResult = validate.ValidateEmail(email);
            validate.PrintResult(emailResult);
        }
    }
    
}