using ConsoleApp11.ControlPoint.ControllPoint4.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint4
{
    internal class DoubleResistUint : Unit
    {
        private float _maigcResist;
        public float MagicResist
        {
            get => _maigcResist;
            set => _maigcResist = (float)Math.Clamp(value, 0.1, 1);
        }
        private float _physicResist;
        public float PhysicResist
        {
            get => _physicResist;
            set => _physicResist = (float)Math.Clamp(value, 0.1, 1);
        }
        public DoubleResistUint(Unit unit, float physicResist, float maigcResist)
        {
            Hp = unit.Hp;
            Damage = unit.Damage;
            PhysicResist = physicResist;
            MagicResist = maigcResist;
        }
        public DoubleResistUint(PhysicResistUnit physicResistUnit, float maigcResist)
        {
            Hp = physicResistUnit.Hp;
            Damage = physicResistUnit.Damage;
            PhysicResist = physicResistUnit.PhysicResist;
            MagicResist = maigcResist;
        }
        public DoubleResistUint(MagicResistUnit magicResistUnit, float physicResist)
        {
            Hp = magicResistUnit.Hp;
            Damage = magicResistUnit.Damage;
            PhysicResist = physicResist;
            MagicResist = magicResistUnit.MagicResist;
        }
        public override void TakeDamage(Damage damage)
        {
            Hp -= (int)(damage.PhysicDamage / PhysicResist);
            Console.WriteLine($"Physic Taked damage: {(int)(damage.PhysicDamage / PhysicResist)}");
            Hp -= (int)(damage.MagicDamage / MagicResist);
            Console.WriteLine($"Magic Taked damage: {(int)(damage.MagicDamage / MagicResist)}");
            Hp -= (int)(damage.AbsoluteDamage ?? 0);
            Console.WriteLine($"AbsoluteDamage Taked damage: {(int)(damage.AbsoluteDamage ?? 0)}");
        }
    }
}
