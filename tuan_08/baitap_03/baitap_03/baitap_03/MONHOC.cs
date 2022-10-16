using System;
using System.Collections.Generic;
using System.Text;

namespace baitap_03
{
    public class MONHOC
    {
        private string mon;
        private int tinChi;
        private double diem;

        public double Diem
        {
            get
            {
                return this.diem;
            }
            set
            {
                diem = value;
            }
        }

        public int TinChi
        {
            get 
            {
                return tinChi ;
            }
            set
            {
                tinChi= value;
            }
        }

        public string Mon
        {
            get 
            {
                return mon;
            }
            set
            {
                mon = value;
            }
        }
        public void nhapMonHoc()
        {
           
            Console.WriteLine("+Ten mon: ");
            Mon = Console.ReadLine();
            Console.WriteLine("+Tin chi: ");
            TinChi = int.Parse(Console.ReadLine());
            Console.WriteLine("+Nhap diem: ");
            Diem = double.Parse(Console.ReadLine());
        }
        public void xuatMonHoc()
        {
            Console.WriteLine("+Ten mon: " + Mon);
            Console.WriteLine("+Tin chi: " + tinChi);
            Console.WriteLine("+Nhap diem: " + diem);
        }
        public static void nhapNhieuMonHoc(MONHOC[] mon)
        {
            
            for(int i = 0; i < mon.Length; i++)
            {
                mon[i] = new MONHOC();
                mon[i].nhapMonHoc();
            }
        }
        public static void xuatNhieuMonHoc(MONHOC[] mon)
        {
            for (int i = 0; i < mon.Length; i++)
            {
                mon[i].xuatMonHoc();
            }
        }
        public string toString()
        {
            return $"{mon} - {tinChi} - {diem}";
        }
    }
}
