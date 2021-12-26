using System;

// https://docs.microsoft.com/tr-tr/dotnet/api/system.string?view=netcore-3.1
// https://docs.microsoft.com/tr-tr/dotnet/api/system.datetime?view=netcore-3.1
// https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
// https://www.thevbprogrammer.com/VB2010_04/04-02-CompositeFormatting.htm

namespace VariablesDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "Data Type", "Content", "Min Value", "Max Value");
            Console.WriteLine();

            sbyte var_sbyte = 1; // 1 byte, 8 bits, from -128 to 127
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "sbyte", var_sbyte, sbyte.MinValue, sbyte.MaxValue);

            byte var_byte = 1; // 1 byte, 8 bits, from 0 to 255
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "byte", var_byte, byte.MinValue, byte.MaxValue);

            short var_short = 1; // 2 bytes, 16 bits, from -32,768 to 32,767
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "short", var_short, short.MinValue, short.MaxValue);

            ushort var_ushort = 1; // 2 bytes, 16 bits, from 0 to 65,535
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "ushort", var_ushort, ushort.MinValue, ushort.MaxValue);

            int var_int = 1; // 4 bytes, 32 bits, from -2,147,483,648 to 2,147,483,647
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "int", var_int, int.MinValue, int.MaxValue);

            uint var_uint = 1; // 4 bytes, 32 bits, from 0 to 4,294,967,295, -u
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "uint", var_uint, uint.MinValue, uint.MaxValue);

            long var_long = 1L; // 8 bytes, 64 bits, from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807, -l
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "long", var_long, long.MinValue, long.MaxValue);

            ulong var_ulong = 1ul; // 8 bytes, 64 bits, from 0 to 18,446,744,073,709,551,615, -ul
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "ulong", var_ulong, ulong.MinValue, ulong.MaxValue);

            float var_float = 3.5f; // 4 bytes, 32 bits, single-precision, 7 significant digits, from -3.402823e38 to 3.402823e38, -f
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "float", var_float, float.MinValue, float.MaxValue);

            double var_double = 1.25d; // 8 bytes, 64 bits, double-precision, 15 significant digits, -1.79769313486232e308 to 1.79769313486232e308, -d
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "double", var_double, double.MinValue, double.MaxValue);

            object var_object = null; // 4 byte addresses, all csharp objects
            Console.WriteLine("{0,-20} {1,-20}", "object", (var_object == null) ? "null" : "object");

            char var_char = '*'; // 2 bytes, 16 bits, unicode characters, any valid character, e.g. a,*, \x0058 (hex), or \u0058 (Unicode)
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "char", var_char, char.MinValue, char.MaxValue);

            string var_string = "string"; // 4 byte addresses, length up to 2 billion bytes
            Console.WriteLine("{0,-20} {1,-20}", "string", var_string);

            decimal var_decimal = 1000.25m; // 24 bytes, from 28 to 29 significant digits, 128 bits, from (+ or -)1.0 x 10e-28 to 7.9 x 10e28, -m
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "decimal", var_decimal, decimal.MinValue, decimal.MaxValue);

            bool var_bool = true; // 1 byte, 8 bits, true or false
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "bool", var_bool, "True", "False");

            DateTime var_datetime = DateTime.Now; // 8 bytes, from 00:00:00am 01/01/01 to 11:59:59pm 12/31/9999
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", "DateTime", var_datetime, DateTime.MinValue, DateTime.MaxValue);

            //DateSpan var_datespan = null; // n bytes, from -10675199.02:48:05.4775808 to 10675199.02:48:05.47758076
            //Console.WriteLine("DateSpan : " + var_datespan);

            Console.WriteLine();
            Console.WriteLine("ToString, Convert, ToInt32, Parse");
            Console.WriteLine();

            int int20 = 20;
            string str20 = "20";

            string newstr20 = str20 + int20.ToString();
            Console.WriteLine("ToString : " + newstr20);

            string newnewstr20 = str20 + Convert.ToString(int20);
            Console.WriteLine("Convert  : " + newnewstr20);

            int newint20 = int20 + Convert.ToInt32(str20);
            Console.WriteLine("ToInt32  : " + newint20);

            int newnewint20 = int20 + int.Parse(str20);
            Console.WriteLine("Parse    : " + newnewint20);

            Console.WriteLine();
            Console.WriteLine("Formatted DateTime");
            Console.WriteLine();

            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

            Console.WriteLine();
        }
    }
}
