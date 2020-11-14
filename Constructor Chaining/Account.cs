using System;

namespace Constructor_Chaining
{
    class Account
    {
        private string name, address;
        private decimal balance;
        public Account(string inName, string inAddress, decimal inBalance)
        {
            name = inName;
            address = inAddress;
            balance = inBalance;
            Console.WriteLine("Account(string inName, string inAddress, decimal inBalance) Constructor called.");
        }

        //public Account(string inName, string inAddress)
        //    : this(inName, inAddress, 0)
        //{
        //    Console.WriteLine("Account(string inName, string inAddress) Constructor called.");
        //}

        public Account()
        {
            Console.WriteLine("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
        }
        public Account(string inName)
        //: this(inName, "Not Supplied")
        {
            Console.WriteLine("Account(string inName) Constructor called.");
        }
    }

    class Bank
    {
        public static void Main()
        {
            Account shubhamsAccount = new Account("Shubham");
        }
    }
}
