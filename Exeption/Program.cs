namespace Exeption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistrationService registrationService = new RegistrationService();
            VisitorConfig visitorConfig = new VisitorConfig
            {
                Name = "John Doe",
                Age = 25,
                Section = "A",
                Price = 100,
                Deposit = 0
            };
            registrationService.Register(visitorConfig);
            visitorConfig.Deposit = 150;
            registrationService.Register(visitorConfig);
        }
    }
}
