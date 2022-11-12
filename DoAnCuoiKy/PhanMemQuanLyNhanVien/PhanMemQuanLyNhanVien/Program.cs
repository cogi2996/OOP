using System;
using System.Collections.Generic;

namespace PhanMemQuanLyNhanVien
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<NhanVien> list = new List<NhanVien>();
            Admin admin = new Admin();
            KiemChungVien x = new KiemChungVien(6, 500000, "Trang", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV2555", 1, 4000000, new DateTime(2020, 9, 11), true);
            KiemChungVien y = new KiemChungVien(6, 500000, "An", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV2555", 1, 4000000, new DateTime(2020, 9, 11), true);
            KiemChungVien z = new KiemChungVien(6, 500000, "Truong", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV2555", 1, 4000000, new DateTime(2020, 9, 11), true);
            KiemChungVien t = new KiemChungVien(6, 500000, "Minh", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV2555", 1, 4000000, new DateTime(2020, 9, 11), true);
            list.Add(x);
            list.Add(y);
            list.Add(z);
            list.Add(t);
            // moi tai khoan co mot moi truong cong ty rieng
            // moit tai khoan quan li mot cong ty
            static void XacThuc(Admin admin,List<NhanVien>list)
            {
                
                Console.WriteLine("[1]-Dang Nhap");
                Console.WriteLine("[2]-Dang ki");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    Console.Clear();
                    Menu(admin, list);
                }
                else if(choice == 2)
                {
                    Console.Clear();
                    string hoTen;
                    string email;
                    int dienThoai;
                    string matKhau;
                    string xacNhanMatKhau;
                    Console.Write("Ho va ten: ");
                    hoTen = Console.ReadLine();
                    Console.Write("\nEmail: ");
                    email = Console.ReadLine();
                    Console.Write("\nSo dien thoai: ");
                    dienThoai = int.Parse(Console.ReadLine());
                    Console.Write("\nNhap mat khau: ");
                    matKhau = Console.ReadLine();
                    Console.Write("\nXac nhan mat khau: ");
                    xacNhanMatKhau = Console.ReadLine();
                    if(matKhau == xacNhanMatKhau)
                    {
                        Console.Write("   ->Chinh xac");
                        admin = new Admin(hoTen, email, dienThoai, matKhau);
                        Menu(admin,list);
                    }
                }
            }
            static void Menu(Admin admin,List<NhanVien> list)
            {
                int choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("[1]-He thong\n[2]-Quan ly\n[3]-Thong ke\n[4]-Luu\n[5]-Thoat");
                    choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            {
                                HeThong(choice,admin);
                                break;
                            }
                        case 2:
                            {
                                QuanLy(choice,admin, list);
                                break;
                            }
                    }

                } while (choice != 0);
            }
            static void ChinhSuaThongTinTaiKhoan(int choice,Admin admin)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("[1]- HoTen\n[2]- Email\n[3]-So dien thoai\n[4]-Mat khau\n[5]-Quay lai");
                    Console.Write("\nLua chon: ");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (choice == 1)
                    {
                        Console.Write("Nhap ho va ten moi: ");
                        admin.setHoTen(Console.ReadLine());
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Nhap email moi: ");
                        admin.setEmail(Console.ReadLine());
                    }
                    else if (choice == 3)
                    {
                        Console.Write("Nhap so dien thoai moi: ");
                        admin.setDienThoai(int.Parse(Console.ReadLine()));
                    }
                    else if (choice == 4)
                    {
                        string matKhauMoi, matKhauXacNhan;
                        do
                        {
                            Console.Clear();
                            Console.Write("\nNhap mat khau moi: ");
                            matKhauMoi = Console.ReadLine();
                            Console.Write("\nXac nhan mat khau: ");
                            matKhauXacNhan = Console.ReadLine();
                            if (matKhauMoi != matKhauXacNhan)
                            {
                                Console.Write("\n[WARNING]-Mat khau xac nhan khong khop mat khau da nhap, vui long nhap lai");
                                for (int i = 0; i < 4; i++)
                                {
                                    Console.Write(".");
                                    System.Threading.Thread.Sleep(600);//he thong ngu 600s
                                }
                                Console.Write("\n");
                            }
                        } while (matKhauMoi != matKhauXacNhan);
                        admin.setMatKhau(matKhauMoi);
                    }
                } while (choice != 5);
                
            }
            static void HeThong(int choice,Admin admin)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("[1]- Thong tin tai khoan\n[2]- Chinh sua thong tin tai khoan\n[3]- Quay lai ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine(admin.toString());
                                Console.WriteLine("\n[1]- Chinh sua thong tin tai khoan\n[2]- Quay lai");
                                choice = int.Parse(Console.ReadLine());
                                if(choice ==  1)
                                {
                                    goto case 2;
                                }
                                if(choice == 2)
                                {
                                    break;
                                }
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("\tNhap muc can chinh sua: ");
                                ChinhSuaThongTinTaiKhoan(choice, admin);
                                break;
                            }
                        case 3:
                            {
                                break;
                            }
                    }
                } while (choice != 3);
                
            }
            //static void timKiemNhanVienBangMaSo(int choice, Admin admin)
            //{
            //    do
            //    {
            //        Console.Write("- Nhap ma so nhan vien can tim kiem: ");
            //        string code = Console.ReadLine();
            //    } while (choice  == 2);
            //    
            //}
            static void NhapNhanVien(List<NhanVien> list)
            {
                int choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("[1]- Lap trinh vien\n[2]- Kiem chung vien\n[3]-Quay lai");
                    choice = int.Parse(Console.ReadLine());
                    if(choice == 1)
                    {
                        NhanVien lapTrinhVien = new LapTrinhVien();
                        Console.Clear();
                        lapTrinhVien.NhapThongtin();
                        list.Add(lapTrinhVien);
                        NhapNhanVien(list);
                        choice = 3;// thang cuoi cung out thi thang con cung out
                    }
                    else if (choice ==2)
                    {

                        NhanVien  KiemChungVien = new KiemChungVien();
                        Console.Clear();
                        KiemChungVien.NhapThongtin();
                        list.Add(KiemChungVien);
                        NhapNhanVien(list);
                        choice = 3;// thang cuoi cung out thi thang con cung out
                    }



                } while (choice !=3);
            }
            static void QuanLy(int choice, Admin admin, List<NhanVien> list)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("[1]-Tim kiem\n[2]-Them\n[3]-Sua\n[4]-Xoa");
                    choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            {
                                //Tim kiem nhan vien bang ma so
                               // timKiemNhanVienBangMaSo(choice, admin);
                                //Tim kiem cac nhan vien bang ten
                                break;
                            }
                        case 2:
                            {
                                NhapNhanVien(list);
                                Console.WriteLine(list.Count);
                                Console.ReadKey();
                                break;
                            }
                    }
                    
                } while (choice != 4);
            }
            XacThuc(admin,list);
        }
    }
}
