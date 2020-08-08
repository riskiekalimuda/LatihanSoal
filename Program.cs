using LatihanSoal.Inherit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal
{
    //SUMBER PEMBELAJARAN https://www.sanfoundry.com/csharp-program-add-complex-numbers/
    //http://www.w3big.com/id/csharp/csharp-struct.html
    class Program
    {
        static void Main(string[] args)
        {
            Persegi persegi = new Persegi();
            persegi.NilaiPanjang(15);
            persegi.NilaiLebar(10);
            persegi.HitungLuasPersegi();
        }
    }
}
