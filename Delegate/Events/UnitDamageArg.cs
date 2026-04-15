using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Events
{
    internal class UnitDamageArg : EventArgs
    {
        public Unit Attacker { get; }
        public Unit Target { get; }
        public int Damage { get; }

        public UnitDamageArg(Unit attacker, Unit target, int damage)
        {
            Attacker = attacker;
            Target = target;
            Damage = damage;
        }
    }
}
