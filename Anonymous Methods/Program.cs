using System;


namespace Anonymous_Methods_and_Lambda_Expressions
{
    public delegate string GreetingsDelegate(string name);

    class Program
    {
        public static string Greetings(string name)
        {
            return ($"Hello {name} a very good morning!");
        }

        static void Main()
        {
            // Using Greetings Method
            GreetingsDelegate g1 = Greetings;
            Console.WriteLine(g1("Shubham"));

            // Anonymous Method
            GreetingsDelegate g2 = delegate (string name)
            {
                return ($"Hello {name} a very good morning!");
            };
            Console.WriteLine(g2("Shubham"));

            // Anonymous Method - Omitting Parameter
            GreetingsDelegate g3 = delegate { return "Hello Everyone! Parameters can be omitted if not in use by Anonymous Method."; };
            Console.WriteLine(g3("Shubham"));
          
            // Lambda Expression
            GreetingsDelegate g4 = (name) =>
            {
                return ($"Hello {name} a very good morning!");
            };
            Console.WriteLine(g4("Shubham"));

            GreetingsDelegate g5 = name =>  ($"Hello {name} Parameters can't be omitted if not in use by Lambda Expressions.");
            Console.WriteLine(g5("Shubham"));
        }
    }
}
