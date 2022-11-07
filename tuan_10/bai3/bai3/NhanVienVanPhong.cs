using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    public class NhanVienVanPhong : NhanVien
    {
        private int soNgayLamViec;
        public NhanVienVanPhong() { }
        public NhanVienVanPhong(string hoTen, DateTime ngaySinh,DiaChi diaChi,int soNgayLamViec) : base(hoTen,ngaySinh,diaChi)
        {
            this.soNgayLamViec = soNgayLamViec;
        }
        public int SoNgayLamViec
        {
            get
            {
                return soNgayLamViec;
            }
            set
            {
                soNgayLamViec = value;
            }
        }
        public override void InThongTin()
        {
            Console.WriteLine(base.toString());
            Console.WriteLine("Luong: {0}", TinhLuong());
        }
        public double TinhLuong()
        {
            double luong = soNgayLamViec*100000;
            return luong;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("So ngay lam viec: ");
            soNgayLamViec= int.Parse(Console.ReadLine());
        }
    }
}
