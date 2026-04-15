using System.Diagnostics;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Start();
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds}");
        }
        static private void Start()
        {
            var arena = new Arena();

            var spectators = new Spectators(arena);
            var chat = new GameConsoleChat(arena);

            var warrior = new Unit("Воин", 100, 25, arena);
            var mage = new Unit("Маг", 70, 35, arena);

            Console.WriteLine("Начало войны");

            int round = 1;
            while (warrior.IsAlive && mage.IsAlive)
            {
                Console.WriteLine($"--- Раунд {round++} ---");

                warrior.Attack(mage);

                if (mage.IsAlive)
                    mage.Attack(warrior);
                Console.WriteLine();
            }
            string winner = warrior.IsAlive ? warrior.Name : mage.Name;
            Console.WriteLine($"Выйграл: {winner}!");
        }
    }
}
