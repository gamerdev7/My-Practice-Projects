using System;

namespace Unsafe_Code
{
    public unsafe class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
              //  Person person = new Person("Shubham", 20);
               // Person* addressOfPerson = &person;
               // ChangeField(person);

                //Console.WriteLine($"Address of Person : {}");
            }
        }

        public static void ChangeField(Person per)
        {
            per.name = "Hey";
            per.age = 100;
            per = null; // No Error generated as opposed to Pass by Reference counterpart bcoz person and per are 2 different variables with same reference.
        }
    }
}
