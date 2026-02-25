using ConsoleApp11.ControlPoint.ControllPoint3.Hard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ParticLesson3
{
    internal class Weapon : Item
    {
        private string _name;
        private Element _element;
        
        public void SetElement(Element element)
        {
            _element = element;
        }
        public Weapon(string name, double damage, double attackSpeed) : base(damage, attackSpeed)
        {
            _name = name;
        }
        public override void GetDescription()
        {
            Console.WriteLine($"Название оружия: {_name}");
            Console.WriteLine($"Элемент оружия: {_element.GetType()}");
            base.GetDescription();
        }
    }
}
