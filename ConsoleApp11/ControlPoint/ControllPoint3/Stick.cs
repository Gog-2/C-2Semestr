using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ParticLesson3
{
    internal class Stick : Item
    {
        private string _name;
        public Stick(string name, double damage, double attackSpeed) : base(damage, attackSpeed)
        {
            _name = name;
        }
        public override void GetDescription()
        {
            Console.WriteLine($"Название палки: {_name}");
            base.GetDescription();
        }
    }
}
