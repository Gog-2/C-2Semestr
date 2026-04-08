using Exeption.Exeption;
using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption.Valedators
{
    internal class PriceValidation : IValidationServises
    {
        public void Validate(VisitorConfig cfg)
        {
            if (cfg.Price < 0)
            {
                throw new PriceExeception(cfg.Price);
            }
        }
    }
}
