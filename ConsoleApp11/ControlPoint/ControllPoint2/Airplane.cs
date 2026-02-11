using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint2
{
    internal class Airplane : Transport, IExtremeTransport
    {
        public Airplane(string name, double driverSkill, float Speed) : base(name, driverSkill, Speed)
        {
        }

        protected string Model => "Airplane";
        protected bool CanDoStunts => true;

        protected double RiskFactor => 0.5;

        bool IExtremeTransport.CanDoStunts => CanDoStunts;

        double IExtremeTransport.RiskFactor => RiskFactor;

        public void PerformStunt()
        {
            Console.WriteLine("The airplane performs an impressive aerial stunt, thrilling the spectators!");
        }

        public override void FuelConsumption()
        {
            Console.WriteLine($"The {Model} consumes fuel at a rate of {Speed * 0.5} liters per hour.");
        }

        public override void StartMoving()
        {
            Console.WriteLine($"The {Model} takes off into the sky!");
        }

        public override void TransportType()
        {
            Console.WriteLine($"This is an {Model}, designed for long-distance travel through the air.");
        }

        void IExtremeTransport.PerformStunt()
        {
            throw new NotImplementedException();
        }
    }
}
