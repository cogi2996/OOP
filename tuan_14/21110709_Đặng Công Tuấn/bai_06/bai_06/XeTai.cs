using System;
using System.Collections.Generic;
using System.Text;

namespace bai_06
{
    public class XeTai : PhuongTien, IQuanLy
    {
        private double trongTai;

        public XeTai()
        {
            trongTai = 0;
        }
        public XeTai(string hangSanXuat, int namSanXuat, double giaBan, string mau, double trongTai) : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            this.trongTai = trongTai;
        }
        public double TrongTai
        {
            get
            {
                return trongTai;
            }
            set
            {
                trongTai = value;
            }
        }
        public override void KhoiTao()
        {
            base.KhoiTao();
            Console.WriteLine("Nhap trong tai: ");
            trongTai = double.Parse(Console.ReadLine());

        }
        public override void XuatThongTin()
        {
            Console.WriteLine($"Xe tai co trong tai {trongTai}, " + toString());
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
