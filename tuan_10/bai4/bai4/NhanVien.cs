using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace bai4
{
    public abstract class NhanVien
    {
        private string maSo;
        private string hoTen;
        private int namSinh;
        public void setMaSo(string maSo)
        {
            this.maSo = maSo;
        }
        public string getMaSo()
        {
            return maSo;
        }
        public void setHoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public string getHoTen()
        {
            return hoTen;
        }
        public void setNamSinh(int namSinh)
        {
            this.namSinh = namSinh;
        }
        public NhanVien()
        {
            maSo = "0";
            hoTen = "unknown";
            namSinh = 1990;
        }
        public NhanVien(string maSo,string hoTen, int namSinh)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }
        public abstract double TinhLuong();
        public virtual string toString()
        {
            string kq = $"Ma so: {maSo}\nHo va ten: {hoTen}\nNam sinh: {namSinh}";
            return kq;
        }
        public virtual void NhapThongTin()
        {
            Console.Write("Ho va ten: ");
            hoTen = Console.ReadLine();
            Console.Write("\nMa so: ");
            maSo = Console.ReadLine();
            Console.Write("\nNam Sinh: ");
            namSinh = int.Parse(Console.ReadLine());
        }
        public virtual void xuatThongTin()
        {
            Console.Write(toString());

        }
       
    }
}
