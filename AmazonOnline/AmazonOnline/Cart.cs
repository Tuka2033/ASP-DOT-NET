using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnline
{
    class Cart
    {
        private List<Item> item;
        private int i = 0;
        public Cart() {
            item = new List<Item>();
        }

       // internal Item[] Item { get => item; set => item = value; }

        public void AddtoCart(Item item)
        {
          // item.Add(item);
        }
        public void RemoveFromCart(Item item)
        {
            if (i > 0)
            {
                this.item[i] = item;
                i--;
            }
        }
        
    }

   
}
