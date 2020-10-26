using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnline
{
    class Item
    {
        private int id;
        private string product;
        private float quantity;

        public string Product { get => product; set => product = value; }
        public float Quantity { get => quantity; set => quantity = value; }
        public int Id { get => id; }
        public Item() { }
        public Item( int id, string product,float quantity)
        {
            this.id = id;
            this.Product = product;
            this.Quantity = quantity;
        }
        public override string ToString()
        {
            return this.Id + " " + this.Product + " " + this.Quantity;
        }
    }
}
