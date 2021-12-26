using System;

namespace ConsoleProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Console Programming");
            Console.WriteLine();

            Console.Write("Isminizi Giriniz : ");
            string name = Console.ReadLine();

            Console.Write("Soyisminizi Giriniz : ");
            string surname = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Merhaba " + name + " " + surname + " !");
            Console.WriteLine();
        }
    }
}
