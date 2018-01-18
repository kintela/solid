using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Model;

namespace CommerceProject.Interfaces
{
    public class SpecialPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * 4m;
            int setsOfThree = item.Quantity / 3;
            total -= setsOfThree * .2m;
            return total;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("SPECIAL");
        }
    }
}
