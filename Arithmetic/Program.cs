using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double one;
            double two;

            Console.Write("Please, enter first number: ");

            while (!double.TryParse(Console.ReadLine(), out one))
            {
                Console.Write("No, you wrong! Please, enter first number: ");
            }
            Console.Write("Please, enter second number: "); 

            while (!double.TryParse(Console.ReadLine(),out two))
            {
                Console.Write("No, you wong! Please, enter second number: ");
            }

            Console.WriteLine(one + two);
            Console.WriteLine(one - two);
            Console.WriteLine(one * two);
            Console.WriteLine(one / two);
            Console.ReadKey();
        }
    }
}
