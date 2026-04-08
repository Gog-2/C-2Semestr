using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption.Exeption
{
    internal class NameExeception : Exception
    {
        public NameExeception(string name) : base($"Name cannot be empty. Given name: {name}") {}
    }
}
