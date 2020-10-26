using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnline
{
    class Account
    {
        private float balance;

        public float Balance { get => balance; set => balance = value; }

        public Account() {
            this.Balance = 000;
        }
       public float Withdraw(float amount) {
            this.Balance = this.balance - amount;
            return amount;
        }
        public int Deposit(float amount)
        {
            this.Balance = this.balance + amount;
            return 1;
        }
        public float Display()
        {
            return this.Balance;
        }
    }
}
