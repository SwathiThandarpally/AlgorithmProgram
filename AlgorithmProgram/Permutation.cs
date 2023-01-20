using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class Permutation
    {
        public void Display()
        {
            int[] arr1 = new int[4] { 1, 2, 3, 4 };
            Permutation test = new Permutation();
            Console.WriteLine("Enter a element to store[max 2 digits");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter{0} num of element in array", n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("element={0}: ", i);
                
            }
            Console.WriteLine("Permutation with a combination of {0} digits are :", n);
            Console.WriteLine("\n");


        }
        public void swapTwoNumber(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void printPermut(int[] list, int c, int t)
        {
            int i;
            if (c == t)
            {
                for (i = 0; i <= t; i++)
                {
                    Console.WriteLine("{0}", list[i]);
                    Console.WriteLine(" ");
                }

            }
            else
            {
                for (i = 0; i <= t; i++)
                {
                    swapTwoNumber(list[c], list[i]);
                    printPermut(list, c + 1, t);
                    swapTwoNumber(list[c], list[i]);
                }
            }
        }


    }
}
