using Exeption.Exeption;
using Exeption.Interface;
using Exeption.Payment;
using Exeption.Valedators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exeption
{
    internal class RegistrationService
    {
        private IPaymentStrategy _paymentStrategy;
        private IValidationServises[] _validationServises = new IValidationServises[5];
        private VisitorConfig _visitorConfig;

        public RegistrationService()
        {
            _validationServises[0] = new AgeValidator();
            _validationServises[1] = new NameValidator();
            _validationServises[2] = new PaymentValidation();
            _validationServises[3] = new PriceValidation();
            _validationServises[4] = new SectionValidation();
            _paymentStrategy = new CashPayment();
        }
        public void GetInfo()
        {
            _visitorConfig.GetInfo();
        }
        public void Deposit(decimal amount)
        {
            _visitorConfig.Deposit += amount;
        }
        public void Register(VisitorConfig cfg)
        {
            try
            {
                foreach (var validator in _validationServises)
                {
                    validator.Validate(cfg);
                }
                _paymentStrategy.Pay(cfg.Price, cfg);
                Console.WriteLine("Registration successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Registration failed: {ex.Message}");

            }
        }
    }
}
