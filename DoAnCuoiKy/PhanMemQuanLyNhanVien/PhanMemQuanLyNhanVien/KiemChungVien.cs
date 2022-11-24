using System;
using System.Collections.Generic;
using System.Text;

namespace PhanMemQuanLyNhanVien
{
    public class KiemChungVien : NhanVien
    {
        private static int soLuongKiemChungVien;
        private int soLoi;
        private TienLuong tienThuong = new TienLuong();
        public KiemChungVien()
        {
            soLuongKiemChungVien++;
            this.setLoaiNhanVien(0);
            setLoaiNhanVien(1);
            soLoi = 0;
        }
        public  KiemChungVien(int soLoi,double tienThuong, string hoVaTen, string diaChi, int tuoi, int ngay, int thang, int nam, string dienThoai, string maNhanVien, int kinhNghiem, double luongCoBan, DateTime ngayBatDauLam, bool tinhTrangLamViec,int loaiNhanVien) : base(hoVaTen, diaChi, tuoi, ngay, thang, nam, dienThoai, maNhanVien, kinhNghiem, luongCoBan, ngayBatDauLam, tinhTrangLamViec,loaiNhanVien)
        {
            this.setLoaiNhanVien(1);
            soLuongKiemChungVien++;
            this.soLoi = soLoi;
            this.tienThuong = new TienLuong(tienThuong);
        }
        public void setSoLoi(int soLoi)
        {
            this.soLoi = soLoi;
        }
        public int getSoLoi()
        {
            return soLoi;
        }
        public void setTienThuong(double tienThuong)
        {
            this.tienThuong = new TienLuong(tienThuong);
        }
        public TienLuong getTienThuong()
        {
            return tienThuong;
        }

        public static int getSoLuongKiemChungVien()
        {
            return soLuongKiemChungVien;
        }
        public override string toString()
        {
            return base.toString()+$"\nSo loi: {soLoi}\nTien thuong: {tienThuong.toString()}\nTien luong: {TinhLuong().toString()}";
        }
        public override void NhapThongtin()
        {
            base.NhapThongtin();
            Console.WriteLine("So loi:");
            soLoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Tien thuong: ");
            setTienThuong(double.Parse(Console.ReadLine()));

        }
        public void InThongTin()
        {
            Console.WriteLine(toString());
        }
        public override TienLuong TinhLuong()
        {
            return base.getLuongCoBan() + (tienThuong*soLoi);
        }
        public override void SuaThongTin(ref int choice, string thongTinLapTrinh)
        {
            Console.Clear();
            base.SuaThongTin(ref choice, thongTinLapTrinh);
            if (choice == 11)
            {
                Console.Write("So loi moi: ");
                setSoLoi(int.Parse(Console.ReadLine()));
            }
            else if (choice == 12)
            {
                Console.WriteLine("Tien thuong moi: ");
                setTienThuong(double.Parse(Console.ReadLine()));
            }
        }
    }
}
