using System;
using System.Collections.Generic;
using System.Text;

namespace bai_04
{
    public class OTO : XE
    {
        private int choNgoi;
        private double trongTai;
        public int getChoNgoi()
        {
            return choNgoi;
        }
        public OTO()
        {
            this.choNgoi = 0;
            trongTai = 0.0;
        }
        public OTO(int choNgoi, double trongTai,string nhanHieu, double gia, int namSX):base(nhanHieu,gia,namSX)
        {
            this.choNgoi = choNgoi;
            this.trongTai = trongTai;
        }
        public void setChoNgoi(int choNgoi)
        {
            this.choNgoi = choNgoi;
        }
        public double getTrongTai()
        {
            return trongTai;
        }
        public void setTrongTai(double trongTai)
        {
            this.trongTai = trongTai;
        }
        public void nhapMotOto()
        {
                Console.WriteLine("Nhap nhan hieu: ");
                base.setNhanHieu(Console.ReadLine());
                Console.WriteLine("Nhap gia: ");
                base.setGia(double.Parse(Console.ReadLine()));
                Console.WriteLine("Nhap nam san xuat: ");
                base.setNamSX(int.Parse(Console.ReadLine()));
                Console.WriteLine("Nhap so cho ngoi: ");
                setChoNgoi(int.Parse(Console.ReadLine()));
                Console.WriteLine("Nhap trong tai: ");
                setTrongTai(double.Parse(Console.ReadLine()));
        }            
        public void xuatMotOto()
        {
                Console.WriteLine("Nhan hieu: ");
                Console.WriteLine(getNhanHieu());
                Console.WriteLine("Nam san xuat: ");
                Console.WriteLine(getNamSX());
                Console.WriteLine("So cho ngoi: ");
                Console.WriteLine(getChoNgoi());
                Console.WriteLine("Trong tai: ");
                Console.WriteLine(getTrongTai());
        }
        public static void nhap(OTO[] oto)
        {
            
            for(int i = 0;i<oto.Length;i++)
            {
                Console.WriteLine("-------------");
                oto[i] = new OTO();
                oto[i].nhapMotOto();
            }
            
        }
        public static void xuat(OTO[] oto)
        {
            foreach(OTO car in oto)
            {
                Console.WriteLine("-------------");
                car.xuatMotOto();
            }
        }
    }
}
