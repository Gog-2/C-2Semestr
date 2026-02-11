using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint2
{
    internal class Taxi : Transport
    {
        public Taxi(string name, double driverSkill, float Speed) : base(name, driverSkill, Speed)
        {
        }

        protected string Model => "Taxi";
        public override void FuelConsumption()
        {
           Console.WriteLine($"The  {Model}  consumes fuel at a rate of f {Speed * 0.15} liters per hour.");
        }

        public override void StartMoving()
        {
            Console.WriteLine($"The {Model} starts moving, ready to pick up passengers.");
        }

        public override void TransportType()
        {
            Console.WriteLine($"This is a {Model}, designed for transporting passengers in urban areas.");
        }
    }
}
