using System;
using System.Collections.Generic;
using System.Text;

namespace PhanMemQuanLyNhanVien
{
    class Admin
    {
        private string hoTen ="unknown";
        private string email ="unknown";
        private string dienThoai ="unknown";
        private string matKhau = "unknown" ;
        public Admin() { }
        public Admin(string hoTen, string email, string dienThoai,string matKhau)
        {
            this.hoTen = hoTen;
            this.email = email;
            this.dienThoai = dienThoai;
            this.matKhau = matKhau;
        }
        public void setHoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public string getHoTen()
        {
            return hoTen;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string  getEmail()
        {
            return email;
        }
        public void setDienThoai(string dienThoai)
        {
            this.dienThoai = dienThoai;
        }
        public string getDienThoai()
        {
            return dienThoai;
        }
        public void  setMatKhau(string matKhau)
        {
            this.matKhau = matKhau;
        }
        public string getMatKhau()
        {
            return matKhau;
        }


        public string toString()
        {
            return $"- Ho va ten: {hoTen}\n- Email: {email}\n- Dien Thoai: {dienThoai}\n- Mat khau: {matKhau}";
        }
    }
}
