﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarialbleInHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();
            int toDec = Convert.ToInt32(hexValue, 16);

            Console.WriteLine(toDec);
        }
    }
}
