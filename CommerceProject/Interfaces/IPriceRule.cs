using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Model;


namespace CommerceProject.Interfaces
{
    public interface IPriceRule
    {
        bool IsMatch(OrderItem item);
        decimal CalculatePrice(OrderItem item);

    }
}
