using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public static class SwapHelper
    {
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
