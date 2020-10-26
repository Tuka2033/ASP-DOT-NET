using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnline
{
    class Product
    {
        private int id;
        private string title;
        private string description;
        private float unitPrice;
        private float quantity;

        public int Id { get => id; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public float Quantity { get => quantity; set => quantity = value; }
        public Product() { }
        public Product(int id,string title,string description, float unitPrice,float quantity)
        {
            this.id = id;
            this.Title = title;
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;

        }
        public override string ToString()
        {
            return this.Id + " " + this.Title + " " + this.Description + " " + this.UnitPrice + " " + this.Quantity;
        }

    }
}
