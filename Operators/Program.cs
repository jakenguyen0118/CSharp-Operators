using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            // Console.WriteLine(a / b);
            // to get decimals, convert to float
            // Console.WriteLine((float)a / (float)b);
            // Console.WriteLine(a == b);
            Console.WriteLine(!(c > b || c == a));
        }
    }
}
