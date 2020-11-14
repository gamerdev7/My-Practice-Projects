using System;

namespace Static_and_Instance_class_members
{
    class Circle
    {
        public static float pi;
        public int radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor called.");
            Circle.pi = 3.14f;
        }

        public Circle(int radius)
        {
            Console.WriteLine("Instance Constructor called.");
            this.radius = radius;
        }

        public float Area()
        {
            return Circle.pi * this.radius * this.radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float area1 = c1.Area();
            Console.WriteLine($"Area 1 : {area1}");

            Circle c2 = new Circle(6);
            float area2 = c2.Area();
            Console.WriteLine($"Area 2 : {area2}");
        }
    }
}
