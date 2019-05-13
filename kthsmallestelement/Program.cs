using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kthsmallestelement
{
    //Given an array and a number k where k is smaller than size of array, we need to find the k’th smallest element in the given array.
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 14, 8, 4, 9, 12, 5, };
            int k = 3;
            kthsmallest(a, k);
            Console.ReadKey();
        }

        public static int kthsmallest(int[] arr, int s)
        {
         
            int temp;

            for (int j = 0; j <= arr.Length - 1; j++)
            {
                for (int i = j + 1; i <= arr.Length - 1; i++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    
                   
                  
                }
            }
            Console.WriteLine(+s + "th element is " + arr[s-1]);

            return 1;
        }
    }
}
//Timecomplexity is o(nXn)