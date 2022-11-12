using System;
using System.Collections.Generic;
using System.Text;

namespace bai4
{
    public class NVHD:NhanVien
    {
        private double tienCong = 0.0;
        private int soGioLam = 0;
        public NVHD ()
        {

        }
        public NVHD (double tienCong,int soGioLam,string maSo, string hoTen, int namSinh):base(maSo,hoTen,namSinh)
        {
            this.tienCong = tienCong;
            this.soGioLam = soGioLam;
        }
        public void setTienCong(double tienCong)
        {
            this.tienCong = tienCong;
        }
        public double getTienCong()
        {
            return tienCong;
        }
        public void setSoGioLam(int soGioLam)
        {
            this.soGioLam = soGioLam;
        }
        public int getSoGioLam()
        {
            return soGioLam;
        }
        public override double TinhLuong()
        {
            return tienCong * soGioLam;
        }
        public override string toString()
        {
            return base.toString() + $"\nTien cong / hour : {tienCong}\nSo gio lam viec / month: {soGioLam}\nLuong: {Math.Round(TinhLuong(), 3).ToString()}";
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("\nTien cong / hour : ");
            tienCong = double.Parse(Console.ReadLine());
            Console.Write("\nSo gio lam viec / month");
            soGioLam = int.Parse(Console.ReadLine());
        }
        public override void xuatThongTin()
        {
            Console.WriteLine(toString());
        }
    }
}
