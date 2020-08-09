using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal.STUDENT_DETAILS
{
    public class SupplyData
    {
        public static List<Student> StudentsDataSource()
        {
            List<Student> lstStudents = new List<Student>()
            {
                new Student{First="Tom", Last=".S", ID=1, Marks = new List<int>(){97,92,81,60}},
                new Student{First="Jerry", Last=".M", ID=2, Marks = new List<int>(){75, 84, 91, 39}},
                new Student{First="Bob", Last=".P", ID=3, Marks = new List<int>(){88,94,65,91}},
                new Student{First="Mark", Last=".G", ID=4, Marks = new List<int>(){97, 89, 85, 82}}
            };
            return lstStudents;
        }

        public static List<ContactInfo> ContactInfoDataSource()
        {
            List<ContactInfo> lstContactInfos = new List<ContactInfo>()
            {
                new ContactInfo{ID=111, Email="Tom@abc.com", Phone="347342343"},
                new ContactInfo{ID=112, Email="Jerry123@aaa.com", Phone="3998787"},
                new ContactInfo{ID=113, Email="Bobstar@aaa.com", Phone="890998776"},
                new ContactInfo{ID=114, Email="Markantony@bvbvbvb.com", Phone="67775118776"}
            };
            return lstContactInfos;
        }
    }
}
