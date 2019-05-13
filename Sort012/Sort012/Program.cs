using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort012
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 0, 2, 0, 1 };
            sort012(arr);
            Console.ReadKey();
        }

        public static void sort012(int[] a)
        {
            int count0 = 0;
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] == 0)
                    count0++;
                if (a[i] == 1)
                    count1++;
                if (a[i] == 2)
                    count2++;

            }

            for (int i = 0; i <= count0; i++)
                a[i] = 0;
            for (int i = count0; i <= (count0 + count1); i++)
                a[i] = 1;
            for (int i = (count0 + count1); i <= a.Length - 1; i++)
                a[i] = 2;
            for (int i = 0; i <= a.Length - 1; i++)
                Console.Write(a[i] + ",");
        }
    }
}

//RUNNINGTIMECOMPLEXITY AROUND O(2N)