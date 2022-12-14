using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    public class DiaChi
    {
        private string soNha;
        private string tenDuong;
        private string tenQuan;
        private string thanhPho;
        public DiaChi() { }
        public DiaChi(string soNha, string tenDuong,string tenQuan,string thanhPho)
        {
            this.soNha = soNha;
            this.tenDuong = tenDuong;
            this.tenQuan = tenQuan;
            this.thanhPho = thanhPho;
        }
        public string SoNha
        {
            get
            {
                return soNha;
            }
            set
            {
                soNha = value;
            }
        }
        public string TenDuong
        {
            get
            {
                return tenDuong;
            }
            set
            {
                tenDuong = value;
            }
        }
        public string TenQuan
        {
            get
            {
                return tenQuan;
            }
            set
            {
                tenQuan = value;
            }
        }
        public string ThanhPho
        {
            get
            {
                return thanhPho;
            }
            set
            {
                thanhPho = value;
            }
        }
        public string toString()
        {
            return $"+So nha: {soNha}\n+Ten quan: {tenQuan}\n+Ten duong: {tenDuong}\n+Ten thanh pho: {thanhPho}";
        }
       

    }
}
