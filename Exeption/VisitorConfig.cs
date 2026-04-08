using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption
{
    internal struct VisitorConfig
    {
        public string Name;
        public int Age;
        public string Section;
        public int Price;
        public decimal Deposit;
        public void GetInfo()
        {
            Console.WriteLine($"Visitor Name: {Name}");
            Console.WriteLine($"Visitor Age: {Age}");
            Console.WriteLine($"Visitor Section: {Section}");
            Console.WriteLine($"Visitor Price: {Price}");
            Console.WriteLine($"Visitor Deposit: {Deposit}");
        }
    }
}
