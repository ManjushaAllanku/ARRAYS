using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersOfArray
{
    /*Write a program to print all the LEADERS in the array. An element is leader if it is greater than all the elements to its right side. And the rightmost element is always a leader. 
     * For example int the array {16, 17, 4, 3, 5, 2}, leaders are 17, 5 and 2 */
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 16, 4, 7, 2, 3, 1 };
            int length = arr.Length - 1;
            Console.WriteLine(Leaders(arr, length));
            Console.ReadKey();
        }

        public static int Leaders(int []a, int n)
        {
            int lead=0;                   
           for(int i=n; i >= 0; i--)
            {
                if (a[i] > lead)
                {
                    lead = a[i];
                    Console.WriteLine("leaders are" + a[i]);
                }
            }
            return 1;
        }
       
    }
}

//RUNNINGTIME IS O(n)