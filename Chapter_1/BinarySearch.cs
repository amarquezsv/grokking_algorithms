using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grokking
{
    public class BinarySearch
    {
        public static int search(int[] arr, int item)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low - high) / 2;
                int guess = arr[mid];
                if (guess == item)
                {
                    return mid;
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            int[] my_list = Enumerable.Range(6, 2500).ToArray();

            Console.WriteLine(BinarySearch.search(my_list, 9));
            Console.WriteLine(BinarySearch.search(my_list, 2000));
            Console.WriteLine(BinarySearch.search(my_list, 3));
        }
    }
}