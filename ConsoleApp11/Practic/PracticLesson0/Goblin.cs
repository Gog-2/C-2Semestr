using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson0
{
    internal class Goblin : Creature
    {
        protected float _poisonDamage;

        public Goblin(float damage,float poisonDamage) : base(damage)
        {
            _poisonDamage = poisonDamage;
        }

        public override float TakeDamage()
        {
            return base.TakeDamage() + _poisonDamage;
        }
    }
}
