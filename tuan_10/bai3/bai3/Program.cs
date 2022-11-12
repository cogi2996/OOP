using System;
using System.Collections;
namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong nhan vien cong ty: ");
            int n = int.Parse(Console.ReadLine());
            NhanVien[] listNV = new NhanVien[n];
            
            static void NhapDanhSachNV(NhanVien[] arr)
            {
                Console.WriteLine("Nhap 1: De luu nhan vien san xuat");
                Console.WriteLine("Nhap 2: De luu nhan vien van phong");
                int chon;
                string soNha, tenDuong, tenQuan, thanhPho;
                string hoTen;
                int ngay, thang, nam;
                double luongCB;
                int soSP;
                int soNgay;
                for(int i = 0;i<arr.Length;i++)
                {
                    Console.WriteLine("Nhap loai nhan vien: ");
                    chon = int.Parse(Console.ReadLine());
                    // nhap 1 nhan vien arr[i]
                    Console.WriteLine("Nhap so nha: ");
                    soNha = Console.ReadLine();
                    Console.WriteLine("Ten duong: ");
                    tenDuong = Console.ReadLine();
                    Console.WriteLine("Ten quan: ");
                    tenQuan = Console.ReadLine();
                    Console.WriteLine("Ten thanh pho: ");
                    thanhPho = Console.ReadLine();
                    Console.WriteLine("Nhap ho ten: ");
                    hoTen = Console.ReadLine();
                    Console.WriteLine("Nhap ngay,thang,nam sinh: ");
                    ngay = int.Parse(Console.ReadLine());
                    thang = int.Parse(Console.ReadLine());
                    nam = int.Parse(Console.ReadLine());
                    if(chon == 1 )
                    {
                        Console.WriteLine("Nhap luong co ban: ");
                        luongCB = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so san pham: ");
                        soSP = int.Parse(Console.ReadLine());
                        arr[i] = new NhanVienSanXuat(hoTen, new DateTime(nam, thang, ngay), new DiaChi(soNha, tenDuong, tenQuan, thanhPho), luongCB, soSP);

                        
                    }
                    else
                    {
                        Console.WriteLine("Nhap so ngay lam viec");
                        soNgay = int.Parse(Console.ReadLine());
                        arr[i] = new NhanVienVanPhong(hoTen, new DateTime(nam, thang, ngay), new DiaChi(soNha, tenDuong, tenQuan, thanhPho),  soNgay);
                    }
                }
            }
            static void XuatDanhSachNV(NhanVien[] arr)
            {
                Console.WriteLine("==>Thong tin toan bo nhan vien cong ty: ");
                for(int i= 0;i<arr.Length;i++)
                {
                    Console.WriteLine(arr[i].Print()+'\n');
                }
            }
            static double TinhTongLuong(NhanVien[] arr)
            {
                double tong = 0;
                for(int i = 0;i<arr.Length;i++)
                {
                    tong += arr[i].TinhLuong();
                }
                return tong;
            }
            static void LietKeNVDenTuoiVeHuu(NhanVien[] arr)
            {
                Console.WriteLine("==> Danh sach nhan vien den tuoi ve huu trong nam nay: ");
                for( int i =0;i<arr.Length;i++)
                {
                    if(arr[i].TinhTuoi() == 60)
                    {
                        arr[i].Print();
                        Console.WriteLine();
                    }    
                }
            }
            NhapDanhSachNV(listNV);
            XuatDanhSachNV(listNV);
            LietKeNVDenTuoiVeHuu(listNV);
        }

    } 
}
