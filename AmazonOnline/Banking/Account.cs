
namespace Banking
{
    class Account
    {
        public float Balance { get; set; }

        public Account() {
            this.Balance = 000;
        }
       public float Withdraw(float amount) {
            this.Balance = this.Balance - amount;
            return amount;
        }
        public void Deposit(float amount)
        {
            this.Balance = this.Balance + amount;
        }
        public float Display()
        {
            return this.Balance;
        }
        public override string ToString()
        {
            return this.Balance.ToString();
        }
    }
}
