using System;

namespace ReadOnly_Structs
{
    struct Mutable
    {
        private int x;
        public int Mutate()
        {
            this.x = this.x + 1;
            return this.x;
        }
    }

    class Test
    {
        public readonly Mutable m = new Mutable();

        static void Main(string[] args)
        {
            Test t = new Test();

            System.Console.WriteLine(t.m.Mutate()); // Readonly fields can only be changed inside the contructor of the 
                                                    // class where the field is defined or at the time of declaration.

            System.Console.WriteLine(t.m.Mutate()); // Readonly fields are not variables outside of the constructor of the 
                                                    // class where the field is defined.

            System.Console.WriteLine(t.m.Mutate()); // Bcoz t.m is readonly, a temporary variable of t.m's type will be created and the  
                                                    // value of t.m will be copied to that temporary variable. Then t.m will be 
                                                    // reclassified as the the reference of the temporary variable. The temporary 
            System.Console.WriteLine(t.m.Mutate()); // variable is not immmutable and Mutate() will be called on that temporary
                                                    // variable and will change the field inside that temporary variable. So the field
                                                    // inside the original variable (t.m) is unchanged.
        }
    }
}
