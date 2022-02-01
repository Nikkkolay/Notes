using System;

namespace Algorithms
{
    public class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                var indexOfSmallestValue = GetIndexOfSmallestValue(arr, i);
                (arr[i], arr[indexOfSmallestValue]) = (arr[indexOfSmallestValue], arr[i]);
            }
        }

        private static int GetIndexOfSmallestValue(int[] arr, int firstIndex)
        {
            var indexOfSmallestValue = firstIndex;
            
            for (var i = firstIndex + 1; i < arr.Length; i++)
                if (arr[i] < arr[indexOfSmallestValue])
                    indexOfSmallestValue = i;

            return indexOfSmallestValue;
        }
        
        public static void Test()
        {
            int[] arr = {5, 2, 12, 1, 6, 89};

            Sort(arr);
            
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}