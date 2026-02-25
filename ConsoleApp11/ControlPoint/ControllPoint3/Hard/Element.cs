using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint3.Hard
{
    internal abstract class Element
    {
        protected float _damage;
        public float Damage => _damage;
        protected float _damageRate;
        public float DamageRate => _damageRate;
        public Element(float damage, float damageRate)
        {
            _damage = damage;
            _damageRate = Math.Clamp(damageRate, 0, 1);
        }
    }
}
