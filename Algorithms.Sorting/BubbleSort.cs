using System;

namespace Algorithms.Sorting
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool swapperd = false;

                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        SwapHelper.Swap(array, j, j + 1);
                        swapperd = true;
                    }
                }

                if (!swapperd)
                    break;
            }
        }
    }
}
