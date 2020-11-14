using System;

namespace Replacement_Method
{
    public class CustomerAccount
    {
        private decimal balance = 0;

        public bool WithdrawFunds(decimal amount)
        {
            Console.WriteLine("Base Class WithdrawlFunds Method");
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }

    public class BabyAccount : CustomerAccount
    {
        public new bool WithdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }

            return base.WithdrawFunds(amount);
        }
    }

    class Bank
    {
        static void Main(string[] args)
        {
            BabyAccount b = new BabyAccount();
            b.PayInFunds(90000);
            Console.WriteLine(b.GetBalance());
            Console.WriteLine(b.WithdrawFunds(9));
        }
    }
}
