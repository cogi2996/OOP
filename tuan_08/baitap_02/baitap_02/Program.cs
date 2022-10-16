using System;

namespace baitap_02
{
    class Program
    {
        static void Main(string[] args)
        {
            KhachHang[] cus;
            KhachHang cusList = new KhachHang();
            Console.WriteLine("Nhap so luong bien lai can nhap: ");
            int cusLength;
            cusLength = int.Parse(Console.ReadLine());
            cus = new KhachHang[cusLength];
            cusList.NhapBienLai(cus);
            cusList.XuatBienLai(cus);
            KhachHang.xuatTongTienBienLai(cus);
        }
    }
}
