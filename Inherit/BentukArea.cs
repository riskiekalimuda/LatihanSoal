using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal.Inherit
{
    public class BentukArea
    {
        protected int panjang;
        protected int lebar;
        protected int tinggi;

        public void NilaiPanjang(int panjang)
        {
            this.panjang = panjang;
        }
        public void NilaiLebar(int lebar)
        {
            this.lebar = lebar;
        }
        public void NilaiTinggi(int tinggi)
        {
            this.tinggi = tinggi;
        }
    }
}
