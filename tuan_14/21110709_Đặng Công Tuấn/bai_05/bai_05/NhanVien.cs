using System;
using System.Collections.Generic;
using System.Text;

namespace bai_05
{
    public class NhanVien
    {
        private string maSo = "unknow";
        private string hoTen = "unknow";
        private int namSinh = 1960;
        public NhanVien()
        {
        }
        public NhanVien(string maSo, string hoTen, int namSinh)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }
        public string MaSo
        {
            get
            {
                return maSo;
            }
            set
            {
                maSo = value;
            }
        }
        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }
        public int NamSinh
        {
            get
            {
                return namSinh;
            }
            set
            {
                namSinh = value;
            }
        }
        public string toString()
        {
            return $"{maSo} - Ten:  {hoTen} - Nam sinh: {namSinh} ";
        }
    }
}
