using System;
using System.Collections.Generic;
using System.Text;

namespace PhanMemQuanLyNhanVien
{
    public class LapTrinhVien:NhanVien
    {
        private static int soLuongLapTrinhVien;
        private int soGioLamThem;
        private TienLuong luongNgoaiGio = new TienLuong();
        public LapTrinhVien()
        {
            soLuongLapTrinhVien++;
            setLoaiNhanVien(0);
            soGioLamThem = 0;
        }
        public LapTrinhVien(int soGioLamThem, double luongNgoaiGio, string hoVaTen, string diaChi, int tuoi, int ngay,int thang, int nam, string dienThoai, string maNhanVien, int kinhNghiem, double luongCoBan, DateTime ngayBatDauLam, bool tinhTrangLamViec,int loaiNhanVien):base (hoVaTen, diaChi,tuoi,ngay, thang, nam,dienThoai,maNhanVien,kinhNghiem,luongCoBan,ngayBatDauLam,tinhTrangLamViec,loaiNhanVien)
        {
            this.setLoaiNhanVien(0) ;
            soLuongLapTrinhVien++;
            this.soGioLamThem = soGioLamThem; 
            this.luongNgoaiGio = new TienLuong(luongNgoaiGio);
        }
        public static int getSoLuongLapTrinhVien()
        {
            return soLuongLapTrinhVien;
        }
        public int getSoGioLamThem()
        {
            return soGioLamThem;
        }
        public void setSoGioLamThem(int soGioLamThem)
        {
            this.soGioLamThem = soGioLamThem;
        }
        public TienLuong getLuongNgoaiGio()
        {
            return luongNgoaiGio;
        }
        public  void setLuongNgoaiGio(TienLuong luongNgoaiGio)
        {
            this.luongNgoaiGio = luongNgoaiGio;
        }
        public override string toString()
        {
            string kq =base.toString() +  $"\nSo luong lap trinh vien: {soLuongLapTrinhVien}\nSo gio lam them: {soGioLamThem}\nLuong ngoai gio:{luongNgoaiGio.toString()}";
            return kq;
        }
        public override void NhapThongtin()
        {
            base.NhapThongtin();
            Console.Write("\nSo gio lam them:");
            soGioLamThem = int.Parse(Console.ReadLine());
            Console.Write("\nLuong ngoai gio: ");
            double luongNgoaiGio = double.Parse(Console.ReadLine());
            this.luongNgoaiGio = new TienLuong(luongNgoaiGio);
        }
        public override TienLuong TinhLuong()
        {
            TienLuong luong = new TienLuong();
            luong = base.getLuongCoBan() + luongNgoaiGio*soGioLamThem;
            return luong;
        }
        public override void SuaThongTin(ref int choice,string thongTinLapTrinh)
        {
                Console.Clear();
                base.SuaThongTin(ref choice, thongTinLapTrinh);
                if(choice == 11)
                {
                    Console.Write("So gio lam them moi: ");
                    setSoGioLamThem(int.Parse(Console.ReadLine()));
                }
                else if (choice == 12)
                {
                    Console.WriteLine("Luong ngoai gio moi: ");
                    setLuongNgoaiGio(new TienLuong(double.Parse(Console.ReadLine())));
                }
        }
    }
}
