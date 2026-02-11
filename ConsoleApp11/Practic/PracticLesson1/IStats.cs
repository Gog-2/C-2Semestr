using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson1
{
    public interface IStats
    {
        public string Name { get;}
        public double MaxAltitiude { get;}
        public void TakeOff()
        {
            Console.WriteLine($"{Name} корабль приземлился");
        }
        public void Land()
        {
            Console.WriteLine($"{Name} корабль взлетел");
        }
    }
}
