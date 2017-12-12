using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Interfaces;
using CommerceProject.Model;

namespace CommerceProject.Fakes
{
    class FakePaymentProcessor:IPaymentProcessor
    {
        public decimal AmountPassed = 0;
        public bool WasCalled = false;
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            WasCalled = true;
            AmountPassed = amount;
        }
    }
}
