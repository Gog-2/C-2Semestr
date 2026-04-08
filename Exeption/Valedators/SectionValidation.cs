using Exeption.Exeption;
using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption.Valedators
{
    internal class SectionValidation : IValidationServises
    {
        public void Validate(VisitorConfig cfg)
        {
            if(string.IsNullOrWhiteSpace(cfg.Section))
            {
                throw new SectionExeception(cfg.Section);
            }
        }
    }
}
