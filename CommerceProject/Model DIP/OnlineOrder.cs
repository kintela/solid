using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Interfaces;
using CommerceProject.Model;

namespace CommerceProject.Model_DIP
{
    public class OnlineOrder:Order
    {
        private readonly Interfaces.INotificationService _notificationService;
        private readonly PaymentDetails _paymentDetails;
        private readonly Interfaces.IPaymentProcessor _paymentProcessor;
        private readonly Interfaces.IReservationService _reservationService;

        public OnlineOrder(Cart cart,
                           PaymentDetails paymentDetails,
                           Interfaces.IPaymentProcessor paymentProcessor,
                           Interfaces.IReservationService reservationService,
                           Interfaces.INotificationService notificationService)
            : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = paymentProcessor;
            _reservationService = reservationService;
            _notificationService = notificationService;
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount);

            _reservationService.ReserveInventory(_cart.Items);

            _notificationService.NotifyCustomerOrderCreated(_cart);

            base.Checkout();
        }
    }
}
