using System;

namespace Interface
{

    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }

    public class CustomerAccount : IAccount
    {
        private decimal balance = 0;

        public bool WithdrawFunds(decimal amount)
        {
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

    class Bank
    {
        static void Main(string[] args)
        {
            CustomerAccount shubhamsAccount = new CustomerAccount();
            shubhamsAccount.PayInFunds(40000);
            Console.WriteLine(shubhamsAccount.GetBalance());
        }
    }
}
