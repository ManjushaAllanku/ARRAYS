using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndicesOfMaxSum
{
    //Given an unsorted array of nonnegative integers, find a continous subarray which adds to a given number.

    class Program
    {
       public static int SubArraySum(int[] arr, int sum)
        {
            int curr_sum = arr[0],
                     startindex = 0;

          for (int i = 1; i <= arr.Length-1; i++)
            {
                while (curr_sum > sum &&
                       startindex < i - 1)
                {
                    curr_sum = curr_sum -
                               arr[startindex];
                    startindex++;
                }

               if (curr_sum == sum)
                {
                 
                    Console.WriteLine("Sum found between " +
                                         "indexes " + startindex +
                                               " and " + i);
                    return 1;
                }

              
                if (i < arr.Length-1)
                    curr_sum = curr_sum + arr[i];

            }
            Console.WriteLine("No subarray found");
            return 0;
        }

           public static void Main()
        {
        
            int[] arr = new int[]  { 1, 4, 20, 3, 10, 5 };
            int sum = 33;
          Console.WriteLine( " subarray is"+ SubArraySum(arr, sum));
            Console.ReadKey();
        }

    }
}

//TIME COMPLEXITY IS O(n)
