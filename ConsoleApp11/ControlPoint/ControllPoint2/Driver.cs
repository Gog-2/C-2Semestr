using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint2
{
    internal abstract class Driver
    {
        public Driver(string name, double driverSkill)
        {
            Name = name;
            DriverSkill = driverSkill;
        }
        public string Name { get; }
        protected double DriverSkill { get; }
    }
}
