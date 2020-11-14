using System;

namespace Enums
{
    class Program
    {
        public static void Main()
        {
            Gender gender = 0;
            Console.WriteLine(gender);
            gender = (Gender)1;
            Console.WriteLine(gender);
            gender = Gender.Female;
            Console.WriteLine(gender);
            gender = (Gender)5;
            Console.WriteLine(gender);

            Console.WriteLine();

            int underlyingValue = (int)Gender.Unknown;
            Console.WriteLine(underlyingValue);

            underlyingValue = (int)Gender.Male;
            Console.WriteLine(underlyingValue);

            Console.WriteLine("---------------------");
            gender = (Gender)Season.Spring;
            Console.WriteLine(gender);

            Console.WriteLine();

            Console.WriteLine("Values of Underlying Type.");
            int[] values = (int[])Enum.GetValues(typeof(Gender));
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\nNames in the Enum.");
            string[] names = Enum.GetNames(typeof(Gender));
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public enum Season : byte
    {
        Winter = 1,
        Spring,
        Summer
    }
}
