using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            //string loInput = userInput.ToLower();
            bool converted = Convert.ToBoolean(userInput.ToLower());

            if(converted)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            //Console.WriteLine(converted ? "Yes" : "No");
            
        }
    }
}
