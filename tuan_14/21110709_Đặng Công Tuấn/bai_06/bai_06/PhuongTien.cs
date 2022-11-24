using System;
using System.Collections.Generic;
using System.Text;

namespace bai_06
{
    public abstract class PhuongTien
    {
        private string hangSanXuat = "unknow";
        private int namSanXuat = 0;
        private double giaBan = 0;
        private string mau = "unkown";

        public PhuongTien()
        {
        }

        public PhuongTien(string hangSanXuat, int namSanXuat, double giaBan, string mau)
        {
            this.hangSanXuat = hangSanXuat;
            this.namSanXuat = namSanXuat;
            this.giaBan = giaBan;
            this.mau = mau;
        }

        public string HangSanXuat
        {
            get
            {
                return hangSanXuat;
            }
            set
            {
                hangSanXuat = value;
            }
        }
        public int NamSanXuat
        {
            get
            {
                return namSanXuat;
            }
            set
            {
                namSanXuat = value;
            }
        }
        public double GiaBan
        {
            get
            {
                return giaBan;
            }
            set
            {
                giaBan = value;
            }
        }
        public string Mau
        {
            get
            {
                return mau;
            }
            set
            {
                mau = value;
            }

        }

        public string toString()
        {
            return $"Hang: {hangSanXuat} - Nam:{namSanXuat} - Mau: {mau} - Gia: {giaBan} ";
        }
        public virtual void KhoiTao()
        {
            Console.WriteLine("Nhap hang san xuat: ");
            HangSanXuat = Console.ReadLine();
            Console.WriteLine("Nhap nam san xuat: ");
            NamSanXuat = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia ban: ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau sac: ");
            Mau = Console.ReadLine();
        }
        public abstract void XuatThongTin();

    }
}
