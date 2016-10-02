using System;

namespace VowelOrDigit
{
    public class VowelOrDigit
    {
        public static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine().ToLower());
            
            if(input == 'a' || input == 'o' || input == 'e' || input == 'i' || input == 'i' || input == 'y')
                Console.WriteLine("vowel");
            else if(char.IsNumber(input))
                Console.WriteLine("digit");
                else
                Console.WriteLine("other");
            
            // 93/100 in Judge
        }
    }
}
