using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_01App1
{
    class SinhVien
    {
        private int _maSo;
        private string _hoTen;
        private Date _namSinh;
        public int MaSo
        {
            get { return _maSo; }
            set { _maSo = value; }
        }
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public Date NamSinh
        {
            get { return _namSinh; }
            set { _namSinh = value; }
        }
        public SinhVien()
        {
            _maSo = 0;
            _hoTen = "";
            _namSinh = new Date(1, 1, 1900);
        }
        public SinhVien(int maSo,string hoTen, Date namSinh)
        {
            this._maSo = maSo;
            this._hoTen = hoTen;
            this._namSinh = namSinh;
        }
        public string toString()
        {
            string kq;
            kq =$"{MaSo} - {HoTen} -{NamSinh.showTime()} ";
            return kq;
        }
    }
}
