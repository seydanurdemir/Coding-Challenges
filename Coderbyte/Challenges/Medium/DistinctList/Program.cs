using System;

namespace DistinctList
{
    class Program
    {
        static int DistinctList(int[] arr)
        {
            int d = 0;
            int duplicates = 0;
            int[] duplicated = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (!Array.Exists<int>(duplicated, el => (el == arr[i])))
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            duplicates++;
                            duplicated[d++] = arr[i];
                        }
                    }
                }
            }

            return duplicates;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 0, -2, -2, 5, 5, 5 };
            int[] arr2 = { 100, 2, 101, 4 };
            Console.WriteLine(DistinctList(arr1));
            Console.WriteLine(DistinctList(arr2));
        }
    }
}
