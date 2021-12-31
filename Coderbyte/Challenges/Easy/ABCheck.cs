/**
 * Difficulty : Easy
 * Language   : C# (CSharp)
 * My Score   : 9 out of 10
 */

/**
 * AB Check
 * 
 * Have the function ABCheck(str) take the str parameter being passed 
 * and return the string true if the characters a and b are separated by 
 * exactly 3 places anywhere in the string at least once (ie. "lane borrowexd" 
 * would result in true because there is exactly three characters between a 
 * and b). Otherwise return the string false.
 * 
 * Examples
 * 
 * Input: "after badly"
 * Output: false
 * 
 * Input: "Laura sobs"
 * Output: true
 */

using System;

class Program
{
    public static string ABCheck(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if ((str[i] == 'a') && ((i + 4) < str.Length) && (str[i + 4] == 'b'))
            {
                return "true";
            }
        }
        return "false";
    }

    static void Main()
    {
        string str1 = "after badly";
        string str2 = "Laura sobs";
        Console.WriteLine(ABCheck(str1));
        Console.WriteLine(ABCheck(str2));
        // keep this function call here
        //Console.WriteLine(ABCheck(Console.ReadLine()));
    }
}
