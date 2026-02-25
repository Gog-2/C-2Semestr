using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ParticLesson3
{
    internal class Item
    {
        public double _damage;
        public double _attackSpeed;
        public float DPS => (float)(_damage * _attackSpeed);
        public Item(double damage, double attackSpeed)
        {
            _damage = damage;
            _attackSpeed = attackSpeed;
        }
        public virtual void GetDescription()
        {
            Console.WriteLine($"Урон: {_damage}");
            Console.WriteLine($"Скорость атаки: {_attackSpeed}");
        }
    }
}
