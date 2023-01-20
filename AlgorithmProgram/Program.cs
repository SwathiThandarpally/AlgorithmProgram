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
            int[] array1 = {1,2,3,4,5,6 };
            InsertionSort sorting = new InsertionSort();
            sorting.Sorting(array1);
            sorting.DisplayArray(array1);

        }
    }
}