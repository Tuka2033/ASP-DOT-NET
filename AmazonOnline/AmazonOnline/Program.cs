using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Rose", "Valentine Flower", 20, 2000);
            Product product2 = new Product(1, "Gerbera", "Wedding Flower", 30, 3000);
            Product product3 = new Product(1, "Jasmin", "Smelling Flower", 50, 5000);
            Product product4 = new Product(1, "Sunflowers", " Flower", 10, 4000);


            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine(product3);
            Console.WriteLine(product4);



            Customer customer1 = new Customer(1, "Tukaram", "Pandhare", "patil2033.tp@gmail.com", 12345);

            Console.WriteLine(customer1);

            Account account = new Account();
            account.Deposit(5000);
            account.Withdraw(500);
            Console.WriteLine("Total Balance {0} :", account.Display());


            if(AccountManager.Login("Tuka", "Tuka"))
            {
                Console.WriteLine("Login Successful.....");
            }
            else
            {
                Console.WriteLine("Login Failed.....");
            }
            Console.WriteLine("Register........\n");
            Console.WriteLine("Enter ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string email= Console.ReadLine();
            Console.WriteLine("Enter Mob No.:");
            int mob = int.Parse(Console.ReadLine());

            AccountManager.Register(id, fname, lname, email, mob);

            Item item = new Item(1, "Rose", 200);
            Console.WriteLine(item);

        }
        
    }
}
