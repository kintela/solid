﻿using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Model;

namespace CommerceProject.Interfaces
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}
