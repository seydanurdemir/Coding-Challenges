/**
 * Difficulty : Hard
 * Language   : C# (CSharp)
 * My Score   : 6 out of 15
 */

/**
 * Calculator
 * 
 * Have the function Calculator(str) take the str parameter being 
 * passed and evaluate the mathematical expression within in. For
 * example, if str were "2+(3-1)*3" the output should be 8. Another 
 * example: if str were "(2-0)(6/2)" the output should be 6. There can be 
 * parenthesis withşn the string so you must evaluate it reply 
 * according to the rules of arithmetic. The string will contain the 
 * operator: +,-,/,*,(, and ). If you have a string like this: #/#*# or #+# 
 * (#)/#, then evaluate from left to right. So divide then multiply, and for 
 * the second one multiply, divide, then add. The evaluations will be such 
 * that there will not be any decimal operations, so you do not need to 
 * account for rounding and whatnot.
 * 
 * Examples
 * 
 * Input: "6*(4/2)+3*1"
 * Output: 15
 * 
 * Input: "6/3-1"
 * Output: 1
 */

using System;

class MainClass
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
    static void Main()
    {
        //string str1 = "6*(4/2)+3*1";
        //string str2 = "6/3-1";
        //Console.WriteLine(Calculator(str1));
        //Console.WriteLine(Calculator(str2));
        // keep this function call here
        Console.WriteLine(Calculator(Console.ReadLine()));
    }
}
