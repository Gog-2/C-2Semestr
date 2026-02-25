using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint3.Hard
{
    internal class Steam : Element
    {
        public Steam(float damage, float damageRate) : base(damage, damageRate)
        {
            damage *= 1.2f;
        }
    }
}
