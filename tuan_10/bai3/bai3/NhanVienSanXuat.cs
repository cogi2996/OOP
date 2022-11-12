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
        public override string Print()
        {
            return base.Print() + "\n"+$"Luong co ban: {string.Format("{0:#,##0.00}", luongCB)}" +'\n'
           + $"So san pham: {soSP}" +"\n"
            +$"Luong thang: {string.Format("{0:#,##0.00}", TinhLuong())}";
        }
        public  override double TinhLuong()
        {
            double luong = luongCB + soSP * 5000;
            return luong;
        }
    
    }
}
