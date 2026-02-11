using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp11.ControlPoint.ControllPoint2
{
    internal class SportsCar : Transport, IExtremeTransport
    {
        public SportsCar(string name, double driverSkill, float Speed) : base(name, driverSkill, Speed)
        {
        }

        protected string Model => "Sports Car";
        bool IExtremeTransport.CanDoStunts => true;

        public double RiskFactor => 0.4;
        public void PerformStunt()
        {
            Console.WriteLine("The sports car performs a thrilling stunt, leaving the crowd in awe!");
        }

        public override void MaxSpeed()
        {
            Console.WriteLine($"Max speed {Speed * DriverSkill * 1.5}");
        }

        public override void FuelConsumption()
        {
            Console.WriteLine($"The sports car consumes fuel at a rate of {Speed * 0.2} liters per hour.");
        }

        public override void StartMoving()
        {
            Console.WriteLine("The sports car roars to life and speeds off!");
        }

        public override void TransportType()
        {
            Console.WriteLine("This is a sports car, designed for speed and performance.");
        }
    }
}
