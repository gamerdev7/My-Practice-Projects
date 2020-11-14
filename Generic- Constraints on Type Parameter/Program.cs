using System;
using System.Reflection;

namespace Generic_Constraints_on_Type_Parameter
{
    class A { }
    class B
    {
        public B(int a) { }
    }
    class C : A, I { }

    struct S { }

    interface I { }

    delegate void D();

    enum E { }

    class Generics
    {
        public static void GenericMethod1<T>() where T : new() // T must be a type with parameterless constructor.
        { }

        public static void GenericMethod2<T>() where T : class // T must be a Reference Type: like class, interface, delegates.
        { }

        public static void GenericMethod3<T>() where T : A // T must be A or derived from A.
        { }

        public static void GenericMethod4<T>() where T : struct // T must be a value type except nullable types.
        {
            T obj = default(T); // Sets default value for type T.
        }

        public static void GenericMethod5<T>() where T : I // T must be I or implement I.
        { }

        public static void GenericMethod6<T, U>() where T : U // T must be derived from U or be U
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // GenericMethod1.
            Generics.GenericMethod1<A>();
            //Generics.GenericMethod1<B>(); // Because B does not have parameterless Constructor.

            Generics.GenericMethod1<S>();
            //Generics.GenericMethod1<I>(); // Interfaces do not have any constructors.
            //Generics.GenericMethod1<D>(); // delegates do not have a parameterless constructor.
            Generics.GenericMethod1<E>();


            // GenericMethod2.
            Generics.GenericMethod2<A>();
            //Generics.GenericMethod2<S>(); // Structs are value types.
            Generics.GenericMethod2<I>();
            Generics.GenericMethod2<D>();
            //Generics.GenericMethod2<E>(); // Since Enums are value types.


            // GenericMethod3
            Generics.GenericMethod3<A>();
            //Generics.GenericMethod3<B>(); // B doesn't inherits from A
            Generics.GenericMethod3<C>();
            //Generics.GenericMethod3<S>(); // S doesn't inherits from A
            //Generics.GenericMethod3<I>();
            //Generics.GenericMethod3<D>();
            //Generics.GenericMethod3<E>();


            // GenericMethod4
            //Generics.GenericMethod4<A>();
            Generics.GenericMethod4<S>();
            //Generics.GenericMethod4<I>();
            //Generics.GenericMethod4<D>();
            Generics.GenericMethod4<E>();
            //Generics.GenericMethod4<int?>();


            // GenericMethod5
            //Generics.GenericMethod5<A>();
            Generics.GenericMethod5<C>();
            //Generics.GenericMethod5<S>();
            Generics.GenericMethod5<I>();
            //Generics.GenericMethod5<D>();
            //Generics.GenericMethod5<E>();


            // GenericMethod6
            Generics.GenericMethod6<C, A>(); // C is derived from A.
            Generics.GenericMethod6<C, I>(); // C is derived from I.
            Generics.GenericMethod6<A, A>(); // T is A.
            //Generics.GenericMethod6<A, I>();
            Generics.GenericMethod6<E, E>();

            // To check whether enum E has a parameterless constructor.
            Type T = typeof(E);
            Console.WriteLine("Constructors");
            var constructors = T.GetConstructors(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine();
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor);
            }

        }
    }
}
