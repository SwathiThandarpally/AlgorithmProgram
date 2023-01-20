using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class PrimeNumbers
    {
        public void Display()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers Range From 0-1000 : ");
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }

    }
}
