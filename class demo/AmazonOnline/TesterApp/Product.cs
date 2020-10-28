namespace Catalog
{
   public class Product
    {
        //readonly property
        public int ID { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }

        public Product() { }
        public Product(int id, string title, string description, int quantity, float unitPrice)
        {
            this.ID = id;
            this.Title = title;
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
        }
        ~Product()
        {
           // to DeInitialize object instance before getting destroyed.
        }


        //Object
        //object

        public override string ToString()
        {
            //return base.ToString();

            return this.ID + " " + this.Title + " " + this.Description + " " + this.UnitPrice + " " + this.Quantity;
        }
    }
}
