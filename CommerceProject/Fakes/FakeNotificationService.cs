using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Interfaces;
using CommerceProject.Model_DIP;

namespace CommerceProject.Fakes
{
    public class FakeNotificationService:INotificationService
    {
        public bool WasCalled = false;
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            WasCalled = true;
        }

    }
}
