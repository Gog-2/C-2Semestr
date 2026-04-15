using Delegate.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Spectators
    {
        public Spectators(Arena arena)
        {
            arena.OnUnitDamaged += Damage;
            arena.OnUnitLoosed += Loosed;
        }

        private async Task Damage(UnitDamageArg e)
        {
            Console.WriteLine($"Зрители лекуют от удара {e.Attacker.Name} по {e.Target.Name} с силой {e.Damage}");
        }

        private async Task Loosed(Unit e)
        {
            Console.WriteLine($"Зрители огарчены смертью {e.Name}");
        }

    }
}
