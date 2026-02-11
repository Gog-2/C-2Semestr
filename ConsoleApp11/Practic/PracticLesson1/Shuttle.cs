using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson1
{
    internal class Shuttle : Spaceship, IStats
    {
        public override double CargoCapacity => 50;
        public double MaxAltitiude => 150;
        public string Name => "Шаттл";
    }
}
