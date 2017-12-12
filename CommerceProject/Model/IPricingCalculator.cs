using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceProject.Model
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
