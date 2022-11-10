using System;

namespace PhanMemQuanLyNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            LapTrinhVien ltv = new LapTrinhVien();
            ltv.setLuongCoBan(new TienLuong(double.Parse(Console.ReadLine())));
            ltv.setSoGioLamThem(int.Parse(Console.ReadLine()));
            ltv.setLuongNgoaiGio(new TienLuong(double.Parse(Console.ReadLine())));
            Console.WriteLine(ltv.TinhLuong().toString());

        }
    }
}
