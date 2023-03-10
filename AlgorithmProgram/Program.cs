using AlgorithmProgram;

namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Algorithm Programs");
            //UC_1
            BinarySearch binarySearch = new BinarySearch();
            binarySearch.Display();
            Console.WriteLine("------------------------------------");
            //UC_2
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            InsertionSort sorting = new InsertionSort();
            sorting.Sorting(array1);
            sorting.DisplayArray(array1);
            Console.WriteLine("------------------------------------");
            // UC_3
            BubbleSorting bubbleSorting = new BubbleSorting();
            bubbleSorting.Display();
            Console.WriteLine("------------------------------------");
            //UC_4
            MergeSort mergeSort = new MergeSort();
            mergeSort.MergeSorting();
            Console.WriteLine("------------------------------------");
            //UC_5
            Anagram anagram = new Anagram();
            anagram.Display();
            Console.WriteLine("------------------------------------");
            //UC_6
            PrimeNumbers primeNumbers = new PrimeNumbers();
            primeNumbers.Display();
            Console.WriteLine("------------------------------------");
            //UC_7
            Permutation permutation = new Permutation();
            permutation.Display();
            Console.WriteLine("------------------------------------");
            //UC_8
            ExtendedPrimeNumber extendedPrimeNumber = new ExtendedPrimeNumber();
            extendedPrimeNumber.Display();
            extendedPrimeNumber.Anagrams("earth","sweet");


        }
    }
}