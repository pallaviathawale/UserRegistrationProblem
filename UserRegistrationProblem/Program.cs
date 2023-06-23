namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationValidation validate = new UserRegistrationValidation();
             Console.WriteLine("Checking for sample mails : ");
            foreach (string mail in validate.GetList())
            {
                Console.Write(mail + " : ");
                validate.PrintResult(validate.ValidateEmail(mail));
            }
        }
    }
    
    
}