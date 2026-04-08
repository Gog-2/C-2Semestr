using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption.Exeption
{
    internal class PaymentExeption : Exception
    {
        public PaymentExeption(decimal Payment) : base($"No have money to pay. Given name: {Payment}"){}
    }
}
