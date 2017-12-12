using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Interfaces;

namespace CommerceProject.Model_DIP
{
    public abstract class Order
    {
        protected readonly Cart _cart;

        protected Order(Cart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {
            // log the order in the database
        }
    }
}
