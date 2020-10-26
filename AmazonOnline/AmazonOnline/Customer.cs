using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnline
{
    class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private int contactNumber;

        public int Id { get => id; }
        public string Firstname { get => firstName; set => firstName = value; }
        public string Lastname { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int ContactNumber { get => contactNumber; set => contactNumber = value; }
        
        public Customer() { }
        public Customer(int id,string firstName, string lastName,string email,int contactNumber)
        {
            this.id = id;
            this.Firstname = firstName;
            this.Lastname = lastName;
            this.Email = email;
            this.ContactNumber = contactNumber;
        }
        public override string ToString()
        {
            return this.Id + " " + this.Firstname + " " + this.Lastname + " " +this.Email + " " + this.ContactNumber;
        }
    }
}
