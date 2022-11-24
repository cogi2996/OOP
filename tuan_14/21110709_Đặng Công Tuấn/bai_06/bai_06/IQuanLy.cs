using System;
using System.Collections.Generic;
using System.Text;

namespace bai_06
{
    public interface IQuanLy
    {
        void XuatThongTin();
        void KhoiTao();
        bool KiemTraMau(string mau);
        bool KiemTraNam(int X);
    }
}
