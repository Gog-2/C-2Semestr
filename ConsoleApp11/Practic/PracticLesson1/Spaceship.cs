using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson1
{
    internal abstract class Spaceship
    {
        public abstract double CargoCapacity { get; }
        public virtual void ActiveteEngine()
        {
                Console.WriteLine("Двигатель запущен");
        }
        public virtual void LaunchSequence()
        {
                Console.WriteLine("Запуск корабля");
        }

    }
}
