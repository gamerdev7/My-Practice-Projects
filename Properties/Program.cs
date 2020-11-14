using System;

namespace Properties
{
    class Student
    {
        private int _id;
        private string _name;
        private int _marks = 80;
        public string Email { get; set; }  // Auto-Implemented property.

        public int Id // Property.
        {
            get
            {
                return this._id;
            }

            set
            {
                this._id = value <= 0 ? throw new Exception(" Id cannot be Zero or Negative !!!") : value;
            }
        }

        public string Name // Property.
        {
            get
            {
                return string.IsNullOrEmpty(this._name) ? "Invalid Name" : this._name;
            }

            set
            {
                this._name = string.IsNullOrEmpty(value) ? throw new Exception(" Name Cannot be Null or Empty !!!") : value;
            }
        }

        public int Marks   // Read Only property.
        {
            get
            {
                return this._marks;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.Id = 10;                                   // set accessor is called.
            s.Name = "Shubham";                          // set accessor is called.
            s.Email = "shubham@gmail.com";               // set accessor is called.

            Console.WriteLine($"Id : {s.Id}");           // get accessor is called.
            Console.WriteLine($"Name : {s.Name}");       // get accessor is called.
            Console.WriteLine($"Marks : {s.Marks}");     // get accessor is called.
            Console.WriteLine($"Email : {s.Email}");     // get accessor is called.
        }
    }
}
