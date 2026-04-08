using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exeption.Exeption;

namespace Exeption.Valedators
{
    internal class AgeValidator : IValidationServises
    {
        public void Validate(VisitorConfig cfg)
        {
            if(cfg.Age < 0 || cfg.Age > 120)
            {
                throw new AgeException(cfg.Age);
            }
        }
    }
}
