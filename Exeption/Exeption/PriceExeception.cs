using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption.Exeption
{
    internal class PriceExeception : Exception
    {
        public PriceExeception(decimal price) : base($"Price cannot be negative. Given name: {price}") { }
    }
}
