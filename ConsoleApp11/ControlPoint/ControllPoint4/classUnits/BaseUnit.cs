using ConsoleApp11.ControlPoint.ControllPoint4.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint4.classUnits
{
    internal class BaseUnit : Unit
    {
        public override void TakeDamage(Damage damage)
        {
            Hp -= (int)(damage.PhysicDamage + damage.MagicDamage + (damage.AbsoluteDamage ?? 0f));
            Console.WriteLine($"Took damage: {(int)(damage.PhysicDamage + damage.MagicDamage + (damage.AbsoluteDamage ?? 0f))}");
        }
    }
}
