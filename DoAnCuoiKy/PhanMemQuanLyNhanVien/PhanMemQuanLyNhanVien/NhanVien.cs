using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace PhanMemQuanLyNhanVien
{
    public abstract class NhanVien
    {
        private static int soLuong;
        private string hoVaTen;
        private string diaChi;
        private int tuoi;
        private DateTime ngaySinh;
        private string dienThoai;
        private string maNhanVien;
        private int kinhNghiem;
        private TienLuong luongCoBan = new TienLuong();
        private DateTime ngayBatDauLam;
        private bool tinhTrangLamViec;
        private int loaiNhanVien; // 0 - lap trinh vien , 1 - kiem chung vien
        public NhanVien()
        {
            soLuong++;
            hoVaTen = "unknown";
            diaChi = "unknown";
            tuoi = 0;
            ngaySinh = new DateTime(1990, 1, 1);
            dienThoai = "unknown";
            maNhanVien = "unknown";
            kinhNghiem = 0;
            luongCoBan = new TienLuong();
            ngayBatDauLam = new DateTime(1990, 1, 1);
            tinhTrangLamViec = false;
            loaiNhanVien = 0;
        }
        public NhanVien(string hoVaTen, string diaChi, int tuoi, int  ngay, int thang, int nam, string dienThoai, string maNhanVien, int kinhNghiem, double luongCoBan, DateTime ngayBatDauLam, bool tinhTrangLamViec,int loaiNhanVien)
        {
            soLuong++;
            this.hoVaTen = hoVaTen;
            this.diaChi = diaChi;
            this.tuoi = tuoi;
            this.ngaySinh = new DateTime(nam, thang, ngay);
            this.dienThoai = dienThoai;
            this.maNhanVien = maNhanVien;
            this.kinhNghiem = kinhNghiem;
            this.luongCoBan.setTienLuong(luongCoBan);
            this.ngayBatDauLam = ngayBatDauLam;
            this.tinhTrangLamViec = tinhTrangLamViec;
            this.loaiNhanVien = loaiNhanVien;
        }
        public static int getSoLuong()
        {
            return soLuong;
        }
        public void setHoVaTen(string hoVaTen)
        {
            this.hoVaTen = hoVaTen;
        }
        public string getHoVaTen()
        {
            return hoVaTen;
        }
        public void setDiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }
        public string getDiaChi()
        {
            return diaChi;
        }
        public void setTuoi(int tuoi)
        {
            
            this.tuoi = tuoi;
        }
        public int getTuoi()
        {
            return tuoi;
        }

        public void setNgaySinh(DateTime ngaySinh)
        {
            this.ngaySinh = ngaySinh;
        }
        public DateTime getNgaySinh()
        {
            return ngaySinh;
        }
        public void setDienThoai (string dienThoai )
        {
            this.dienThoai = dienThoai;
        }
        public string getDienThoai()
        {
            return dienThoai;
        }
        public void setMaNhanVien(string maNhanVien)
        {
            this.maNhanVien = maNhanVien;
        }
        public string getMaNhanVien()
        {
            return maNhanVien;
        }
        public void setKinhNghiem(int kinhNghiem)
        {
            this.kinhNghiem = kinhNghiem;     
        }
        public int getKinhNghiem()
        {
            return kinhNghiem;
        }
        public void setLuongCoBan(TienLuong luongCoBan)
        {
            this.luongCoBan = luongCoBan;
        }
        public TienLuong getLuongCoBan()
        {
            return luongCoBan;
        }
        public void setNgayBatDauLam(DateTime ngayBatDauLam)
        {
            this.ngayBatDauLam = ngayBatDauLam;
        }
        public DateTime getNgayBatDauLam ()
        {
            return ngayBatDauLam;
        }
        public void setTinhTrang(bool tinhTrangLamViec)
        {
            this.tinhTrangLamViec = tinhTrangLamViec; 
        }
        public bool getTinhTrang()
        {
            return tinhTrangLamViec;
        }
        public void setLoaiNhanVien(int loaiNhanVien)
        {
            this.loaiNhanVien = loaiNhanVien;
        }
        public int getLoaiNhanVien()
        {
            return loaiNhanVien;
        }    
        public virtual string toString ()
        {
            string kq = $"Ten:{hoVaTen}\nDia chi:{diaChi}\nTuoi:{tuoi}\nNgay sinh:{ngaySinh.Day}/{ngaySinh.Month}/{ngaySinh.Year}\n" +
                $"So dien thoai:{dienThoai}\nKinh nghiem:{kinhNghiem}\nNgay bat dau lam:{ngayBatDauLam.Day}/{ngayBatDauLam.Month}" +
                $"/{ngayBatDauLam.Year}\nTinh trang lam viec:{((tinhTrangLamViec == true) ? "Con lam" : " Da nghi")}\nLuong co ban:{luongCoBan.toString()}";
            return kq;            
        }
        public static void InThongTinNhanVien (NhanVien[] nhanViens)
        {
            foreach(NhanVien nhanVien in nhanViens)
            {
                Console.WriteLine(nhanVien.toString());
            }
        }
        
        public virtual void NhapThongtin()
        {
            Console.Write("Ma nhan vien: ");
            maNhanVien = Console.ReadLine();
            Console.Write("Ho va ten: ");
            hoVaTen = Console.ReadLine();
            Console.Write("\nDia chi: ");
            diaChi = Console.ReadLine();
            int tuoi = 0;
            do
            {
                Console.Write("\nTuoi: ");
                try
                {
                    tuoi = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write("\nTuoi phai la mot so,vui long nhap lai");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        System.Threading.Thread.Sleep(600);//he thong ngu 600ms
                    }
                    Console.Write("\n");

                }
            } while (tuoi == 0);
            
            Console.WriteLine("Ngay sinh: ");
            int day, month, year;
            day = int.Parse(Console.ReadLine()); //AddDays
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            ngaySinh = new DateTime(year, month, day);
            Console.Write("\nSo dien thoai: ");
            dienThoai = Console.ReadLine();
            Console.Write("\nNam kinh nghiem: ");
            kinhNghiem = int.Parse(Console.ReadLine());
            Console.WriteLine("Ngay bat dau lam:");
            day = int.Parse(Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            ngayBatDauLam = new DateTime(year, month, day);
            Console.Write("\nTinh trang lam viec: ");
            tinhTrangLamViec = bool.Parse(Console.ReadLine());
            Console.WriteLine("\nLuong co ban: ");
            double luongCoBan = double.Parse(Console.ReadLine());
            this.luongCoBan = new TienLuong(luongCoBan);
        }
        public abstract TienLuong TinhLuong();
        public virtual void SuaThongTin(ref int choice,string thongTinlapTrinh)
        {
            Console.Clear();
            Console.WriteLine($"-->Lua chon thong tin can sua cua nhan vien co ma {this.maNhanVien}\n[1]-ho va ten\n[2]-" +
                    $"Dia chi\n[3]-Tuoi\n[4]-Ngay sinh\n[5]-So dien thoai\n[6]-Ma nhan vien\n[7]-Nam kinh nghiem\n[8]-Ngay bat dau lam\n[9]-Luong co ban" +
                    $"\n[10]-Tinh trang lam viec\n"+ thongTinlapTrinh);
            choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(choice)
            {
                case 1:
                    {
                        
                        Console.Write("Ho va ten moi: ");
                        setHoVaTen(Console.ReadLine());
                        break;
                    }
                case 2:
                    {
                        Console.Write("Dia chi moi: ");
                        setDiaChi(Console.ReadLine());
                        break;
                    }
                case 3:
                    {
                        Console.Write("Tuoi moi: ");
                        setTuoi(int.Parse(Console.ReadLine()));
                        break;
                    }
                case 4:
                    {
                        int ngay, thang, nam;
                        Console.Write("-Ngay sinh moi: ");
                        Console.Write("\nNhap ngay: ");
                        ngay = int.Parse(Console.ReadLine());
                        Console.Write("Nhap thang: ");
                        thang = int.Parse(Console.ReadLine());
                        Console.Write("Nhap nam: "); 
                        nam = int.Parse(Console.ReadLine());
                        setNgaySinh(new DateTime(nam, thang, ngay));
                        break;
                    }
                case 5:
                    {
                        Console.Write("So dien thoai moi: ");
                        setDienThoai(Console.ReadLine());
                        break;
                    }
                case 6:
                    {
                        Console.Clear();
                        Console.Write("Nhap ma nhan vien: ");
                        setMaNhanVien(Console.ReadLine());
                        break;
                    }
                case 7:
                    {
                         Console.Write("Nam kinh nghiem moi: ");
                        setKinhNghiem(int.Parse(Console.ReadLine()));
                        break;
                    }
                case 8:
                    {
                        int ngay, thang, nam;
                        Console.Write("Ngay bat dau lam: ");
                        Console.Write("\nNhap ngay: ");
                        ngay = int.Parse(Console.ReadLine());
                        Console.Write("Nhap thang: ");
                        thang = int.Parse(Console.ReadLine());
                        Console.Write("Nhap nam: ");
                        nam = int.Parse(Console.ReadLine());
                        setNgaySinh(new DateTime(nam, thang, ngay));
                        break;
                    }
                case 9:
                    {
                        Console.Write("Luong co ban: ");
                        setLuongCoBan(new TienLuong(double.Parse(Console.ReadLine())));
                        break;
                    }
                case 10:
                    {
                        Console.Write("Tinh trang lam viec moi: ");
                        setTinhTrang(bool.Parse(Console.ReadLine()));
                        break;

                    }
            }

        }
        public class SortPersons : IComparer
        {
            public int Compare(object x, object y)
            {
                // Ép kiểu 2 object truyền vào về Person.
                NhanVien p1 = x as NhanVien;
                NhanVien p2 = y as NhanVien;
                    
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
                    if (TienLuong.soSanhTien(p1.TinhLuong(),p2.TinhLuong())==1)
                    {
                        return 1;
                    }
                    else if (TienLuong.soSanhTien(p1.TinhLuong(), p2.TinhLuong()) == 0)
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
