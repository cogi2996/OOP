using System;
using System.Collections.Generic;
using System.Text;

namespace bai_04
{
    public class XE
    {
        private string nhanHieu;
        private double gia;
        private int namSX;
        public XE()
        {
            nhanHieu = "";
            gia = 0.0;
            namSX = 2022;
        }
        public XE(string nhanHieu, double gia, int namSX)
        {
            this.nhanHieu = nhanHieu;
            this.gia = gia;
            this.namSX = namSX;
        }
        public string getNhanHieu()
        {
            return nhanHieu;
        }
        public void setNhanHieu(string nhanHieu)
        {
            this.nhanHieu = nhanHieu;
        }
        public double getGia()
        {
            return gia;
        }
        public void setGia(double gia)
        {
            this.gia = gia;
        }
        public int getNamSX()
        {
            return namSX;
        }
        public void setNamSX(int namSX)
        {
            this.namSX = namSX;
        }


    }
}
