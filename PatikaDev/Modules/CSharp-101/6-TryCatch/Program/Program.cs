using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Try - Catch - Finally");
            Console.WriteLine();

            try
            {
                Console.Write("Enter number a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter number b : ");
                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine("Try : Result is " + c + ".");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch :  Error. " + ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally : Completed.");
            }

            Console.WriteLine();
        }
    }
}
