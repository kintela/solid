using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Interfaces;
using System.Net.Mail;
using CommerceProject.Utility;
using CommerceProject.Model_DIP;

namespace CommerceProject.Services
{
    public class NotificationService : INotificationService
    {
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            string customerEmail = cart.CustomerEmail;
            if (!String.IsNullOrEmpty(customerEmail))
            {
                using (var message = new MailMessage("orders@somewhere.com", customerEmail))
                using (var client = new SmtpClient("localhost"))
                {
                    message.Subject = "Your order placed on " + DateTime.Now;
                    message.Body = "Your order details: \n " + cart;

                    try
                    {
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Problem sending notification email", ex);
                        throw;
                    }
                }
            }
        }
    }
}
