using System;
using System.Collections.Generic;
using System.Text;

namespace baitap_02
{
    public class BienLai
    {
        private double socu = 0.0;
        private double somoi =0.0;
        public double Socu
        {
            get { return socu; }
            set { this.socu = value; }
        }
        public double Somoi
        {
            get
            {
                return somoi;
            }
            set
            {
                this.somoi = value;
            }
        }
        public BienLai()
        {

        }
        public BienLai(double socu,double somoi)
        {
            this.socu = socu;
            this.somoi = somoi;
        }
        public double getSocu()
        {
            return socu;
        }
        public void setSocu(double socu)
        {
            this.socu = socu;
        }
        public double getSomoi()
        {
            return somoi;
        }
        public void setSomoi(double somoi)
        {
            this.somoi = somoi;
        }
        public double tinhTien()
        {
            return (getSomoi() - getSocu()) * 750;
        }
        public static double tongTien(KhachHang[] customer)
        {
            double sum = 0;
            foreach(KhachHang cus in customer)
            {
                sum = sum +  cus.Masocongto.tinhTien();
            }
            return sum;
        }
        
    }
}
