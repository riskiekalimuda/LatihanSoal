using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LatihanSoal.BELAJAR_GROUPING_LINQ
{
    public class GroupingFileApp
    {
        public static IEnumerable<object> GetGroupingFile(String[] namaFiles)
        {
            try
            {
                var arrGrp = namaFiles.Select(File => Path.GetExtension(File).TrimStart('.').ToLower()).GroupBy(x => x,(ext, extC) => new
                {
                    Extention = ext,
                    Count = extC.Count()
                });
                return arrGrp;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal grouping file " + ex.Message);
            }
        }

        public static void CetakGroupingFiles(IEnumerable<object> arrObj)
        {
            try
            {
                foreach (object obj in arrObj)
                {
                    String ext = "";
                    int cnt = -1;
                    foreach (var property in obj.GetType().GetProperties())
                    {
                        if (property.Name.Equals("Count"))
                            cnt = int.Parse(property.GetValue(obj, null).ToString());
                        else
                            ext = property.GetValue(obj, null).ToString();

                        if(!String.IsNullOrEmpty(ext) && cnt >= 0)
                         Console.WriteLine("{0} file(s) with {1} Extension ", cnt, ext);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mencetak grouping files " + ex.Message);
            }
        }
    }
}
