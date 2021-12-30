using System;

namespace ABCheck
{
    class Program
    {
        static string ABCheck(string str)
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
        static void Main(string[] args)
        {
            string str1 = "after badly";
            string str2 = "Laura sobs";
            Console.WriteLine(ABCheck(str1));
            Console.WriteLine(ABCheck(str2));
        }
    }
}
