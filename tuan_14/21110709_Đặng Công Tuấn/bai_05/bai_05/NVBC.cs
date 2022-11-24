using System;
using System.Collections.Generic;
using System.Text;

namespace bai_05
{
    public class NVBC : NhanVien, ILuong
    {
        private double luongCanBan = 0;
        private double heSoLuong = 0;
        private double tienPhuCap = 0;
        public NVBC()
        {
        }
        public NVBC(string maSo, string hoTen, int namSinh, double luongCanBan, double heSoLuong, double tienPhuCap) : base(maSo, hoTen, namSinh)
        {
            this.luongCanBan = luongCanBan;
            this.heSoLuong = heSoLuong;
            this.tienPhuCap = tienPhuCap;
        }
        public double LuongCanBan
        {
            get
            {
                return luongCanBan;
            }
            set
            {
                luongCanBan = value;
            }
        }
        public double HeSoLuong
        {
            get
            {
                return heSoLuong;
            }
            set
            {
                heSoLuong = value;
            }
        }
        public double TienPhuCap
        {
            get
            {
                return tienPhuCap;
            }
            set
            {
                tienPhuCap = value;
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
            Console.WriteLine("Nhap he so luong: ");
            heSoLuong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap luong can ban: ");
            luongCanBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tien phu cap: ");
            tienPhuCap = double.Parse(Console.ReadLine());
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"{toString()} - Luong: {TinhLuong()}");
        }

        public double TinhLuong()
        {
            return luongCanBan * heSoLuong + tienPhuCap;
        }
    }
}
