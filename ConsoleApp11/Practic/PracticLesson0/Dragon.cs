using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson0
{
    internal class Dragon : Creature
    {
        protected float _damageArea;
        protected float _fireDamage;

        public Dragon(float damage, float damageArea,float fireDamage) : base(damage)
        {
            _damageArea = damageArea;
            _fireDamage = fireDamage;
        }

        public override float TakeDamage()
        {
            return base.TakeDamage() / _damageArea + _fireDamage;
        }
    }
}
