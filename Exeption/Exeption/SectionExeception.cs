using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption.Exeption
{
    internal class SectionExeception : Exception
    {
        public SectionExeception(string section) : base($"Section no exist. Given name: {section}"){ }
    }
}
