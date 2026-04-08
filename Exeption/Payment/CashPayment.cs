using Exeption.Exeption;
using Exeption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption.Payment
{
    internal class CashPayment : IPaymentStrategy
    {
        public void Pay(decimal price, VisitorConfig cfg)
        {
            if (price < 0) throw new PriceExeception(price);
            if (cfg.Deposit < price) throw new PaymentExeption(cfg.Deposit);
                Console.WriteLine($"Payment of {price} was successful. Remaining deposit: {cfg.Deposit - price}");
            cfg.Deposit -= price;
        }
    }
}
