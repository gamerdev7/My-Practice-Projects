using System;

namespace Creating_Custom_Attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property,
        AllowMultiple = true,
        Inherited = true)]
    class SampleAttribute : Attribute
    {
        [Sample(0, Name = "Sam")]
        private int Id1 { get; set; }
        public static int Id2 { get; set; }
        public string Name { get; set; }

        public SampleAttribute(int Id1)
        {
            this.Id1 = Id1;
        }
    }
    [Sample(1, Name = "Mark")]
    [Sample(2, Name = "Bob")]
    class BaseClass
    {

    }

    class DerivedClass : BaseClass
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
