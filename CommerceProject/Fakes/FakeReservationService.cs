using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Interfaces;
using CommerceProject.Model;

namespace CommerceProject.Fakes
{
    public class FakeReservationService:IReservationService
    {
        public bool WasCalled = false;
        public void ReserveInventory(IEnumerable<OrderItem> items)
        {
            WasCalled = true;
        }

    }
}
