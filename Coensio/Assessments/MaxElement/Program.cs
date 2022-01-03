/**
 * Company  : Kron
 * Language : C#
 * Level    : New Graduate / Junior
 */

using System;

namespace MaxElement
{
    class Program
    {
        public static int MaxElement(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
