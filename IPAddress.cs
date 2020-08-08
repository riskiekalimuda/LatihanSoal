using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal
{
    public class IPAddress
    {
        public void GetIPAddress()
        {
            String strHostName = String.Empty;
            strHostName = Dns.GetHostName();
            Console.WriteLine("Nama Hostnya adalah: " + strHostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            System.Net.IPAddress[] addr = ipEntry.AddressList;
            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address: {0}", addr[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
