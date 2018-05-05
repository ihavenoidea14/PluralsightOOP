using System;
using System.Collections.Generic;
namespace ACM.BL
{
    public class Order
    {
        public Order() { }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            return !OrderDate.Equals(null);
        }

    }
}
