using System;

namespace Partial_Methods
{
    partial class PartialClass
    {
        partial void PartialMethod();

        public void NormalMethod()
        {
            Console.WriteLine("Normal Method invoked");
            PartialMethod();
        }
    }
}
