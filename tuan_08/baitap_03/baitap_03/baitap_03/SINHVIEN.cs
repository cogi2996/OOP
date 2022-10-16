using System;
using System.Collections.Generic;
using System.Text;

namespace baitap_03
{
    public class SINHVIEN
    {
        private string tenSV;
        private string maSV;
        private LOPHOC lopHoc = new LOPHOC();
        private MONHOC[] mon;
        public string getTenSV()
        {
            return tenSV;
        }
        public void setTenSV(string tenSV)
        {
            this.tenSV = tenSV;
        }
        public string getMaSV()
        {
            return maSV;
        }
        public void setMaSV(string maSV)
        {
            this.maSV = maSV;
        }
        private LOPHOC getLopHoc()
        {
            return lopHoc;
        }
        public void setLopHoc(LOPHOC lopHoc)
        {
            this.lopHoc = lopHoc;
        }
        public MONHOC[] getMon()
        {
            return mon;
        }
        public void setMon(MONHOC[] mon)
        {
            this.mon = mon;
        }
        public void nhapSinhVien()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Nhap ten sinh vien: ");
            setTenSV(Console.ReadLine());
            Console.WriteLine("Nhap ma sinh vien: ");
            setMaSV(Console.ReadLine());
            
            lopHoc.nhapLop();
            Console.WriteLine("Nhap so luong mon hoc: ");
            int size;
            size = int.Parse(Console.ReadLine());
            mon = new MONHOC[size];
            MONHOC.nhapNhieuMonHoc(mon);
        }
        public void xuatSinhVien()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Ho va ten: " + tenSV);
            Console.WriteLine("Ma sinh vien: " + maSV);
            Console.WriteLine("Ten lop: " + lopHoc.getTenLop());
            Console.WriteLine("Khoa: " + lopHoc.getKhoa());

        }
        public static void nhapNhieuSinhVien(SINHVIEN[] sv)
        {
            for (int i = 0; i < sv.Length; i++)
            {
                sv[i] = new SINHVIEN();
                sv[i].nhapSinhVien();
            }
        }
        public static void xuatNhieuSinhVien(SINHVIEN[] sv)
        {
            for(int i = 0;i<sv.Length;i++)
            {
                sv[i].xuatSinhVien();
            }
        }
        public static void xuatBanDiem(SINHVIEN[] sv)
        {
            for(int i= 0; i < sv.Length; i++)
            {
                Console.WriteLine("Phieu bao diem");
                sv[i].xuatSinhVien();
                Console.WriteLine("Bang diem: ");
                Console.WriteLine("{0,15}|{0,15}|{0,15}", "Ten mon", "So tin chi", "Diem");
                MONHOC.xuatNhieuMonHoc(sv[i].mon);
            }
        }
    }
}
