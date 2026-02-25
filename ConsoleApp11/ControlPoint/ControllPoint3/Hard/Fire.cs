using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint3.Hard
{
    internal class Fire : Element
    {
        public Fire(float damage, float damageRate) : base(damage, damageRate)
        {
        }
        public static Element operator +(Fire fire, Ice ice)
        {
            Steam steam = new Steam(ice.Damage + fire.Damage, ice.DamageRate + fire.DamageRate);
            return steam;
        }
    }
}
