using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    public class NhanVienSanXuat :NhanVien
    {
        private double luongCB;
        private int soSP;
        public NhanVienSanXuat() { }
        public double LuongCB
        {
            get
            {
                return luongCB;
            }
            set
            {
                luongCB = value;
            }

        }
        public int SoSP
        {
            get
            {
                return soSP;
            }
            set
            {
                soSP = value;
            }
        }
        public NhanVienSanXuat(string hoTen,DateTime ngaySinh,DiaChi diaChi, double luongCB,int soSP):base(hoTen,ngaySinh,diaChi)
        {
            this.luongCB = luongCB;
            this.soSP = soSP;
        }
        public override void InThongTin()
        {
            Console.WriteLine(base.toString());
            Console.WriteLine("Luong: {0}", TinhLuong());
        }
        public  double TinhLuong()
        {
            double luong = luongCB + soSP * 5000;
            return luong;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap luong co ban: ");
            luongCB = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so san pham: ");
            soSP = int.Parse(Console.ReadLine());
        }
    }
}
