using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal.STUDENT_DETAILS
{
    public class StudentDetailInfo
    {
        #region properties
        public string First { get; set; }
        public string Last { get; set; }
        public int IDStudent { get; set; }
        public int IDContact { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Identitas
        {
            get
            {
                return First + " " + Last + "-" + IDContact; 
            }
        }
        public string Contact
        {
            get
            {
                return Email + "-" + Phone;
            }
        }
        #endregion
    }
}
