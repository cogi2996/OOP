using System;
using System.Collections.Generic;
using System.Text;

namespace bai_05
{
    public class NVHD : NhanVien, ILuong
    {
        private double tienCong = 0;
        private double soGio = 0;
        public NVHD()
        {

        }
        public NVHD(string maSo, string hoTen, int namSinh, double tienCong, double soGio) : base(maSo, hoTen, namSinh)
        {
            this.tienCong = tienCong;
            this.soGio = soGio;
        }
        public double TienCong
        {
            get
            {
                return tienCong;
            }
            set
            {
                tienCong = value;
            }
        }
        public double SoGio
        {
            get
            {
                return soGio;
            }
            set
            {
                soGio = value;
            }
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma so: ");
            MaSo = Console.ReadLine();
            Console.WriteLine("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tien cong: ");
            tienCong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so gio: ");
            SoGio = double.Parse(Console.ReadLine());
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"{toString()} - Luong: {TinhLuong()}");
        }

        public double TinhLuong()
        {
            return tienCong * soGio;
        }
    }
}
