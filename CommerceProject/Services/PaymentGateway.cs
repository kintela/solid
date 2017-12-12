using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceProject.Services
{
    public class PaymentGateway : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string CardNumber { get; set; }
        public string Credentials { get; set; }

        public string ExpiresMonth { get; set; }

        public string ExpiresYear { get; set; }

        public string NameOnCard { get; set; }

        public decimal AmountToCharge { get; set; }

        public void Charge()
        {
            throw new AvsMismatchException();
        }

    }
    public class AvsMismatchException : Exception
    {
    }

}
