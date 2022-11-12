using System;
using System.Collections.Generic;
using System.Text;

namespace bai4
{
    public class NVBC :NhanVien
    {
        private double luongCB = 0.0;
        private double heSoLuong = 1;
        private double tienPC = 0;
        public NVBC()
        {
            
        }
        public NVBC(double luongCB,double heSoLuong,double tienPC,string maSo, string hoTen,int namSinh):base(maSo,hoTen,namSinh)
        {
            this.luongCB = luongCB;
            this.heSoLuong = heSoLuong;
            this.tienPC = tienPC;
        }
        public void setLuongCB(double luongCB)
        {
            this.luongCB = luongCB;
        }
        public double getLuongCB()
        {
            return luongCB;
        }
        public void setHeSoLuong(double heSoLuong)
        {
            this.heSoLuong = heSoLuong;
        }
        public double getHeSoLuong()
        {
            return heSoLuong;
        }
        public void setTienPC(double tienPC)
        {
            this.tienPC = tienPC;
        }
        public double getTienPhuCap()
        {
            return tienPC;
        }
        public override double TinhLuong()
        {
            return luongCB * heSoLuong * tienPC;
        }
        public override string toString()
        {
            return base.toString() + $"\nLuong co ban: {luongCB}\nTien phu cap:{tienPC}\nHe so luong:{heSoLuong}\nTien luong: {Math.Round(TinhLuong(),3).ToString()}";
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("\nLuong co ban: ");
            luongCB = double.Parse(Console.ReadLine());
            Console.Write("\nTien phu cap: ");
            tienPC = double.Parse(Console.ReadLine());
        }
        public override void xuatThongTin()
        {
            Console.WriteLine(toString());
        }

    }
}
