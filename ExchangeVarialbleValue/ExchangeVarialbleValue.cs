using System;

namespace ExchangeVarialbleValue
{
    public class ExchangeVarialbleValue
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int t;

            Console.WriteLine("Before:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            t = a;
            a = b;
            b = t;

            Console.WriteLine("After:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
