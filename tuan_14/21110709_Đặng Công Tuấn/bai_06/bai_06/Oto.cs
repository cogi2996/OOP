using System;
using System.Collections.Generic;
using System.Text;

namespace bai_06
{
    public class Oto : PhuongTien, IQuanLy
    {
        private int soChoNgoi = 0;
        private string kieuDongCo = "unknown";

        public Oto()
        {
        }
        public Oto(string hangSanXuat, int namSanXuat, double giaBan, string mau, int soChoNgoi, string kieuDongCo) : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            this.soChoNgoi = soChoNgoi;
            this.kieuDongCo = kieuDongCo;
        }
        public int SoChoNgoi
        {
            get
            {
                return soChoNgoi;
            }
            set
            {
                soChoNgoi = value;
            }
        }
        public string KieuDongCo
        {
            get
            {
                return kieuDongCo;
            }
            set
            {
                kieuDongCo = value;
            }
        }
        public override void KhoiTao()
        {
            base.KhoiTao();
            Console.WriteLine("Nhap so cho ngoi: ");
            soChoNgoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap kieu dong co: ");
            kieuDongCo = Console.ReadLine();
        }
        //Methods
        public override void XuatThongTin()
        {
            Console.WriteLine($"Oto co {soChoNgoi} cho ngoi, kieu dong co {kieuDongCo}, " + toString());
        }
        public bool KiemTraMau(string mau)
        {
            return Mau == mau;
        }
        public bool KiemTraNam(int x)
        {
            return NamSanXuat < x;
        }
    }
}
