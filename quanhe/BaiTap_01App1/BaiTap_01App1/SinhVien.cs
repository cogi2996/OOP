using System;
using System.Collections;

namespace BaiTap_01App1
{
    public class SinhVien
    {
        private ArrayList list = new ArrayList();
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
            kq = $"{MaSo} - {HoTen} -{NamSinh.showTime()} ";
            return kq;
        }
        
        public class shortSinhVien:IComparer
        {
            public int Compare(object x, object y)
            {
                // Ép kiểu 2 object truyền vào về Person.
                SinhVien p1 = x as SinhVien;
                SinhVien p2 = y as SinhVien;

                /*
                 * Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được.
                 * Trường hợp này tốt nhất ta nên ném ra lỗi để lập trình viên sửa chữa.
                 * Chi tiết về exception sẽ được trình bày ở những bài học sau.
                 */
                if (p1 == null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    /*
                     * Khi dữ liệu đã ok thì ta thực hiện so sánh và trả về các giá trị 1 0 -1 tương ứng
                     * lớn hơn, bằng, bé hơn.
                     */
                    if (p1._maSo > p2._maSo)
                    {
                        return 1;
                    }
                    else if (p1._maSo == p2._maSo)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
        
    }
}
