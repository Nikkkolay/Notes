using System;

namespace Algorithms
{
    public static class BinarySearch
    {
        public static int FindIndexOfNumber(int desiredNumber, int[] arr)
        {
            var firstIndex = 0;
            var lastIndex = arr.Length - 1;

            while (firstIndex <= lastIndex)
            {
                var midIndex = (lastIndex + firstIndex) / 2;
                var guess = arr[midIndex];
                
                if (guess == desiredNumber) return midIndex;
                
                if (guess < desiredNumber)
                    firstIndex = midIndex + 1;
                else
                    lastIndex = midIndex - 1;
            }

            return -1;
        }

        public static void Test()
        {
            int[] arr = {1, 2, 5, 12, 89, 6};
            Console.WriteLine(FindIndexOfNumber(5, arr));
            Console.WriteLine(FindIndexOfNumber(6, arr));
        }
    }
}