using System;

namespace bai_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Oto oto = new Oto("ToYoTa", 2015, 100, "gray", 4, "xang");
            XeMay xeMay = new XeMay("AB", 2020, 40, "blue", 14.5);
            XeTai xeTai = new XeTai("Suzuki", 2012, 415, "green", 150);
            xeMay.XuatThongTin();
            oto.XuatThongTin();
            xeTai.XuatThongTin();
            Console.WriteLine("Nhap so luong phuong tien: ");
            int n = int.Parse(Console.ReadLine());
            IQuanLy[] phuongTien = new IQuanLy[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap 1 - de chon Oto\nNhap 2 - de chon xe may\nNhap 3 - de chon xe tai");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    phuongTien[i] = new Oto();
                }
                else if (choice == 2)
                {
                    phuongTien[i] = new XeMay();
                }
                else if (choice == 3)
                {
                    phuongTien[i] = new XeTai();
                }
                phuongTien[i].KhoiTao();
            }

            foreach (IQuanLy item in phuongTien)
            {
                item.XuatThongTin();
            }

            Console.WriteLine("Tim phuong tien theo mau, nhap mau: ");
            string mauCanTim = Console.ReadLine();
            foreach (IQuanLy item in phuongTien)
            {
                if (item.KiemTraMau(mauCanTim))
                    item.XuatThongTin();
            }

            Console.WriteLine("Tim phuong tien truoc nam: ");
            int nam = int.Parse(Console.ReadLine());
            foreach (IQuanLy item in phuongTien)
            {
                if (item.KiemTraNam(nam))
                    item.XuatThongTin();
            }
        }
    }
}
