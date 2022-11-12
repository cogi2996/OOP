using System;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap so luong nhan vien :");
            int n = int.Parse(Console.ReadLine());
            NhanVien[] listNV = new NhanVien[n];
            Console.WriteLine("Nhap 1 - Nhap nhan vien bien che");
            Console.WriteLine("Nhap 2 - Nhap nhan vien hop dong");
            static  void NhapNNhanVien(NhanVien[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("NHap lua chon: ");
                    int chose = int.Parse(Console.ReadLine());
                    do
                    {
                        switch (chose)
                        {
                            case 1:
                                {
                                    arr[i] = new NVBC();
                                    arr[i].NhapThongTin();
                                    Console.WriteLine("---------------------------------------------");
                                    break;
                                }
                            case 2:
                                {
                                    arr[i] = new NVHD();
                                    arr[i].NhapThongTin();
                                    Console.WriteLine("---------------------------------------------");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("-->Lua chon khong hop le");
                                    break;
                                }
                        }

                    } while (chose != 1&&chose !=2);
                }
            }
           
            static void xuatNNhanVIen(NhanVien[] listNV)
            {
                foreach(NhanVien item in listNV)
                {
                    item.xuatThongTin();
                    Console.WriteLine("---------------------------------------------"); 
                };  
            }
            static double TongLuong(NhanVien[] arr) 
            {
                double tong = 0.0;
                foreach(NhanVien item in arr)
                {
                    tong += item.TinhLuong();
                }
                return tong;
            }
            static void XuatTongLuong(NhanVien[] arr)
            {
                Console.WriteLine("Tong luong can phai tra cho nhan vien: " +  TongLuong(arr).ToString());

            }
            
            static void XuatLuongCao(NhanVien[] arr)
            {
                NhanVien[] x = new NhanVien[arr.Length];
                Array.Copy(arr, 0, x, 0,arr.Length);
                Array.Sort(x, delegate (NhanVien user1, NhanVien user2) {
                    return user1.TinhLuong().CompareTo(user2.TinhLuong());
                });
                Console.WriteLine("Luong cao nhat: " + x[x.Length-1].TinhLuong().ToString());
            }
            NhapNNhanVien(listNV);
            xuatNNhanVIen(listNV);
            XuatTongLuong(listNV);
            XuatLuongCao(listNV);

            

        }
    }
}
