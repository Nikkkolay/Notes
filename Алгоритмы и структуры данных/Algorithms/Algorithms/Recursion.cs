using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Recursion
    {
        public static int RecursiveSum(int[] arr, int startIndex = 0)
        {
            if (startIndex == arr.Length) return 0;
            return arr[startIndex] + RecursiveSum(arr, startIndex + 1);
        }

        public static int RecursiveLenghtInLinkedList(LinkedListNode<int> itemFromList)
        {
            if (itemFromList.Next == null) return 1;
            return 1 + RecursiveLenghtInLinkedList(itemFromList.Next);
        }
        
        public static int RecursiveMaxInLinkedList(LinkedListNode<int> itemFromList, int max)
        {
            if (itemFromList.Value > max)
                max = itemFromList.Value;
            
            if (itemFromList.Next == null) return max;
            return RecursiveMaxInLinkedList(itemFromList.Next, max);
        }

        public static int RecursiveBinarySearch(int desiredNumber, int[] arr, int firstIndex, int lastIndex)
        {
            if (firstIndex == lastIndex) 
                return arr[firstIndex] == desiredNumber ? firstIndex : -1;
            
            var midIndex = (firstIndex + lastIndex) / 2;
            if (arr[midIndex] == desiredNumber) 
                return midIndex;

            if (arr[midIndex] < desiredNumber)
                return RecursiveBinarySearch(desiredNumber, arr, midIndex + 1, lastIndex);
            else
                return RecursiveBinarySearch(desiredNumber, arr, firstIndex, midIndex - 1);
        }
        
        public static void Test()
        {
            int[] arr = {5, 2, 12, 1, 6, 2, 3};
            Console.WriteLine($"Сумма посчитанная рекурсией: {RecursiveSum(arr)}");

            LinkedList<int> list = new LinkedList<int>(new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9});
            Console.WriteLine($"Количество элементов посчитанных рекурсией: {RecursiveLenghtInLinkedList(list.First)}");
            
            Console.WriteLine($"Максимальный элемент найденный рекурсией: {RecursiveMaxInLinkedList(list.First, list.First.Value)}");
            
            int[] arrSorted = {1, 2, 5, 12, 89, 600};
            Console.WriteLine($"index элемента '12' найденный рекурсией: {RecursiveBinarySearch(12, arrSorted, 0, arrSorted.Length - 1)}");
            Console.WriteLine($"index элемента '13' найденный рекурсией: {RecursiveBinarySearch(13, arrSorted, 0, arrSorted.Length - 1)}");
        }
    }
}