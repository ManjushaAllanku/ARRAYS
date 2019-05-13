using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    /*You are given a list of n-1 integers and these integers are in the range of 1 to n. There are no duplicates in list. One of the integers is missing in the list.
    Write an efficient code to find the missing integer.*/
    class Program
    {
        static void Main(string[] args)
        {
            int []a = { 1, 2, 3, 4, 5 ,7};

            Console.WriteLine("Missing number is " +MissingNumber(a,6));
            Console.ReadKey();
        }

        public static int MissingNumber(int []a,int n)
        {
            int total = (n + 1) * (n + 2) / 2;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                total = total - a[i];

            }

            return total;
        }
    }
}



//RUNNINGTIME IS O(N)
