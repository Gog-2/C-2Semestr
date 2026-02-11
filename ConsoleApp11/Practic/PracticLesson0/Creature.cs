using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson0
{
    internal abstract class Creature
    {
        public Creature(float damage) 
        {
            _damage = damage;
        }
        protected float _damage;
        public virtual float TakeDamage()
        {
            return _damage;
        }

    }
}
