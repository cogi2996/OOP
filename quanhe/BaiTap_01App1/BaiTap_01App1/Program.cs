using System;
using System.Collections;
namespace BaiTap_01App1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(29,9,2003);
            SinhVien sv1 = new SinhVien(3, "tuan", d);
            SinhVien sv2 = new SinhVien(2, "trang", d);
            SinhVien sv3 = new SinhVien(6, "quynh", d);
            ArrayList svList = new ArrayList();
            svList.Add(sv1);
            svList.Add(sv2);
            svList.Add(sv3);
            SinhVien[] x =new SinhVien[100];
            svList.Sort(new SinhVien.shortSinhVien());
            x[0] = (SinhVien)svList[0];
            x[1] = (SinhVien)svList[1];
            x[2] = (SinhVien)svList[2];
            
            foreach(SinhVien y in x)
            {
                Console.WriteLine(y.toString());
            }
       
        }
    }
}
