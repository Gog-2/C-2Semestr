using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticTryCatch.Exeptions
{
    internal class MilitersMinus : Exception
    {
        public float Mililitrs { get; private set; }
        public MilitersMinus(float mililitrs) : base($"Mililitrs cannot be negative. Given value: {mililitrs}")
        {
            Mililitrs = mililitrs;
        }
    }
}
