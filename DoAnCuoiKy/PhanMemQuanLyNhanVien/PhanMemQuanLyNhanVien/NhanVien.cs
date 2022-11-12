using System;
using System.Collections.Generic;
using System.Text;

namespace PhanMemQuanLyNhanVien
{
    public abstract class NhanVien
    {
        private static int soLuong;
        private string hoVaTen;
        private string diaChi;
        private int tuoi;
        private DateTime ngaySinh;
        private int dienThoai;
        private string maNhanVien;
        private int kinhNghiem;
        private TienLuong luongCoBan = new TienLuong();
        private DateTime ngayBatDauLam;
        private bool tinhTrangLamViec; 
        public NhanVien()
        {
            soLuong++;
            hoVaTen = "unknown";
            diaChi = "unknown";
            tuoi = 0;
            ngaySinh = new DateTime(1990, 1, 1);
            dienThoai = 0;
            maNhanVien = "unknown";
            kinhNghiem = 0;
            luongCoBan = new TienLuong();
            ngayBatDauLam = new DateTime(1990, 1, 1);
            tinhTrangLamViec = false;
        }
        public NhanVien(string hoVaTen, string diaChi, int tuoi, int  ngay, int thang, int nam, int dienThoai, string maNhanVien, int kinhNghiem, double luongCoBan, DateTime ngayBatDauLam, bool tinhTrangLamViec)
        {
            soLuong++;
            this.hoVaTen = hoVaTen;
            this.diaChi = diaChi;
            this.tuoi = tuoi;
            this.ngaySinh = new DateTime(nam, thang, ngay);
            this.dienThoai = dienThoai;
            this.maNhanVien = maNhanVien;
            this.kinhNghiem = kinhNghiem;
            this.luongCoBan.setTienLuong(luongCoBan);
            this.ngayBatDauLam = ngayBatDauLam;
            this.tinhTrangLamViec = tinhTrangLamViec;
        }
        public void setHoVaTen(string hoVaTen)
        {
            this.hoVaTen = hoVaTen;
        }
        public string getHoVaTen()
        {
            return hoVaTen;
        }
        public void setDiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }
        public string getDiaChi()
        {
            return diaChi;
        }
        public void setTuoi(int tuoi)
        {
            this.tuoi = tuoi;
        }
        public int getTuoi()
        {
            return tuoi;
        }
        public void setNgaySinh(DateTime ngaySinh)
        {
            this.ngaySinh = ngaySinh;
        }
        public DateTime getNgaySinh()
        {
            return ngaySinh;
        }
        public void setDienThoai (int dienThoai )
        {
            this.dienThoai = dienThoai;
        }
        public int getDienThoai()
        {
            return dienThoai;
        }
        public void setMaNhanVien(string maNhanVien)
        {
            this.maNhanVien = maNhanVien;
        }
        public string getMaNhanVien()
        {
            return maNhanVien;
        }
        public void setKinhNghiem(int kinhNghiem)
        {
            this.kinhNghiem = kinhNghiem;     
        }
        public int getKinhNghiem()
        {
            return kinhNghiem;
        }
        public void setLuongCoBan(TienLuong luongCoBan)
        {
            this.luongCoBan = luongCoBan;
        }
        public TienLuong getLuongCoBan()
        {
            return luongCoBan;
        }
        public void setNgayBatDauLam(DateTime ngayBatDauLam)
        {
            this.ngayBatDauLam = ngayBatDauLam;
        }
        public DateTime getNgayBatDauLam ()
        {
            return ngayBatDauLam;
        }
        public void setTinhTrang(bool tinhTrangLamViec)
        {
            this.tinhTrangLamViec = tinhTrangLamViec; 
        }
        public virtual string toString ()
        {
            string kq = $"Ten:{hoVaTen}\nDia chi:{diaChi}\nTuoi:{tuoi}\nNgay sinh:{ngaySinh.Day}/{ngaySinh.Month}/{ngaySinh.Year}\n" +
                $"So dien thoai:{dienThoai}\nKinh nghiem:{kinhNghiem}\nNgay bat dau lam:{ngayBatDauLam.Day}/{ngayBatDauLam.Month}" +
                $"/{ngayBatDauLam.Year}\nTinh trang lam viec:{((tinhTrangLamViec == true) ? " Con lam" : " Da nghi")}\nLuong co ban:{luongCoBan.toString()}";
            return kq;            
        }
        public static void InThongTinNhanVien (NhanVien[] nhanViens)
        {
            foreach(NhanVien nhanVien in nhanViens)
            {
                Console.WriteLine(nhanVien.toString());
            }
        }
        
        public virtual void NhapThongtin()
        {
            Console.Write("Ho va ten: ");
            hoVaTen = Console.ReadLine();
            Console.Write("\nDia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("\nTuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Ngay sinh: ");
            int day, month, year;
            day = int.Parse(Console.ReadLine()); //AddDays
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            ngaySinh = new DateTime(year, month, day);
            Console.Write("\nSo dien thoai: ");
            dienThoai = int.Parse(Console.ReadLine());
            Console.Write("\nNam kinh nghiem: ");
            kinhNghiem = int.Parse(Console.ReadLine());
            Console.WriteLine("Ngay bat dau lam:");
            day = int.Parse(Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            ngayBatDauLam = new DateTime(year, month, day);
            Console.Write("\nTinh trang lam viec: ");
            tinhTrangLamViec = bool.Parse(Console.ReadLine());
            Console.WriteLine("\nLuong co ban: ");
            double luongCoBan = double.Parse(Console.ReadLine());
            this.luongCoBan = new TienLuong(luongCoBan);
        }
        public abstract TienLuong TinhLuong();
        
    }
}
