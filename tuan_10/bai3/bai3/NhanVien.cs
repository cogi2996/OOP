using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    public abstract class NhanVien
    {
        private string hoTen;
        private DateTime ngaySinh;
        private DiaChi diaChi;
        public NhanVien() { }
        public NhanVien(string hoTen, DateTime ngaySinh,DiaChi  diaChi)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
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
        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;

            }
            set
            {
                ngaySinh = value;
            }
        }
        public DiaChi DiaChiNha
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public int TinhTuoi()
        {
            return DateTime.Now.Year - ngaySinh.Year;
        }

        public virtual string  Print()
        {
                return $"Ho va ten: {hoTen}"+'\n'
                + $"Ngay Sinh: {ngaySinh.Day}/{ngaySinh.Month}/{ngaySinh.Year}"+'\n'
            +$"Dia chi:\n{diaChi.toString()}";
        }

        public abstract double TinhLuong();
     
    }
}
