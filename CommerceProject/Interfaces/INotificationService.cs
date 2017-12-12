using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Model_DIP;

namespace CommerceProject.Interfaces
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }
}
