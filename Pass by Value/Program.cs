using System;

namespace Pass_by_Value
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
            // Passing Value Type by Value
            int i = 10;
            Add100(i);
            Console.WriteLine($"i : {i}");
            // Passing Value Type by Value


            // Passing Reference Type by Value
            Person person = new Person("Shubham", 20);
            ChangeReference(person);
            Console.WriteLine($"person object - Name : {person.name}  Age : {person.age}");
            // Passing Reference Type by Value
        }

        public static void Add100(int j)
        {
            j += 100;
            Console.WriteLine($"j : {j}");
        }

        public static void ChangeReference(Person per)
        {
            per = new Person("Sam", 100);
            /*or we could set 
              per = null ; // No Error generated as opposed to Pass by Reference counterpart bcoz person and per are 2 different variables.
            */
        }

    }
}
