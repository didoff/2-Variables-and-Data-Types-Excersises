using System;

namespace ComparingFloats_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool equalAB = (Math.Abs(a-b) < 0.000001);

            Console.WriteLine(equalAB);

        }
    }
}
