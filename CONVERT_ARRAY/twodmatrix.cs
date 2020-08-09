using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal.CONVERT_ARRAY
{
    public class twodmatrix
    {
        int m, n;
        int[,] a;
        int[] b;

        public twodmatrix(int x, int y)
        {
            m = x;
            n = y;
            a = new int[m, n];
            b = new int[m * n];
        }

        public void readmatrix()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0}, {1}]= ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }
        }

        public void printd()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Print Out 2D: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ConvertD()
        {
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[k++] = a[i, j]; 
                }
            }
        }
        public void printoned()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Cetak array satu dimensi : ");
            for (int i = 0; i < (m*n); i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
