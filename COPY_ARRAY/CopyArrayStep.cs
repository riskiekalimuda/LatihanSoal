using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal.COPY_ARRAY
{
    public class CopyArrayStep
    {
        public static void ProsesCopyArray()
        {
            int n, m, size;

            Console.Write("Masukan ukuran array sumber: ");
            n = int.Parse(Console.ReadLine());
            int[] arrAsal = new int[n];
            Console.WriteLine("Masukkan element-element array sumber: ");
            for (int i = 0; i < n; i++)
            {
                arrAsal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.Write("Masukkan ukuran array target: ");
            m = int.Parse(Console.ReadLine());
            int[] arrTarget = new int[m];
            Console.WriteLine("Masukkan section dari array sumber " +
                "yang akan di copy: ");
            size = int.Parse(Console.ReadLine());
            Array.Copy(arrAsal, 0, arrTarget, 0, size);
            Console.WriteLine("Array baru dengan section spesifik elemen dari array sumber: ");
            foreach (var item in arrTarget)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
