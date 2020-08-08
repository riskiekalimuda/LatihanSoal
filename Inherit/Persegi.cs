using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal.Inherit
{
    public class Persegi:BentukArea
    {
        public void HitungLuasPersegi()
        {
            int luas = (this.panjang * this.lebar);
            Console.WriteLine("Luas persegi adalah: {0}", luas);
            Console.ReadLine();
        }
    }
}
