using ConsoleApp11.ControlPoint.ControllPoint4.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint4
{
    internal abstract class Unit
    {
        private int _hp;
        private Damage _damage;
        public int Hp
        {
            get { return _hp; }
            set
            {
                _hp = value;
            }
        }
        public Damage Damage
        {
            get { return _damage; }
            set
            {
                _damage = value;
            }
        }
        public abstract void TakeDamage(Damage damage);
        public virtual void Attack(Unit target)
        {
            target.TakeDamage(this.Damage);
            Console.WriteLine($"{this.GetType().Name} attacks {target.GetType().Name} for {Damage.PhysicDamage} physical damage and {Damage.MagicDamage} magic damage. \n ");
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"{this.GetType().Name}  HP: {Hp}, Damage Magic: {Damage.MagicDamage}, Damage Physics: {Damage.PhysicDamage}, Absolute Damage: {Damage.AbsoluteDamage ?? 0}");
        }
    }
}
