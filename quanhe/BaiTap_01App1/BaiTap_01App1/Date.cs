using System;
using System.Collections;

namespace BaiTap_01App1
{
    public class Date
    {
        private int _ngay, _thang, _nam;
        public string showTime()
        {
            return $"{Ngay} - {Thang} - {Nam}";
        }
        public int Ngay
        {
            get { return _ngay; }
            set { _ngay = value; }
        }
        public int Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }
        public int Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }
        public Date()
        {
            _ngay = 1;
            _thang = 1;
            _nam = 1900;
        }
        public Date(int ngay,int thang,int nam)
        {
            this._ngay = ngay;
            this._thang = thang;
            this._nam = nam;
        }

     
       
        
    }
}
