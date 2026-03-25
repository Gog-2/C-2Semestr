using ConsoleApp11.ControlPoint.ControllPoint4.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint4
{
    internal class MagicResistUnit : Unit
    {
        private float _maigcResist;
        public float MagicResist
        {
            get => _maigcResist;
            set => _maigcResist = (float)Math.Clamp(value, 0.1, 1);
        }
        public MagicResistUnit(Unit unit, float maigcResist)
        {
            Hp = unit.Hp;
            Damage = unit.Damage;
            MagicResist = maigcResist;
        }
        public override void TakeDamage(Damage damage)
        {
            Hp -= (int)damage.PhysicDamage;
            Console.WriteLine($"Physic Taked damage: {(int)damage.PhysicDamage}");
            Hp -= (int)(damage.MagicDamage / MagicResist);
            Console.WriteLine($"Magic Taked damage: {(int)(damage.MagicDamage / MagicResist)}");
            Hp -= (int)(damage.AbsoluteDamage ?? 0);
            Console.WriteLine($"AbsoluteDamage Taked damage: {(int)(damage.AbsoluteDamage ?? 0)}");
        }
    }
}
