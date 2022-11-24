using System;

namespace bai_05
{
    class Program
    {
        static void Main(string[] args)
        {

            NVBC nhanVienBienChe = new NVBC("21110709E", "Nguyen Van A", 2002, 250, 6, 990);
            NVHD nhanVienHopDong = new NVHD("2154542D", "Nguyen Van B", 2000, 210, 60);
            nhanVienBienChe.XuatThongTin();
            nhanVienHopDong.XuatThongTin();
            //Nhap danh sach nhan vien
            Console.WriteLine("Nhap so luong nhan vien:");
            int n = int.Parse(Console.ReadLine());
            ILuong[] listNhanVien = new ILuong[n];
            double tongLuong = 0;
            for (int i = 0; i < n; i++)
            {
                int choice;
                Console.WriteLine("Nhap 1 de chon nhap vien bien che, nhap 2 de nhap nhan vien hop dong: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    listNhanVien[i] = new NVBC();
                }
                if (choice == 2)
                {
                    listNhanVien[i] = new NVHD();
                }
                listNhanVien[i].Nhap();
            }
            foreach (ILuong nhanVien in listNhanVien)
            {
                nhanVien.XuatThongTin();
                Console.WriteLine("-------------------------------------------");
            }
            //tong luong nhan vien
            foreach (ILuong nhanVien in listNhanVien)
            {
                tongLuong += nhanVien.TinhLuong();
            }
            Console.WriteLine($"Tong luong nhan vien: {tongLuong}");
            Console.WriteLine("-------------------------------------------");

            double min = tongLuong;
            double max = 0;
            //luong cao nhan va thap nhat
            foreach (ILuong nhanVien in listNhanVien)
            {
                double luongNhanvien = nhanVien.TinhLuong();
                if (luongNhanvien > max) max = luongNhanvien;
                if (luongNhanvien < min) min = luongNhanvien;
            }
            //Xuat danh sach nhan vien co luong cao nhat
            Console.WriteLine("Nhan vien co luong cao nhat: ");
            foreach (ILuong nhanVien in listNhanVien)
            {
                double luongNhanVien = nhanVien.TinhLuong();
                if (luongNhanVien == max)
                {
                    nhanVien.XuatThongTin();
                    Console.WriteLine("-------------------------------------------");

                }
            }
            //Xuat danh sach nhan vien co luong thap nhat
            Console.WriteLine("Nhan vien co luong thap nhat ");
            foreach (ILuong nhanVien in listNhanVien)
            {
                double luongNhanVien = nhanVien.TinhLuong();
                if (luongNhanVien == min)
                {
                    nhanVien.XuatThongTin();
                    Console.WriteLine("-------------------------------------------");
                }
            }
        }
    }
}
