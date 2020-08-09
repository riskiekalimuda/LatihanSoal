using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal.STUDENT_DETAILS
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Marks;
        public override string ToString()
        {
            return First + " " +Last +" " + ID;
        }
    }
}
