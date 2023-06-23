namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationValidation validate = new UserRegistrationValidation();
            Console.WriteLine("Enter Mobile Number : ");
            string mobNumber = Console.ReadLine();
            bool mobNumberResult = validate.ValidateMobileNumber(mobNumber);
            validate.PrintResult(mobNumberResult);
        }
    }
    
}