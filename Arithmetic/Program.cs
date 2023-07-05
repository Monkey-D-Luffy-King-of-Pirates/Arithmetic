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
            int one;
            int two;

            Console.Write("Please, enter first number: ");
            while (!int.TryParse(Console.ReadLine(), out one))
            {
                Console.Write("No, you wrong! Please, enter first number: ");
            }
            Console.Write("Please, enter second number: "); 

            int first = one; 

            while (!int.TryParse(Console.ReadLine(),out two))
            {
                Console.Write("No, you wong! Please, enter first number: ");
            }

            int second = two;

            Console.WriteLine(first + second);
            Console.WriteLine(first - second);
            Console.WriteLine(first * second);
            Console.WriteLine(first / second);
            Console.ReadKey();
        }
    }
}
