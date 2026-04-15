using Delegate.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class GameConsoleChat
    {
        public GameConsoleChat(Arena arena)
        {
            arena.OnUnitDamaged += OnDamaged;
            arena.OnUnitLoosed += OnLoosed;
            arena.OnConsoleMessaged += OnMessage;
        }

        private async Task OnDamaged( UnitDamageArg e)
        {
            Console.WriteLine($"Аттака: {e.Attacker.Name} нанёс {e.Damage} урона юниту {e.Target.Name}. " +
                              $"Публика {(e.Damage >= 20 ? "в восторге" : "довольна")}!");
        }

        private async Task OnLoosed(Unit e)
        {
            Console.WriteLine($"{e.Name} умер на арене");
        }

        private async Task OnMessage(string e)
        {
            Console.WriteLine($"Собщение: {e}");
        }
    }
}
