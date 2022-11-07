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
        abstract public void InThongTin();
        public string toString()
        {
            return $"Ho ten: {hoTen}\nNgay sinh: {ngaySinh.Day} - {ngaySinh.Month} - {ngaySinh.Year}\ndia chi: {diaChi.toString()} ";
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ho va ten: ");
            hoTen = Console.ReadLine();
            int date, month, year;
            Console.WriteLine("Nhap ngay - thang - nam sinh");
            date = int.Parse(Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            ngaySinh = new DateTime(year, month, date);
            diaChi = new DiaChi();
            diaChi.NhapDiaChi();
            
        }
    }
}
