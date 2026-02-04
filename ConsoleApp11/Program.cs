using ConsoleApp11.encapsulation;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapsulation();
        }
        static private void Encapsulation()
        {
            BorderGuard guard = new BorderGuard();
            Visa visa = new Visa();
            Visa visa1 = new Visa();
            Visa visa2 = new Visa();

            visa.ShowInfo();
            Console.WriteLine(guard.CheckVisa(visa));
            visa1.ShowInfo();
            Console.WriteLine(guard.CheckVisa(visa1));
            visa2.ShowInfo();
            Console.WriteLine(guard.CheckVisa(visa2));
        }
    }
}
