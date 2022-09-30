using System;

namespace BaiTap_01App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(29,9,2003);
            SinhVien sv = new SinhVien(1, "Cong Tuan", d);
            Console.WriteLine(sv.toString());
            Console.ReadKey();
        }
    }
}
