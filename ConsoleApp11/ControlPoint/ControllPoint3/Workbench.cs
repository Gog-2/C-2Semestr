using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ParticLesson3
{
    internal class Workbench
    {
        public Weapon CreateWeapon<T1, T2, T3>(T1 a, T2 b, T3 c) where T1 : Item where T2 : Item where T3 : Item
        {
            if (a is Stone && b is Stone && c is Stone)
            {
                return new Spear("Stone Spear", (a._damage + b._damage + c._damage) * 1.2, (b._attackSpeed + c._attackSpeed) / 2);
            }
            else if (a is Stone && b is Stone && c is Stick)
            {
                return new Axe("Stone Axe", (a._damage + b._damage + c._damage) * 1.5, (a._attackSpeed + b._attackSpeed + c._attackSpeed) / 3);
            }
            return null;
        }
    }
}
