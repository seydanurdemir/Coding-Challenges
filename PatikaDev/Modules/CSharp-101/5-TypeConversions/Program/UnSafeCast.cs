using System;

namespace Program
{
    public class Animal
    {
        public void Eat() => System.Console.WriteLine("Eating.");

        public override string ToString() => "I am an animal.";
    }

    public class Reptile : Animal { }
    public class Mammal : Animal { }

    public class UnSafeCast
    {
        /*static void Main()
        {
            Test(new Mammal());

            // Keep the console window open in debug mode.
            //System.Console.WriteLine("Press any key to exit.");
            //System.Console.ReadKey();
        }*/

        public static void Test1(Reptile r)
        {
            // It is OK
            // Able to cast object of type 'Reptile' to type 'Animal'
            Animal a = r;
        }

        public static void Test2(Animal a)
        {
            // System.InvalidCastException at run time
            // Unable to cast object of type 'Mammal' to type 'Reptile'
            Reptile r = (Reptile)a;
        }
    }
}