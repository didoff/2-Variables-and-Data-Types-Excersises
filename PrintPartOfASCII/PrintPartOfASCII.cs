using System;

namespace PrintPartOfASCII
{
    class PrintPartOfASCII
    {
        static void Main(string[] args)
        {
            //char startSymbol = char.Parse(Console.ReadLine());
            //char endSymbol = char.Parse(Console.ReadLine());

            int startSymbol = int.Parse(Console.ReadLine());
            int endSymbol = int.Parse(Console.ReadLine());

            for (int i = 0; i < endSymbol - startSymbol +1; i++)
            {

                char n = Convert.ToChar(startSymbol + i);
                Console.Write(n + " ");
            }

            Console.WriteLine();
            
        }
    }
}
