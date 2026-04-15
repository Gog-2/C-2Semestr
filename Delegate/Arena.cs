using Delegate.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Arena
    {
        public event Func<UnitDamageArg,Task> OnUnitDamaged;
        public event Func<Unit, Task> OnUnitLoosed;
        public event Func<string, Task> OnConsoleMessaged;
        public async void RaiseUnitDamaged(Unit attacker, Unit target, int damage)
        {
            var args = new UnitDamageArg(attacker, target, damage);

            var msg = $"[Арена] {attacker.Name} атакует {target.Name} на {damage} урона. " +
                      $"HP {target.Name}: {target.HP}/{target.MaxHP}";
            Task task1 = OnConsoleMessaged?.Invoke(msg) ?? Task.CompletedTask;
            Task task2 = OnUnitDamaged?.Invoke(args) ?? Task.CompletedTask;
            await Task.WhenAll(task1,task2);
        }

        public async Task RaiseUnitLoosed(Unit loser)
        {
            OnUnitLoosed?.Invoke(loser);

            var msg = $"[Арена] {loser.Name} повержен!";
            Task task1 = OnUnitLoosed?.Invoke(loser) ?? Task.CompletedTask;
            Task task2 = OnConsoleMessaged?.Invoke(msg) ?? Task.CompletedTask;
            await Task.WhenAll(task1,task2);
        }
    }
}
