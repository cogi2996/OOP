using System;
using System.Collections.Generic;
using System.Text;

namespace PhanMemQuanLyNhanVien
{
    public  class TienLuong
    {
        private double tien;
        public TienLuong()
        {
            tien = 0.0;
        }
        public double Tien
        {
            get
            {
                return tien;
            }
            set
            {
                tien = value;
            }
        }
        public TienLuong(double tien)
        {
            this.tien = tien;
        }

        public void setTienLuong(double tien)
        {
            this.tien = tien;
        }
        public double getTienLuong()
        {
            return tien;
        }
        public double getTienLuongDouble()
        {
            return tien;
        }
        public string toString()
        {
            return string.Format("{0:#,##0.00}", tien);
        }
        public static TienLuong operator+ (TienLuong a,TienLuong b)
        {
            return new TienLuong(a.tien + b.tien);
        }
        public static TienLuong operator +(TienLuong a, int b)
        {
            return new TienLuong(a.tien + b);
        }
        public static TienLuong operator *(TienLuong a, int b)
        {
            return new TienLuong(a.tien * b);
        }
        public static TienLuong operator *(TienLuong a, double b)
        {
            return new TienLuong(a.tien * b);
        }
        public static int soSanhTien(TienLuong a, TienLuong b)
        {
            if (a.tien == b.tien)
                return 0;
            else if (a.tien > b.tien)
                return 1;
            else
                return -1;
        }

    }
}
