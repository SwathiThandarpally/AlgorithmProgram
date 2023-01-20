using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class MergeSort
    {
        public void MergeSorting()
        {
            string[] stringArray = { "Song","Apple","Graphs","Banana","Cat" };
            Console.WriteLine("Before Sorted Array");
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            sortingArray(stringArray, 0, stringArray.Length - 1);

            Console.WriteLine("Array after sorting : ");
            printArray(stringArray);
        }

        public void MergeArray(string[] array, int left, int mid, int right)
        {
            int L = mid - left + 1;     // Size of left subarray
            int R = right - mid;        // Size of right subarray

            string[] leftArray = new string[L];
            string[] rightArray = new string[R];

            int i, j;
            for (i = 0; i < L; ++i)
            {
                leftArray[i] = array[left + i];
            }

            for (j = 0; j < R; ++j)
            {
                rightArray[j] = array[mid + 1 + j];
            }

            i = 0;
            j = 0;

            int k = left;
            while (i < L && j < R)
            {
                if (leftArray[i].CompareTo(rightArray[j]) <= 0)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < L)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < R)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }

        void sortingArray(string[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                sortingArray(array, left, mid);

                sortingArray(array, mid + 1, right);

                MergeArray(array, left, mid, right);
            }

        }
        void printArray(string[] array)
        {
            foreach (var str in array)
            {
                Console.Write(str + "  ");
            }
        }
        //    List<int> unsorted = new List<int>() {1,4,5,8,2,9,4,22,7};
        //    List<int> sorted;

        //    Random random = new Random();
        //    Console.WriteLine("Original array element");
        //    for(int i = 0; i< 9; i++)
        //    {
        //        unsorted.Add(random.Next(0, 10));
        //        Console.WriteLine(unsorted[i] + " ");
        //    }
        //    Console.WriteLine();

        //    sorted = (unsorted);
        //    Console.WriteLine("sorted array element");
        //    foreach (int x in sorted)
        //    {
        //        Console.WriteLine(x + " ");
        //    }
        //    Console.WriteLine("\n");
        //    if (unsorted.Count < 1)
        //    {
        //        return;

        //        List<int> left = new List<int>();
        //        List<int> right = new List<int>();

        //        int middle = unsorted.Count / 2;
        //        for (int i = 0; i < middle; i++)
        //        {
        //            left.Add(unsorted[i]);
        //        }
        //        for (int i = middle; i < unsorted.Count; i++)
        //        {
        //            right.Add(unsorted[i]);
        //        }
        //        left = (left);
        //        right = (right);
        //        return;
        //    }
        //    if (unsorted.Count < 0)
        //    {
        //        Console.WriteLine("Array is Sorted");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Array is not Sorted");
        //    }

        //}

    }  
}
