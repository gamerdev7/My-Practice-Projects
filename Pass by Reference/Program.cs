using System;

namespace Pass_by_Reference
{
    class Person
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
            // Passing Value Type by Reference
            int i = 10;
            Add100(ref i);
            Console.WriteLine($"i : {i}");
            // Passing Value Type by Reference


            // Passing Reference Type by Reference
            Person person = new Person("Shubham", 20);
            ChangeReference(ref person);
            Console.WriteLine($"person object - Name : {person.name}  Age : {person.age}");
            // Passing Reference Type by Reference
        }

        public static void Add100(ref int j)
        {
            j += 100;
        }

        public static void ChangeReference(ref Person per)
        {
            per = new Person("Sam", 100);
            /*or we could set 
              per = null ;  // Error generated bcoz there was only one reference and I made it null.
            */
        }

    }
}
