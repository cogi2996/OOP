using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_04
{
    public class Computer
    {
        private string loaiMay, noiSanXuat;
        private static int soLuongMay=0;
        private int thoiGian;
        public static void SetSoLuongMay(int soLuong)
        {
            soLuongMay = soLuong;
        }
        public static int GetSoLuongMay()
        {
            return soLuongMay;
        }
        public string LoaiMay
        {
            get
            {
                return loaiMay;
            }
            set
            {
                loaiMay = value;
            }
        }
        public string NoiSanXuat
        {
            get
            {
                return noiSanXuat;
            }
            set
            {
                noiSanXuat = value;
            }
        }
        public int ThoiGian
        {
            get
            {
                return thoiGian;
            }
            set
            {
                thoiGian = value;
            }
        }
        public Computer()
        {
            loaiMay = "unknown";
            noiSanXuat = "unknown";
            thoiGian = 0;
        }
        public Computer (string loaiMay,string noiSanXuat,int thoiGian)
        {
            this.loaiMay = loaiMay;
            this.noiSanXuat = noiSanXuat;
            this.thoiGian = thoiGian;
        }

        public string toString()
        {
            string kq;
            kq = $"loai may: {loaiMay}, noi san xuat: {noiSanXuat}, thoi gian: {thoiGian}";
            return kq;
        }
    }
}
