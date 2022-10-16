using System;
using System.Collections.Generic;
using System.Text;

namespace baitap_03
{
    public class LOPHOC
    {
        private string tenLop;
        private int khoa;
        public string TenLop
        {
            get
            {
                return tenLop;
            }
            set
            {
                tenLop = value;
            }
        }
        public int Khoa
        {
            get
            {
                return khoa;
            }
            set
            {
                khoa = value;
            }
        }
        public string getTenLop()
        {
            return tenLop;
        }
        public void setTenLop(string tenLop)
        {
            this.tenLop = tenLop;
        }
        public int getKhoa()
        {
            return khoa;
        }
        public void setKhoa(int khoa)
        {
            this.khoa = khoa;
        }
        public void nhapLop()
        {
            Console.WriteLine("Nhap ten lop: ");
            setTenLop(Console.ReadLine());
            Console.WriteLine("Nhap nien khoa: ");
            setKhoa(int.Parse(Console.ReadLine()));

        }
        public string toString()
        {
            return $"Lop: {tenLop} - Khoa: {khoa}";
        }
    }
}
