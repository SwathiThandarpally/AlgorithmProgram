using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class BubbleSorting
    {
        public void Display()
        {
            int[] arr = { 50,40,30,20,10 };
            Console.WriteLine("Unsorted Array");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("sorted array");
            foreach (int p in arr)
            {
                Console.WriteLine(p + "");
            }
        }
    }
}
