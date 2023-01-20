using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class InsertionSort
    {
        public void Sorting(int[] intArray)
        {
            for (int i = 1; i < intArray.Length; ++i)
            {
                int key = intArray[i];
                int j = i - 1;
                while (j >= 0 && intArray[j].CompareTo(key) > 0)
                {
                    intArray[j + 1] = intArray[j];
                    j = j - 1;
                }
                intArray[j + 1] = key;
            }
        }

        public void DisplayArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; ++i)
            {
                Console.Write(intArray[i] + "\n");
            }
        }
    }
}
