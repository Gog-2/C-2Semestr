using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint3.Hard
{
    internal class Ice : Element
    {
        public Ice(float damage, float damageRate) : base(damage, damageRate)
        {

        }

        public static Element operator +(Ice ice, Fire fire)
        {
            Steam steam = new Steam(ice.Damage + fire.Damage, ice.DamageRate + fire.DamageRate);
            return steam;
        }
    }
}
