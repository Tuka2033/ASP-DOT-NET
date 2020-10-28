
using System.Collections.Generic;
using OrderProcessing;
namespace Membership
{
   public class OrderManager
    {
       private List<Order> listOforders = new List<Order>();

      
        public void insert(Order order)
        {
            listOforders.Add(order);
        }
        public void Delete(Order order)
        {
            listOforders.Remove(order);
        }
        public void Update(Order order, int id)
        {
            foreach(Order list in listOforders)
            {
                if (list.OrderId == id)
                {
                    listOforders.Insert(id,order);
                }

            }
        }

        public List<Order> getAll()
        {

            return this.listOforders;
        }

        public List<Order> GetById(int id)
        {
            List<Order> o= new List<Order>();
            foreach (Order list in listOforders)
            {
                if (list.OrderId == id)
                {
                    o.Add(list);
                }

            }
            return o;
        }
        public List<Order> GetByCustId(int Custid)
        {
            List<Order> o = new List<Order>();
            foreach (Order list in listOforders)
            {
                if (list.Cust.Id == Custid)
                {
                    o.Add(list);
                }

            }
            return o;
        }
    }
}
