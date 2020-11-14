using System;
using System.Threading;

namespace DeadLock
{
    class AccountManager
    {
        Account fromAccount, toAccount;
        double amountToTransfer;

        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this.fromAccount = fromAccount;
            this.toAccount = toAccount;
            this.amountToTransfer = amountToTransfer;
        }

        public void Transfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {fromAccount.ID.ToString()}");
            lock (fromAccount)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {fromAccount.ID.ToString()}");
                Console.WriteLine($"{Thread.CurrentThread.Name} suspended for 1 second.");
                Thread.Sleep(1000);
                lock (toAccount)
                {
                    fromAccount.Withdraw(amountToTransfer);
                    toAccount.Deposit(amountToTransfer);
                }
            }
        }
    }
}
