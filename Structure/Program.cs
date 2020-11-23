using System;
using System.Collections.Generic;

namespace Structure
{
    class MyClass
    {
        MyStruct MYSTRUCT;

        public MyStruct GetMYSTRUCT()
        {
            return MYSTRUCT;
        }

        public void SetMYSTRUCT(MyStruct S)
        {
            MYSTRUCT = S;
        }

        public void PrintMYSTRUCT()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Name : " + MYSTRUCT.NAME);
            Console.WriteLine("FIVE : " + MYSTRUCT.INTEGER);
        }

    }

    struct MyStruct
    {
        public string NAME;
        public int INTEGER;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();


            myClass.PrintMYSTRUCT();
            myClass.SetMYSTRUCT(new MyStruct { NAME = "shubham", INTEGER = 7 });

            // myClass.GetMYSTRUCT().NAME = "YO" -> This line will give error bcoz when we get a structure using property, indexer or a method we only get a copy of the value inside the structure
            //                                   -> (i.e, when we use property, indexer or a method the return statement returns a copy. [That's what I guessed])
            //                                   -> and we can't use that copy to change the members of original struct variable (i.e, MYSTRUCT.NAME)                                  
            myClass.PrintMYSTRUCT();

        }
    }
}