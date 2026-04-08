using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticTryCatch.Exeptions
{
    internal class ImposiblePrice : Exception
    {
        public decimal Price { get; private set; }
        public ImposiblePrice(decimal price) : base($"Price cannot be negative. Given value: {price}")
        {
            Price = price;
        }
    }
}
