using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ParticLesson3
{
    internal class Stone : Item
    {
        private string _name;
        public Stone(string name, double damage, double attackSpeed) : base(damage, attackSpeed)
        {
            _name = name;
        }
        public override void GetDescription()
        {
            Console.WriteLine($"Название камня: {_name}");
            base.GetDescription();
        }
    }
}
