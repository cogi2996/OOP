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
        public override string Print()
        {
            return base.Print()+"\n"+
            $"Ngay lam viec: {SoNgayLamViec.ToString()}"+'\n'
            +$"Luong thang: {string.Format("{0:#,##0.00}", TinhLuong())}";
        }
        public override double TinhLuong()
        {
            double luong = soNgayLamViec*100000;
            return luong;
        }
      
    }
}
