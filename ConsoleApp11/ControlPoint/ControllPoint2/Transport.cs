using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint2
{
    internal abstract class Transport : Driver
    {
        protected Transport(string name, double driverSkill,float speed) : base(name, driverSkill)
        {
            Speed = speed;
        }
        protected string Model { get; }
        protected float Speed { get; }

        public virtual void MaxSpeed()
        {
            Console.WriteLine($"Max speed {Speed * DriverSkill}");
        }
        public abstract void FuelConsumption();
        public abstract void TransportType();
        public abstract void StartMoving();
    }
}
