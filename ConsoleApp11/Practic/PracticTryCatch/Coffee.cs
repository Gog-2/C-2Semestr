using ConsoleApp11.Practic.PracticTryCatch.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticTryCatch
{
    internal struct Coffee
    {
        public readonly float Mililitrs;
        public readonly string Names;
        public readonly string Descriptions;
        public readonly decimal Price;
        public Coffee(float Mililters, string Name, string Description, decimal PriceOf)
        {
            if (Mililters < 0)
                throw new MilitersMinus((float)Mililters);
            Mililitrs = Mililters;
            Names = Name;
            Descriptions = Description;
            if (Price < 0)
                throw new ImposiblePrice(Price);
            Price = PriceOf;
        }
    }
}
