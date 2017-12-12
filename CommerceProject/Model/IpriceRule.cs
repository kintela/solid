using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceProject.Model
{
    public interface IPriceRule
    {
        bool IsMatch(OrderItem item);
        decimal CalculatePrice(OrderItem item);
    }
}
