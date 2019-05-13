using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquilibriumIndex
{
    //Equilibrium index of an array is an index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -7, 1, 5, 2, -4, 3, 0 };
            Equilibrium(a);
            Console.WriteLine("Equilibrium index is" + Equilibrium(a));
            Console.ReadKey();

        }



        public static int Equilibrium(int[] arr)
        {
            int total = 0;
            int rightsum = 0;
            int leftsum = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                total = total + arr[i];

            }
            rightsum = total;
            for (int j= 0; j <= arr.Length - 1; j++)
            {
                rightsum = rightsum - arr[j];
                if (leftsum == rightsum)
                    return j;
                leftsum += arr[j];
            }

            Console.WriteLine("no subaaray is found");
            return -1;
        }
    }
}
