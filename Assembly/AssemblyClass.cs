using System;
using AssemblyLibrary;

namespace Assembly
{
    class AssemblyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AssemblyLibraryClass.GetMessage());
            Console.WriteLine("Hi! You are in AssemblyClass");
            Console.ReadLine();
        }
    }
}
