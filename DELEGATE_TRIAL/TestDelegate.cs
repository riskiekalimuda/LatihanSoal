using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal.DELEGATE_TRIAL
{
    public delegate void dele(string s);
    public class TestDelegate
    {
        public void Good(string s)
        {
            Console.WriteLine("Good, {0}", s);
        }
        public void Morning(string s)
        {
            Console.WriteLine("Morning, {0}", s);
        }
        public void ProcessDelegate()
        {
            dele firstdel, seconddel, multidel, multiminusfirstdel;
            firstdel = Good;
            seconddel = Morning;
            multidel = firstdel + seconddel;
            multiminusfirstdel = multidel - firstdel;
            Console.WriteLine("Invoking delegate firstdel: ");
            firstdel("A");
            Console.WriteLine("Invoking delegate seconddel: ");
            seconddel("B");
            Console.WriteLine("Invoking delegate multidel: ");
            multidel("C");
            Console.WriteLine("Invoking delegate multiminusfirstdel: ");
            multiminusfirstdel("D");
        }
    }
}
