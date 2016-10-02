using System;

namespace IntegerToHexAndBinary
{
    public class IntegerToHexAndBinary
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string toHex = Convert.ToString(n, 16);
            string toBinary = Convert.ToString(n, 2);

            Console.WriteLine(toHex.ToUpper());
            Console.WriteLine(toBinary);
        }
    }
}
