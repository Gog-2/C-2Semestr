using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption.Exeption
{
    internal class AgeException : Exception
    {
        public AgeException(int age) : base($"Age cannot be negative. Given name: {age}"){}
    }
}
