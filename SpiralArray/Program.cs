using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralArray
{
    //Given a 2D array, print it in spiral form
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int row = 4;
            int col = 4;
            Spiralarray(a, row, col);
            Console.ReadKey(); 
        }

        public static void Spiralarray(int[,] a,int row, int col)
        {
            int r = 0;
            int c = 0;
            int lastrow = row - 1;
            int lastcol= col - 1;
            while (r <= lastrow && c <= lastcol)
            {
                for (int i = r; i <= lastcol; i++)
                {
                    Console.Write(a[r, i] + "  ");

                }
                r++;

                for (int i = r; i <= lastrow; i++)
                {
                    Console.Write(a[i, lastcol] + "  ");

                }
                lastcol--;
              
                {
                    for (int i = lastcol; i >= c; i--)
                    {
                        Console.Write(a[lastrow, i]+ "  ");
                    }
                }
                lastrow--;
                
                {
                    for (int i = lastrow; i >= r; i--)
                    {
                        Console.Write(a[i, c] + "  ");
                    }
                }
                c++;


            }


        }
    }
}
