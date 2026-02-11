using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson1
{
    internal class CargoShip : Spaceship, IStats
    {
        
        public override double CargoCapacity => 120;

        public double MaxAltitiude => 120;

        public string Name => "Грузовой";
    }
}
