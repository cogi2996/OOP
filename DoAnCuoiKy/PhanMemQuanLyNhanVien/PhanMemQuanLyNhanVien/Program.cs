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
            NhanVien x = new LapTrinhVien(6, 500000, "Trang", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV2555", 1, 4000000, new DateTime(2020, 9, 11), true,0);
            NhanVien y = new LapTrinhVien(6, 500000, "An", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV26655a", 1, 4000000, new DateTime(2020, 9, 11), true,0);
            NhanVien z = new LapTrinhVien(6, 500000, "Minh", "Quan Nam", 19, 20, 11, 2003, 0195304155, "KCV26655", 1, 4000000, new DateTime(2020, 9, 25), true,1);
            NhanVien t = new LapTrinhVien(6, 500000, "Minh", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV251455", 1, 4000000, new DateTime(2020, 9, 11), true,0);
            list.Add(x);
            list.Add(y);
            list.Add(z);
            list.Add(t);
            // moi tai khoan co mot moi truong cong ty rieng
            // moit tai khoan quan li mot cong ty
            // HAM CHO ...
            static void baCham()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(600);//he thong ngu 600s
                }
                Console.Write("\n");
            }
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
                    Console.WriteLine("[1]-HoTen\n[2]-Email\n[3]-So dien thoai\n[4]-Mat khau\n[5]-Quay lai");
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
                                baCham();
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
            static void NhapThongTinNhanVien(List<NhanVien> list)
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
                        NhapThongTinNhanVien(list);
                        choice = 3;// thang cuoi cung out thi thang con cung out
                    }
                    else if (choice ==2)
                    {

                        NhanVien  KiemChungVien = new KiemChungVien();
                        Console.Clear();
                        KiemChungVien.NhapThongtin();
                        list.Add(KiemChungVien);
                        NhapThongTinNhanVien(list);
                        choice = 3;// thang cuoi cung out thi thang con cung out
                    }



                } while (choice !=3);
            }
            static void SuaThongTinNhanVien(List<NhanVien> list)
            {
                int choice = 0;
                do
                {
                    Console.Clear();
                    Console.Write("Nhap ma so nhan vien can chinh sua: ");
                    string maSo = Console.ReadLine();
                    int index = 0;

                    while (index != list.Count && (list[index] as NhanVien ).getMaNhanVien()!=maSo)
                    {
                        index++;
                    }

                    if(index == list.Count)
                    {
                        Console.Write("\nMa da nhap khong ton tai nhan vien\n-->Vui long nhap lai ma nhan vien");
                    }
                    else
                    {
                        NhanVien nhanVien = list[index] as NhanVien;
                        Console.WriteLine(nhanVien.getLoaiNhanVien());
                        int subCode = nhanVien.getLoaiNhanVien(); 
                        switch(subCode)
                        {
                            case 0:
                                {
                                    do
                                    {
                                        string thongTinLapTrinh = "[11]-So go lam them\n[12]-Luong ngoai gio";
                                        nhanVien.SuaThongTin(ref choice, thongTinLapTrinh);
                                        Console.Write("\n[1]-Tiep tuc chinh sua\n[2]-Quay lai\n");
                                        choice = int.Parse(Console.ReadLine());
                                        if(choice == 1)
                                        {
                                            goto case 0;
                                        }
                                        else if (choice == 2)
                                        {
                                            break;
                                        }
                                        break;
                                    } while (choice != 13);
                                    break;
                                }
                            case 1:
                                {

                                    break;
                                }
                        }
                      
                    }

                } while (choice != 2);
            }
            static void TimKhiemThongTin(List<NhanVien>list)
            {
                //ham nay de dieu them option xem thong tin nhan vien da tim duoc hay quay lai menu tim kiem theo
                static void ConTrolXemthongTin(List<NhanVien> list,List< NhanVien> listTemp,string thongTinHopLe)
                {
                    string choiceS = "";
                    do
                    {
                        Console.Clear();
                        if (thongTinHopLe.Length == 0)
                        {
                            Console.Clear();
                            Console.Write("Khong co ket qua tim kiem tuong ung\nNhap bat ki de quay lai");
                            baCham();
                            Console.ReadKey();
                            break;
                            
                        }
                        Console.Write(thongTinHopLe);
                        Console.WriteLine("Nhap [P/p] de quay lai");
                        choiceS = Console.ReadLine();
                        int choiceI = 0;
                        if (choiceS[0] <= '9' && choiceS[0] >= '0')
                        {
                            int i = 0;
                            while (i++ < choiceS.Length)
                            {
                                choiceI = choiceI * 10 + (choiceS[0] - '0');
                            }
                            XemThongTin(list,listTemp, choiceI);

                        }

                    } while (choiceS.ToLower()[0] != 'p');
                }
                static void XemThongTin(List<NhanVien> list,List< NhanVien > listTemp, int index)
                {
                    Console.Clear();
                    if(index <= listTemp.Count && index >=1)
                    {
                        Console.WriteLine((listTemp[index - 1] as NhanVien).toString());
                        Console.Write("[Notify]-Nhap bat ky de quay lai");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("\n[WARNING]-Lua chon khong hop le,vui long nhap lai");
                        
                        baCham();
                    }
                }

                static void Ten(List<NhanVien> list)
                {
                    Console.Clear();
                    Console.Write("Nhap ten nhan vien can tim kiem: ");
                    string ten = Console.ReadLine();
                    int index = 1;
                    List<NhanVien> listTemp = new List<NhanVien>();
                    string thongTinHopLe = "";
                    foreach (NhanVien nhanVien in list)
                    {
                        if(nhanVien.getHoVaTen().Contains(ten)) 
                        {
                            thongTinHopLe =thongTinHopLe+  $"[{index++}]-[{nhanVien.getMaNhanVien()}]-{nhanVien.getHoVaTen()}\n";
                            listTemp.Add(nhanVien); 
                        }
                    }
                    
                    ConTrolXemthongTin(list,listTemp, thongTinHopLe);
                }
                static void MaSoNhanVien(List<NhanVien> list)
                {
                    Console.Clear();
                    Console.Write("Nhap ten nhan vien can tim kiem: ");
                    string maSo = Console.ReadLine();
                    int index = 1;
                    List<NhanVien> listTemp = new List<NhanVien>();
                    string thongTinHopLe = "";
                    foreach (NhanVien nhanVien in list)
                    {
                        if (nhanVien.getMaNhanVien() == maSo)
                        {
                            thongTinHopLe = thongTinHopLe + $"[{index++}]-[{nhanVien.getMaNhanVien()}]-{nhanVien.getHoVaTen()}\n";
                            listTemp.Add(nhanVien);
                        }
                    }
                    ConTrolXemthongTin(list, listTemp, thongTinHopLe);
                }
                static void MucLuong(List<NhanVien> list)
                {
                    Console.Clear();
                    Console.Write("Nhap ten nhan vien can tim kiem: ");
                    TienLuong luong = new TienLuong(double.Parse(Console.ReadLine()));
                    int index = 1;
                    List<NhanVien> listTemp = new List<NhanVien>();
                    string thongTinHopLe = "";
                    foreach (NhanVien nhanVien in list)
                    {
                        if (nhanVien.TinhLuong()==luong)
                        {
                            thongTinHopLe = thongTinHopLe + $"[{index++}]-[{nhanVien.getMaNhanVien()}]-{nhanVien.getHoVaTen()}\n";
                            listTemp.Add(nhanVien);
                        }
                    }

                    ConTrolXemthongTin(list, listTemp, thongTinHopLe);
                }
                static void SoDienThoai(List<NhanVien> list)
                {
                    Console.Clear();
                    Console.Write("Nhap ten nhan vien can tim kiem: ");
                    int dienThoai = int.Parse(Console.ReadLine());
                    int index = 1;
                    List<NhanVien> listTemp = new List<NhanVien>();
                    string thongTinHopLe = "";
                    foreach (NhanVien nhanVien in list)
                    {
                        if (nhanVien.getDienThoai()==dienThoai)
                        {
                            thongTinHopLe = thongTinHopLe + $"[{index++}]-[{nhanVien.getMaNhanVien()}]-{nhanVien.getHoVaTen()}\n";
                            listTemp.Add(nhanVien);
                        }
                    }

                    ConTrolXemthongTin(list, listTemp, thongTinHopLe);
                }
                static void NamKinhNghiem(List<NhanVien> list)
                {
                    Console.Clear();
                    Console.Write("Nhap ten nhan vien can tim kiem: ");
                    int kinhNghiem = int.Parse(Console.ReadLine());
                    int index = 1;
                    List<NhanVien> listTemp = new List<NhanVien>();
                    string thongTinHopLe = "";
                    foreach (NhanVien nhanVien in list)
                    {
                        if (nhanVien.getKinhNghiem() == kinhNghiem)
                        {
                            thongTinHopLe = thongTinHopLe + $"[{index++}]-[{nhanVien.getMaNhanVien()}]-{nhanVien.getHoVaTen()}\n";
                            listTemp.Add(nhanVien);
                        }
                    }

                    ConTrolXemthongTin(list, listTemp, thongTinHopLe);
                }
                static void NgayBatDauLam(List<NhanVien> list)
                {
                    Console.Clear();
                    Console.Write("Nhap ngay,thang,nam can tim kiem: ");
                    int ngay, thang, nam;
                    Console.Write("\nNgay: ");
                    ngay = int.Parse(Console.ReadLine());
                    Console.Write("\nThang: ");
                    thang = int.Parse(Console.ReadLine());
                    Console.Write("\nNam: ");
                    nam = int.Parse(Console.ReadLine());
                    DateTime d = new DateTime(nam, thang, ngay);
                    int index = 1;
                    List<NhanVien> listTemp = new List<NhanVien>();
                    string thongTinHopLe = "";
                    foreach (NhanVien nhanVien in list)
                    {
                        if (nhanVien.getNgayBatDauLam().Day == d.Day&& nhanVien.getNgayBatDauLam().Month == d.Month&& nhanVien.getNgayBatDauLam().Year == d.Year)
                        {
                            thongTinHopLe = thongTinHopLe + $"[{index++}]-[{nhanVien.getMaNhanVien()}]-{nhanVien.getHoVaTen()}\n";
                            listTemp.Add(nhanVien);
                        }
                    }

                    ConTrolXemthongTin(list, listTemp, thongTinHopLe);
                }
                int choice = 0;
                int ketThuc = 7;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Tim kiem theo:\n[1]-Ten\n[2]-Ma so nhan vien\n[3]-Muc luong\n[4]-So dien thoai\n[5]-Nam kinh nghiem\n[6]-Ngay bat dau lam\n[7]-Quay lai");
                    choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            {
                                Ten(list);        
                                break;
                            }
                        case 2:
                            {
                                MaSoNhanVien(list);
                                break;
                            }
                        case 3:
                            {
                                MucLuong(list);
                                break;
                            }
                        case 4:
                            {
                                SoDienThoai(list);
                                break;
                            }
                        case 5:
                            {
                                NamKinhNghiem(list);
                                break;
                            }
                        case 6:
                            {
                                NgayBatDauLam(list);
                                break;
                            }
                        
                    }
                } while (choice !=ketThuc);
            }
            static void XoaNhanVien(List<NhanVien> list)
            {
                int choice = 1;
                int ketThuc = 2;
                do
                {
                    // thuc hien xoa
                    switch(choice)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.Write("\nNhap ma so nhan vien can xoa: ");
                                string maSo = Console.ReadLine().Trim();
                                int oldCount = list.Count; // luu giu so luong nhan vien cu truoc khi co xoa
                                int index = 0;
                                foreach(NhanVien nhanVien in list)
                                {
                                    if(nhanVien.getMaNhanVien()==maSo)
                                    {
                                        list.RemoveAt(index);
                                        break;
                                    }
                                    index++;
                                }
                                //neu so luong nhan vien sau khi xoa nho hon truoc khi xoa thi ton tai nhan vien da bi xoa
                                if (oldCount >list.Count)
                                {
                                    Console.Write("\n-->Xoa thanh cong");
                                    baCham();
                                    goto case 2;
                                }
                                break;
                            }
                            /*hien thi control ,quay ve case 1 neu muon tiep tuc xoa hoac quay lai*/
                        case 2:
                            {
                                Console.Write("\n[1]-Tiep tuc xoa\n[2]-Quay lai\n");
                                choice = int.Parse(Console.ReadLine());
                                if (choice == 1)
                                {
                                    goto case 1;
                                }
                                else if (choice == 2)
                                {
                                    break;
                                }
                                break;
                            }

                    }

                } while (choice != ketThuc);
            }
            static void QuanLy(int choice, Admin admin, List<NhanVien> list)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("[1]-Tim kiem\n[2]-Them\n[3]-Sua\n[4]-Xoa\n[5]-Quay lai");
                    choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            {
                                TimKhiemThongTin(list);
                                break;
                            }
                        case 2:
                            {
                                NhapThongTinNhanVien(list);
                                break;
                            }
                        case 3:
                            {
                                SuaThongTinNhanVien(list);
                                break;
                            }
                        case 4:
                            {
                                XoaNhanVien(list);
                                break;
                            }
                            
                    }
                    
                } while (choice != 5);
            }
            XacThuc(admin,list);
        }
    }
}
