using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal
{
    public class arrsampl
    {
        int[,] x;
        public arrsampl()
        {
            x = new int[,] { { 11, 2, 61 }, { 42, 50, 3 } };
        }
        public void PrintArray()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(x[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        public int max()
        {
            int small = x[0, 0];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (small > x[i, j])
                        small = x[i, j];
                }
            }
            return small;
        }
    }
}
