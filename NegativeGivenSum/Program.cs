using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeGivenSum
{
    class Program
    {   //Given an unsorted array of integers, find a subarray which adds to a given number. 
        //If there are more than one subarrays with sum as the given number, print any of them.

        public static void SubArraySum(int[] arr, int sum)
        {
             
            int cur_sum = 0;
            int start = 0;
            int end = -1;
            Dictionary<int, int> k = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length-1; i++)
            {
                cur_sum = cur_sum + arr[i];
                if (cur_sum - sum == 0)
                {
                    start = 0;
                    end = i;
                    break;
                }
               if (k.ContainsKey(cur_sum - sum))
                {
                    start = k[cur_sum - sum] + 1;
                    end = i;
                    break;
                }
                k[cur_sum] = i;

            }
           if (end == -1)
            {
                Console.WriteLine("No subarray with given sum exists");
            }
            else
            {
                Console.WriteLine("Sum found between indexes " + start + " to " + end);
            }

        }
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 2, -2, -20, 10 };
            int sum = -10;
            SubArraySum(arr, sum);
            Console.ReadKey();

        }
    }
}
