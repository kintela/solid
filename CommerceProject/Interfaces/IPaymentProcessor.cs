using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Model;

namespace CommerceProject.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }
}
