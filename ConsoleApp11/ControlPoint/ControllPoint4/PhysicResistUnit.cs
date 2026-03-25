using ConsoleApp11.ControlPoint.ControllPoint4.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint4
{
    internal class PhysicResistUnit : Unit
    {
        private float _physicResist;
        public float PhysicResist { 
            get => _physicResist;
            set => _physicResist = (float)Math.Clamp(value, 0.1, 1);
        }
        public PhysicResistUnit(Unit unit,float physicResist)
        {
            Hp = unit.Hp;
            Damage = unit.Damage;
            PhysicResist = physicResist;
        }
        public override void TakeDamage(Damage damage)
        {
            Hp -= (int)(damage.PhysicDamage / PhysicResist);
            Console.WriteLine($"Physic Taked damage: {(int)(damage.PhysicDamage / PhysicResist)}");
            Hp -= (int)damage.MagicDamage;
            Console.WriteLine($"Magic Taked damage: {(int)damage.MagicDamage}");
            Hp -= (int)(damage.AbsoluteDamage ?? 0);
            Console.WriteLine($"AbsoluteDamage Taked damage: {(int)(damage.AbsoluteDamage ?? 0)}");
        }
    }
}
