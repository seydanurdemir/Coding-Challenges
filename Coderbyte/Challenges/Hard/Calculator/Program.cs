using System;

namespace Calculator
{
    class Program
    {
        public static string Calculator(string str)
        {

            // Define single operators
            char minus = '-';
            char plus = '+';
            char obelus = '/';
            char times = '*';
            //char parO = '(';
            //char parC = ')';

            // Splitter char array
            char[] chr1 = { '-', '+', '/', '*', '(', ')' };

            // Counter index variable
            int i = 0;
            int j = 0;

            // Take marks
            char[] chr2 = str.ToCharArray();
            char[] operators = new char[chr2.Length];
            j = 0;
            for (i = 0; i < operators.Length; i++)
            {
                if (Array.Exists<char>(chr1, el => (el == chr2[i])))
                {
                    operators[j++] = chr2[i];
                }
            }

            // Take operands
            string[] str2 = str.Split(chr1, StringSplitOptions.RemoveEmptyEntries);
            int[] operands = new int[str2.Length];
            for (i = 0; i < operands.Length; i++)
            {
                operands[i] = int.Parse(str2[i]);
            }

            // Then we have 2 arrays
            // A char array that contains operators
            // An int array that contains operands
            // Now we can evaluate string
            i = 0; j = 0;
            int result = operands[0];
            for (i = 0; i < operands.Length - 1; i++)
            {
                if (operators[j] == times)
                {
                    result *= operands[i + 1];
                }
                else if (operators[j] == obelus)
                {
                    result /= operands[i + 1];
                }
                else if (operators[j] == plus)
                {
                    result += operands[i + 1];
                }
                else if (operators[j] == minus)
                {
                    result -= operands[i + 1];
                }
                j++;
            }

            // My solution works without parenthesis
            return result.ToString();
        }
        static void Main(string[] args)
        {
            //string str1 = "6*(4/2)+3*1";
            string str2 = "6/3-1";
            //Console.WriteLine(Calculator(str1));
            Console.WriteLine(Calculator(str2));
        }
    }
}
