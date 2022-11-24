using System;
using System.Collections.Generic;
using System.Text;

namespace bai_06
{
    public class XeMay : PhuongTien, IQuanLy
    {
        private double congSuat = 0;

        public XeMay()
        {
        }
        public XeMay(string hangSanXuat, int namSanXuat, double giaBan, string mau, double congSuat) : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            this.congSuat = congSuat;
        }

        public double CongSuat
        {
            get
            {
                return congSuat;
            }
            set
            {
                congSuat = value;
            }
        }

        public override void KhoiTao()
        {
            base.KhoiTao();
            Console.WriteLine("Nhap cong suat: ");
            congSuat = double.Parse(Console.ReadLine());

        }
        public override void XuatThongTin()
        {
            Console.WriteLine($"Xe may co cong suat {congSuat}, " + toString());
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
