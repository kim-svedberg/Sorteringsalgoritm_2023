namespace Sorteringsalgoritm_2023
{
    internal class Program
    {
        static void Maine(string[] args)
        {
            int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 };

            var sorter = new SortingWithLibrary();
            Console.WriteLine("Unordered: ");
            sorter.Print();

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Ordered: ");
            sorter.SortDict(arr);

            //sorter.InsertionSort(arr, arr.Length - 1, 0);

            //InsertionSorter insertionSorter = new InsertionSorter();
            //insertionSorter.Sort(arr);

            sorter.Print();

        }
    }
}