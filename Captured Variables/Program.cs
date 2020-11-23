using System;
using System.Text;
namespace Captured_Variables
{
    delegate void SomeAction();
    
    class Program
    {
        static void Main(string[] args)
        {
            SomeAction instance = MakeDelegate();
            instance();
            instance();
        }

        static SomeAction MakeDelegate()
        {
            StringBuilder sb = new StringBuilder("HISHUBHAM");
            Console.WriteLine(sb);
            Random rng = new Random();  // A new class (by the name <>c__DisplayClass1_0) will be created in the CIL code and rng will be the field 
                                        // and MakeDelegate() will be the method of that class. So thats why the anonymous method can access rng variable.
                                        // But the sb variable will not be included as the member of that class bcoz it is not being used in the delegate.

            return delegate { Console.WriteLine(rng.Next());
                //Console.WriteLine(sb);
            };

        }
    }
}
