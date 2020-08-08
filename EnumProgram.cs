using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal
{
    public class EnumProgram
    {
        private const string result = "Yang anda pilih adalah hari: ";

        public static void JalankanProgram(int selected)
        {
            switch (selected)
            {
                case 1:
                    Console.WriteLine(result + (EnumDays)selected);
                    break;
                case 2:
                    Console.WriteLine(result + (EnumDays)selected);
                    break;
                case 3:
                    Console.WriteLine(result + (EnumDays)selected);
                    break;
                case 4:
                    Console.WriteLine(result + (EnumDays)selected);
                    break;
                case 5:
                    Console.WriteLine(result + (EnumDays)selected);
                    break;
                case 6:
                    Console.WriteLine(result + (EnumDays)selected);
                    break;
                case 8:
                    Console.WriteLine(result + (EnumDays)selected);
                    break;
                default:
                    Console.WriteLine("silahkan masukkan pilihan yang benar....");
                    break;
            }
            Console.ReadLine();
        }

        public void Start(out int selected)
        {
            Console.Write("Pilih nomor antara 1 smp 7: ");
            selected = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
