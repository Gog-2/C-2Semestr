using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Unit
    {
        public string Name { get; }
        public int MaxHP { get; }
        public int HP { get; private set; }
        public int Damage { get; }
        public bool IsAlive => HP > 0;

        private readonly Arena _arena;

        public Unit(string name, int hp, int damage, Arena arena)
        {
            Name = name;
            MaxHP = hp;
            HP = hp;
            Damage = damage;
            _arena = arena;
        }
        public void Attack(Unit target)
        {
            if (!IsAlive || !target.IsAlive) return;

            target.TakeDamage(this, Damage);
        }

        public void TakeDamage(Unit attacker, int damage)
        {
            int actual = Math.Max(0, damage);
            HP = Math.Max(0, HP - actual);

            _arena.RaiseUnitDamaged(attacker, this, actual);

            if (!IsAlive)
                _arena.RaiseUnitLoosed(this);
        }
    }
}
