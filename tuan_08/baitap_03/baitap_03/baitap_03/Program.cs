using System;

namespace baitap_03
{
    class Program
    {
        static void Main(string[] args)
        {
            SINHVIEN[] sv;
            Console.WriteLine("Nhap so luong sinh vien: ");
            int size;
            size = int.Parse(Console.ReadLine());
            sv = new SINHVIEN[size];
            SINHVIEN.nhapNhieuSinhVien(sv);
            SINHVIEN.xuatBanDiem(sv);
        }

    }
}
