using Algorithms.Sorting;
using System;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, -7, 1, 2, -3, -1, 0, 7, -2 };

            string arrayStr = string.Join("  ", array);
            Console.WriteLine(arrayStr);

            SelectionSort.Sort(array);

            arrayStr = string.Join("  ", array);
            Console.WriteLine(arrayStr);
        }
    }
}
