using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommerceProject.Fakes;
using CommerceProject.Model_DIP;
using CommerceProject.Model;

namespace CommerceTest
{
    [TestClass]
    public class OnlineOrderCheckoutShould
    {
        [TestMethod]
        public void SendTotalAmountToCreditCardProcessor()
        {
            var paymentProcessor = new FakePaymentProcessor();
            var reservationService = new FakeReservationService();
            var notificationService = new FakeNotificationService();
            var cart = new CommerceProject.Model_DIP.Cart { TotalAmount = 5.05m };
            var paymentDetails = new PaymentDetails()
            { PaymentMethod = PaymentMethod.CreditCard };
            var order = new CommerceProject.Model_DIP.OnlineOrder(cart,
                                        paymentDetails,
                                        paymentProcessor,
                                        reservationService,
                                        notificationService);

            order.Checkout();

            Assert.IsTrue(paymentProcessor.WasCalled);
            Assert.AreEqual(cart.TotalAmount, paymentProcessor.AmountPassed);

        }
    }
}
