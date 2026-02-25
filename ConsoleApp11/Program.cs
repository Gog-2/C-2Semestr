using ConsoleApp11.ControlPoint.ControllPoint2;
using ConsoleApp11.ControlPoint.ControllPoint3.Hard;
using ConsoleApp11.ControlPoint.encapsulation;
using ConsoleApp11.ControlPoint.ParticLesson3;
using ConsoleApp11.Practic.PracticLesson0;
using ConsoleApp11.Practic.PracticLesson1;
using ConsoleApp11.Practic.PracticLesson2;
using System.Runtime.CompilerServices;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZadanieParticLesson3();
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
        static private void ZadanieCreature()
        {
            Ork _ork = new Ork(10, 2);
            Dragon _dragon = new Dragon(10, 2, 15);
            Goblin _goblin = new Goblin(10, 2);

            List<Creature> Creatures = new List<Creature>();
            Creatures.Add(_ork);
            Creatures.Add(_dragon);
            Creatures.Add(_goblin);
        }
        static private void ZadanieSpaceship()
        {
            Fighter fighter = new Fighter();
            Shuttle shuttle = new Shuttle();
            CargoShip cargoShip = new CargoShip();
            List<Spaceship> spaceships = new List<Spaceship>();
            spaceships.Add(fighter);
            spaceships.Add(shuttle);
            spaceships.Add(cargoShip);
            foreach (var spaceship in spaceships)
            {
                if (spaceship is IStats stats)
                {
                    Console.WriteLine($"Название корабля: {stats.Name}");
                    Console.WriteLine($"Макс. высота: {stats.MaxAltitiude}");
                    stats.TakeOff();
                    stats.Land();
                }
                Console.WriteLine($"Грузоподъемность: {spaceship.CargoCapacity}");
                spaceship.ActiveteEngine();
                spaceship.LaunchSequence();
                Console.WriteLine();
            }
        }
        static private void ZadanieTransport()
        {
            Taxi taxi = new Taxi("John", 1, 5);
            SportsCar sportsCar = new SportsCar("Alice", 0.4, 15);
            Airplane airplane = new Airplane("Bob", 1, 500);
            Console.WriteLine();
            List<Transport> transports = new List<Transport>();
            transports.Add(taxi);
            transports.Add(sportsCar);
            transports.Add(airplane);
            foreach (var transport in transports)
            {
                transport.MaxSpeed();
                transport.FuelConsumption();
                transport.TransportType();
                transport.StartMoving();
                Console.WriteLine();
            }
        }
        static private void ZadanieExtremeTransport()
        {
            CarStats carStats = new CarStats(200, 1250, 1);
            CarStats carStats1 = new CarStats(150, 900, 0.8f);
            Console.WriteLine(carStats + carStats1);
            Console.WriteLine(carStats - carStats1);
            Console.WriteLine(carStats * carStats1);
        }
        static private void ZadanieParticLesson3()
        {
            Stone stone = new Stone("Гранит", 10, 0.5);
            Stick stick = new Stick("Дуб", 5, 1);
            Stone stone2 = new Stone("Гранит", 10, 0.5);
            List<Item> items = new List<Item>();
            items.Add(stone);
            items.Add(stick);
            Workbench craft = new Workbench();
            Weapon weapon = craft.CreateWeapon(stone, stone2, stick);
            weapon.SetElement(new Ice(10, 1) + new Fire(10, 2));
            items.Add(weapon);

            foreach (var item in items)
            {
                if (item is Stone s)
                {
                    s.GetDescription();
                }
                else if (item is Stick st)
                {
                    st.GetDescription();
                }
                else if (item is Weapon w)
                {
                    w.GetDescription();
                }
                Console.WriteLine();
            }
        }
    }
}
        

