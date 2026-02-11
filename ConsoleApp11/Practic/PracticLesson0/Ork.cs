using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson0
{
    internal class Ork : Creature
    {
        protected float _critRate;

        public Ork(float damage,float critRate) : base(damage)
        {
            _critRate = critRate;
        }

        public override float TakeDamage()
        {
            return base.TakeDamage() * _critRate;
        }
    }
}
