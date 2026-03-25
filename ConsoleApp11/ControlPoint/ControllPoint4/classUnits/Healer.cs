using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint4.classUnits
{
    internal class Healer : DoubleResistUint
    {
        public Healer(Unit unit, float physicResist, float maigcResist) : base(unit, physicResist, maigcResist){}
    }
}
