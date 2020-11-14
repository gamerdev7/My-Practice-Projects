namespace DeadLock
{
    class Account
    {
        double balance;
        int id;

        public Account(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public int ID
        {
            get { return id; }
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
    }
}
