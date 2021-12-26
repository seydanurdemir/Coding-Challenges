using System;

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Implicit Conversion");
            Console.WriteLine();

            Console.WriteLine("int >> long");
            int num = 2147483647;
            long bigNum = num;

            Console.WriteLine("Derived Class >> Base Class (it is OK)");
            // Derived d = new Derived();
            // Base b = d; // OOP

            // It is OK
            // UnSafeCast.Test1(new Reptile());

            Console.WriteLine();
            Console.WriteLine("Explicit Conversion");
            Console.WriteLine();

            Console.WriteLine("double >> (int)double");
            double x = 1234.7;
            int a;
            a = (int)x;

            Console.WriteLine("Base Class >> Derived Class (compile but throw exception at run time)");
            // Derived d = new Derived();
            // Base b = d; // OOP
            // if the right-side object b is not in fact a Derived
            // Derived d2 = (Derived)b; // compile but will throw an exception at run time

            // Unhandled exception. System.InvalidCastException
            // UnSafeCast.Test2(new Animal());

            Console.WriteLine();
            Console.WriteLine("ToString, Convert, ToInt32, Parse");
            Console.WriteLine();

            Console.WriteLine("ToString");
            Console.WriteLine("Convert");
            Console.WriteLine("ToInt32");
            Console.WriteLine("Parse");

            Console.WriteLine();
        }
    }
}
