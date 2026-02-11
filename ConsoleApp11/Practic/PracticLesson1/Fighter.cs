using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson1
{
    internal class Fighter : Spaceship, IStats
    {
        public override double CargoCapacity => 50;
        public double MaxAltitiude => 200;
        public string Name => "Истребитель";
    }
}
