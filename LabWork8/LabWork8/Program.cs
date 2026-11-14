namespace LabWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordInSystem = "qwerty123";
            string inputPassword = Console.ReadLine();
            PasswordIsCorrect(passwordInSystem, inputPassword);
        }

        static void PasswordIsCorrect(string passwordInSystem, string inputPassword)
        {
            if (passwordInSystem == inputPassword) Console.WriteLine("ACCESS_GRANTED");
            else Console.WriteLine("ACCESS_DENIED");
        }
    }

    public class Class
    {
        private string _name;
        public void Method() => Console.WriteLine(_name);
    }
}
