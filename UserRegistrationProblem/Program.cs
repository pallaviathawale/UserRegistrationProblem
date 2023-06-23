namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationValidation validate = new UserRegistrationValidation();
            Console.WriteLine("Enter Password : ");
            string password = Console.ReadLine();
            bool passwordResult = validate.ValidatePassword(password);
            validate.PrintResult(passwordResult);
        }
    }
    
    
}