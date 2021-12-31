/**
 * Difficulty : Medium
 * Language   : C# (CSharp)
 * My Score   : 9 out of 10
 */

/**
 * Distinct List
 * 
 * Have the function DistinctList(arr) take the array of numbers
 * stored in arr and determine the total number of duplicate entries. For 
 * example if the input is [1, 2, 2, 2, 3] then your program should output 2
 * because there are two duplicates of one of the elements.
 * 
 * Examples
 * 
 * Input: [0,-2,-2,5,5,5]
 * Output: 3
 * 
 * Input: [100,2,101,4]
 * Output: 0
 */

using System;

class Program
{
    public static int DistinctList(int[] arr)
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

    static void Main()
    {
        int[] arr1 = { 0, -2, -2, 5, 5, 5 };
        int[] arr2 = { 100, 2, 101, 4 };
        Console.WriteLine(DistinctList(arr1));
        Console.WriteLine(DistinctList(arr2));
        // keep this function call here
        //Console.WriteLine(DistinctList(Console.ReadLine()));
    }
}
