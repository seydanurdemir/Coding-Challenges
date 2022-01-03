/**
 * Company  : Kron
 * Language : C#
 * Level    : New Graduate / Junior
 */

using System;

namespace OccurringCharacters
{
    class Program
    {
        public static string OccurringCharacters(string str)
        {
            string occ = "";

            for (int i = 0; i < str.Length; i++)
            {
                if ((str.IndexOf(str[i].ToString()) != str.LastIndexOf(str[i].ToString())) && (occ.IndexOf(str[i].ToString()) == -1))
                {
                    occ = String.Concat(occ, str[i].ToString());
                }
            }

            return occ;
        }

        static void Main(string[] args)
        {
            string str1 = "happy";
            string str2 = "improper";
            Console.WriteLine(OccurringCharacters(str1));
            Console.WriteLine(OccurringCharacters(str2));
        }
    }
}
