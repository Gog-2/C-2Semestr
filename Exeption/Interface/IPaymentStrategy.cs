using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption.Interface
{
    internal interface IPaymentStrategy
    {
        public void Pay(decimal price,VisitorConfig cfg);
    }
}
