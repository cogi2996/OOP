using System;
using System.Collections.Generic;
using System.Text;

namespace baitap_02
{
    public class KhachHang
    {
        private string hovaten;
        private string sonha;
        private BienLai masocongto;
        public KhachHang()
        {

        }
        public KhachHang(string hovaten, string sonha,BienLai masocongto)
        {
            this.hovaten = hovaten;
            this.sonha = sonha;
            this.masocongto= masocongto;
        }
        public string Hovaten
        {
            get
            {
                return hovaten;
            }
            set
            {
                this.hovaten = value;
            }
        }
        public string Sonha
        {
            get
            {
                return sonha;
            }
            set
            {
                this.sonha = value;
            }
        }
        public BienLai Masocongto
        {
            get
            {
                
                return masocongto;
            }
            set
            {
                this.masocongto = value;
            }
        }
        public void NhapThongTin()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Nhap ten khach hang");
            hovaten = Console.ReadLine();
            Console.WriteLine("Nhap so nha:");
            sonha = Console.ReadLine();
            Console.WriteLine("Nhap ma so cong to cu: ");
            masocongto = new BienLai();
            masocongto.Socu = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma so cong to moi: ");
            masocongto.Somoi = double.Parse(Console.ReadLine());
        }
        public void XuatThongTin()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ten:{0}", hovaten);
            Console.WriteLine("dia chi nha: {0}", sonha);
            Console.WriteLine(" - So cong to : ");
            Console.WriteLine("+So cu: {0}", masocongto.Socu);
            Console.WriteLine("+So moi: {0}", masocongto.Somoi);
            Console.WriteLine("--> So tien can tra : {0}", masocongto.tinhTien());

        }
        public void NhapBienLai(KhachHang[] cus)
        {
            for(int i = 0; i < cus.Length; i++)
            {
                cus[i] = new KhachHang();
                cus[i].NhapThongTin();
            }
        }
        public void XuatBienLai(KhachHang[] cus)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Cac bien lai da nhap: ");
            for(int i = 0; i < cus.Length; i++)
            {
                cus[i].XuatThongTin();
            }
        }
        public string toString()
        {
            return $"Ten khach hang:{hovaten}, dia chi: {sonha}, bien lai:[so cu:{masocongto.Socu}, so moi:{masocongto.Somoi}]";
        }
        public static void xuatTongTienBienLai(KhachHang[] customer)
        {
            double totalBill = BienLai.tongTien(customer);
            Console.WriteLine("Tong tien cac bien lai la: {0}", totalBill);
            ;
        }
    }
}
