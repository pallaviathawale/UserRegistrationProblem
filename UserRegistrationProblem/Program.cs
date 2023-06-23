namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem");
            UserRegistrationValidation validate = new UserRegistrationValidation();
            Console.WriteLine("Enter Last Name : ");
            string lastName = Console.ReadLine();
            bool lNameResult = validate.ValidateLastName(lastName);
            validate.PrintResult(lNameResult);
        }
    }
}