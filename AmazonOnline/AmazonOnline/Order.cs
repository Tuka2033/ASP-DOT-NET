using CRM;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
   public class Order
    {
        private List<Item> items = new List<Item>();
        private Customer Customer;

        public List<Item> Items
        {
            get
            {
                return items;
            }
        }

        public Order(List<Item> items, int orderId, DateTime orderDate1, Customer customer)
        {
            this.items = items;
            OrderId = orderId;
            OrderDate1 = orderDate1;
            Customer = customer;
        }

        public Customer Cust
        {
            get { return Customer; }
            set { Customer = value; }
        }
        public int OrderId { get; set; }
        public DateTime OrderDate1 { get; set; }

        public override string ToString()
        {
            return this.OrderId + " " + this.OrderDate1 + " " + this.Customer ;
        }
    }

}
