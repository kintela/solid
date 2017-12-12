using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Model;

namespace CommerceProject.Model_DIP
{
    public class Cart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }

        public Cart()
        {
            this.Items = new List<OrderItem>();
        }
    }
}
