
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofaSubarray
{
    //Write an efficient program to find the sum of contiguous subarray within a one-dimensional array of numbers which has the largest sum.

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, -1, -2, 4, -3, 5, -2, 7 };
            Console.WriteLine("Max sum is " + Maxsum(a));
            Console.ReadKey();
        }


        public static int Maxsum(int[] array)
        {


            int sum = 0;
            int result = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                sum = sum + array[i];
                if (sum < 0)
                {
                    sum = 0;
                }
                else if (sum > result)
                {
                    result = sum;

                }


            }
            return result;


        }
    }
}


//TIME COMPLEXITY=O(N) AS IT IS TRAVERSING ALL THE ELEMENTS ONE TIME.