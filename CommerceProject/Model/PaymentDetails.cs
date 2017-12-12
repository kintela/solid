﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceProject.Model
{
    public enum PaymentMethod
    {
        Cash,
        CreditCard
    }
    public class PaymentDetails
    {
        public PaymentMethod PaymentMethod { get; set; }

        public string CreditCardNumber { get; set; }

        public string ExpiresMonth { get; set; }

        public string ExpiresYear { get; set; }

        public string CardHolderName { get; set; }
    }
}
