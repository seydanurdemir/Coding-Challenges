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
            int[] arr1 = { 1, 3, 7, 21, 2, 4 };
            int[] arr2 = { 1 };
            Console.WriteLine(MaxElement(arr1));
            Console.WriteLine(MaxElement(arr2));
        }
    }
}
