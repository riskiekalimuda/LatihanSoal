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
            return First + " " + Last + " " + ID;
        }
        public double AvgMarks
        {
            get
            {
                double avg = 0;
                if (Marks.Count > 0)
                    avg = Marks.Average();
                return avg;
            }
        }
        public static List<Student> GetAllStudents()
        {
            List<Student> results = null;
            try
            {
                var queries = from s in SupplyData.StudentsDataSource()
                              select s;
                if (queries != null && queries.Count() > 0)
                {
                    results = queries.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal query data " + ex.Message);
            }
            return results;
        }
        public static List<StudentDetailInfo> GetAllStudentInfo()
        {
            List<StudentDetailInfo> result = null;
            try
            {
                var queries = from s in SupplyData.StudentsDataSource()
                              join c in SupplyData.ContactInfoDataSource()
                              on s.ID equals int.Parse(c.ID.ToString().Substring(2, 1))
                              select new StudentDetailInfo
                              {
                                  IDStudent = s.ID,
                                  IDContact = c.ID,
                                  First = s.First,
                                  Last = s.Last,
                                  Email = c.Email,
                                  Phone = c.Phone
                              };
                if (queries != null && queries.Count() > 0)
                {
                    result = queries.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal query data " + ex.Message);
            }
            return result;
        }

        public static void TampilkanStudentInfoDetail(List<StudentDetailInfo> lst)
        {
            try
            {
                int no = 0;
                Console.Write("No. ");
                Console.Write("\t NAME ");
                Console.Write("\t\t CONTACT");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------");
                foreach (var item in lst)
                {
                    no++;
                    Console.Write(no + " " + " \t");
                    Console.Write(item.Identitas + "\t");
                    Console.Write(item.Contact);
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menampilkan data " + ex.Message);
            }
        }
        public static void TampilkanNilaiRataRata(List<Student> lst)
        {
            try
            {
                int no = 0;
                Console.Write("No. \t");
                Console.Write("NAME \t\t");
                Console.Write("AVERAGE");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------");
                foreach (var item in lst)
                {
                    no++;
                    Console.Write(no + "\t");
                    Console.Write(item.ToString() + "\t");
                    Console.Write(item.AvgMarks);
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal cetak nilai " + ex.Message);
            }
        }
    }
}
