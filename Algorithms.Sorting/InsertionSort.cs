using System;

namespace Algorithms.Sorting
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    SwapHelper.Swap(array, j, j - 1);
                    j--;
                }
            }
        }
    }
}
