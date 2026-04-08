using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exeption.Exeption;

namespace Exeption.Valedators
{
    internal class PaymentValidation : IValidationServises
    {
        public void Validate(VisitorConfig cfg)
        {
            if (cfg.Deposit < 0)
            {
                throw new PaymentExeption(cfg.Deposit);
            }
        }
    }
}
