using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        public void Fizzbuzz(int x)
        {
            if ((x % 5 == 0) && (x % 3 == 0))
            {
                Console.WriteLine("FIZZBUZZ");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("FIZZ");
            }
        }
    }
}