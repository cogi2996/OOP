using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace PhanMemQuanLyNhanVien
{
    public class Program
    {
        public static void Main(string[] args)
        {
            static void InBangLuong(List<NhanVien>list)
            {
                static void inVien()
                {
                    for (int i = 0; i < 39*3; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("+");
                            continue;
                        }
                        else if (i == 36 )
                        {
                            Console.Write("+");
                            continue;
                        }
                        else if(i == 35*2+2)
                        {
                            Console.Write("+");
                            continue;
                        }
                        else if(i == 35*3+1)
                        {
                            Console.Write("+\n");
                            break ;
                        }
                        Console.Write("-");
                    }
                }
                static string convert(string s, int length)
                {
                    return s.PadLeft((length - s.Length) / 2 + s.Length).PadRight(length);
                }
                int lenght = 35;
                inVien();
                Console.Write("|" + convert("Ma nhan vien", lenght) + "|" + convert("Ho va ten", lenght) + "|" + convert("Tien luong", lenght - 2) + "|" + "\n");
                foreach (NhanVien nhanVien in list)
                {
                    inVien();
                    Console.Write("|" + convert(nhanVien.getMaNhanVien(), lenght) + "|" + convert(nhanVien.getHoVaTen(), lenght) + "|"+convert(nhanVien.TinhLuong().toString(),lenght-2)+"|"+"\n");
                }
                inVien();

            }
            List<NhanVien> list = new List<NhanVien>();
            Admin admin = new Admin();
            /*NhanVien x = new LapTrinhVien(6, 5544, "Trang", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV2555", 1, 4546, new DateTime(2020, 9, 11), true, 0);
            NhanVien y = new LapTrinhVien(6, 4548, "An", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV26655a", 1, 35230, new DateTime(2020, 9, 11), true, 0);
            NhanVien z = new KiemChungVien(6, 654, "Minh lai van tran", "Quan Nam", 19, 20, 11, 2003, 0195304155, "KCV26655", 1, 45, new DateTime(2020, 9, 25), true, 1);
            NhanVien t = new LapTrinhVien(6, 88, "Minh", "Da Nang", 19, 20, 11, 2003, 0195304155, "KCV251455", 1, 6548, new DateTime(2020, 9, 11), true, 0);
            list.Add(x);
            list.Add(y);
            list.Add(z);
            list.Add(t);*/
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
                    choice = 0;
                    switch(choice)
                    {
                        case 0:
                            {
                                
                                Console.Clear();
                                Console.WriteLine("[1]-Email: \n[2]-Mat khau: ");
                                choice = int.Parse(Console.ReadLine());
                                if(choice == 1)
                                {
                                    goto case 2;
                                }
                                break;
                            }
                        case 2: // nhap email
                            {
                                string[] thongTinTaiKhoan = File.ReadAllLines("D:\\OOP\\OOP\\DoAnCuoiKy\\PhanMemQuanLyNhanVien\\PhanMemQuanLyNhanVien\\data.txt");
                                string emailAdmin = thongTinTaiKhoan[1];
                                string matKhauAdmin = thongTinTaiKhoan[3];
                                Console.Clear();
                                Console.Write("Email: ");
                                string emailDangNhap = Console.ReadLine();
                                if(emailDangNhap == emailAdmin)
                                {
                                    Console.Write("Mat khau: ");
                                    string matKhauDangNhap = Console.ReadLine();
                                    if(matKhauDangNhap == matKhauAdmin)
                                    {
                                        DocFile(admin, list);
                                        Menu(admin,list);
                                    }
                                    else
                                    {
                                        Console.Write("\n[ERROR]-Mat khau ban da nhap khong khop voi tai khoan");
                                        baCham();
                                        goto case 0;                                        
                                    }
                                }
                                else
                                {
                                    Console.Write("\n[ERROR]-Email ban da nhap khong khop voi bat ky tai khoan");
                                    baCham();
                                    goto case 2;
                                }
                                break;
                            }
                    }
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
                        Console.Write("-->Dang tien hanh tao tai khoan moi");
                        baCham();
                        admin = new Admin(hoTen, email, dienThoai, matKhau);
                        // ghi mat khau vao file
                        string[] thongTinTaiKhoan = { hoTen,email,dienThoai.ToString(),matKhau,xacNhanMatKhau};
                        File.WriteAllLines("D:\\OOP\\OOP\\DoAnCuoiKy\\PhanMemQuanLyNhanVien\\PhanMemQuanLyNhanVien\\data.txt", thongTinTaiKhoan);
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
                        case 3:
                            {
                                ThongKe(list);
                                break;
                            }
                        case 4:
                            {
                                GhiFile(admin,list);
                                Console.Write("\n-->Luu thong tin thanh cong");
                                baCham();
                                break;
                            }
                        case 5:
                            {
                                Environment.Exit(0);
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

                        NhanVien  kiemChungVien = new KiemChungVien();
                        Console.Clear();
                        kiemChungVien.NhapThongtin();
                        list.Add(kiemChungVien);
                        NhapThongTinNhanVien(list);
                        choice = 3;// thang cuoi cung out thi thang con cung out
                    }



                } while (choice !=3);
            }
            static void SuaThongTinNhanVien(List<NhanVien> list)
            {
                int choice = 0;
                int ketThuc = 2;
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
                                        string thongTinLapTrinh = "[11]-So go lam them\n[12]-Luong ngoai gio\n[13]-Quay lai";
                                        nhanVien.SuaThongTin(ref choice, thongTinLapTrinh);
                                        if (choice == 13)
                                        {
                                            choice = 2;
                                            break;
                                        }
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
                                    do
                                    {
                                        string thongTinLapTrinh = "[11]-So loi\n[12]-Tien thuong\n[13]-Quay lai";
                                        nhanVien.SuaThongTin(ref choice, thongTinLapTrinh);
                                        if (choice == 13)
                                        {
                                            choice = 2;
                                            break;
                                        }

                                        Console.Write("\n[1]-Tiep tuc chinh sua\n[2]-Quay lai\n");
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
                                    } while (choice != 13);
                                    break;
                                }
                        }
                      
                    }

                } while (choice != ketThuc);
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
                    Console.Write("Nhap ma so nhan vien can tim kiem: ");
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
                                Console.Write("Nhap ma so nhan vien can xoa: ");
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
                                    Console.Clear();
                                    Console.Write("-->Xoa thanh cong");
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
            static void ThongKe(List<NhanVien> list)
            {
                int choice = 0;
                switch(choice)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("[1]-In bang luong nhan vien\n[2]-Thong ke so luong nhan vien\n[3]-Quay lai");
                            choice = int.Parse(Console.ReadLine());
                            if (choice == 1)
                                goto case 1;
                            else if (choice == 2)
                                goto case 2;
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            InBangLuong(list);
                            Console.WriteLine("[1]-Sap xe theo luong\n[2]-Quay lai");
                            choice = int.Parse(Console.ReadLine());
                            
                            if(choice == 1)
                            {
                                List<NhanVien> listTemp = new List<NhanVien>(list);
                                listTemp.Sort((x, y) =>
                                {
                                    int ret = TienLuong.soSanhTien(x.TinhLuong(), y.TinhLuong());
                                    return ret;
                                });
                                Console.Clear();
                                InBangLuong(listTemp);
                                Console.Write("\nNhap bat ky de quay lai");
                                Console.ReadKey();
                                goto case 0;
                            }
                            else if (choice == 2)
                            {
                                break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.Write("-So luong toan bo nhan vien: ");
                            Console.Write(NhanVien.getSoLuong());
                            Console.Write("\n-So luong toan lap trinh vien: ");
                            Console.Write(LapTrinhVien.getSoLuongLapTrinhVien());
                            Console.Write("\n-So luong toan kiem chung vien: ");
                            Console.Write(KiemChungVien.getSoLuongKiemChungVien());
                            Console.Write("\nNhap bat ky de quay lai");
                            Console.ReadKey();
                            goto case 0;
                        }
                }
            }
            static void GhiFile(Admin admin,List<NhanVien>list)
            {
                //ghi thong tin nhan vine
                string[] thongTinTaiKhoan = new string[5 + list.Count * 18];
                //{ admin.getHoTen(), admin.getEmail(), admin.getDienThoai().ToString(), admin.getMatKhau(), admin.getMatKhau() };
                thongTinTaiKhoan[0] = admin.getHoTen();
                thongTinTaiKhoan[1] = admin.getEmail();
                thongTinTaiKhoan[2] = admin.getDienThoai().ToString();
                thongTinTaiKhoan[3] = admin.getMatKhau();
                Console.Clear();
               
                static void GhiThongTin(Admin admin, NhanVien nhanVien, List<NhanVien> list, string[] a, ref int i)
                {
                    a[i++] = nhanVien.getLoaiNhanVien().ToString();
                    a[i++]= nhanVien.getMaNhanVien();
                    a[i++] = nhanVien.getHoVaTen();
                    a[i++] = nhanVien.getDiaChi();
                    a[i++] = nhanVien.getTuoi().ToString();
                    a[i++] = nhanVien.getNgaySinh().Day.ToString();
                    a[i++] = nhanVien.getNgaySinh().Month.ToString();
                    a[i++] = nhanVien.getNgaySinh().Year.ToString();
                    a[i++] = nhanVien.getDienThoai().ToString();
                    a[i++] = nhanVien.getKinhNghiem().ToString();
                    a[i++] = nhanVien.getNgayBatDauLam().Day.ToString();
                    a[i++] = nhanVien.getNgayBatDauLam().Month.ToString();
                    a[i++] = nhanVien.getNgayBatDauLam().Year.ToString();
                    a[i++] = nhanVien.getTinhTrang().ToString();
                    a[i++] = nhanVien.getLuongCoBan().Tien.ToString();
                }
                int index = 0;// chi so dem so luong nhan vien duoc in
                // dem den == list.count thi dung --> da in du
                /* bien i la ghi file bat dau tu dong 5( do 5 dong dau ghi thong tin admin roi*/
                for (int i = 4; index < list.Count; i++)
                {
                    Console.WriteLine(list[index].getHoVaTen());
                    if (list[index].getLoaiNhanVien() == 0)
                    {
                        LapTrinhVien nhanVien = list[index] as LapTrinhVien;
                        GhiThongTin(admin, nhanVien, list, thongTinTaiKhoan, ref i);
                        thongTinTaiKhoan[i++] = nhanVien.getSoGioLamThem().ToString();
                        thongTinTaiKhoan[i] = nhanVien.getLuongNgoaiGio().Tien.ToString();
                    }
                    else if (list[index].getLoaiNhanVien() == 1)
                    {
                        KiemChungVien nhanVien = list[index] as KiemChungVien;
                        GhiThongTin(admin, nhanVien, list, thongTinTaiKhoan, ref i);
                        thongTinTaiKhoan[i++] = nhanVien.getSoLoi().ToString();
                        thongTinTaiKhoan[i] =nhanVien.getTienThuong().Tien.ToString();
                    }
                    index++;
                }
                Console.Clear();
                File.WriteAllLines("D:\\OOP\\OOP\\DoAnCuoiKy\\PhanMemQuanLyNhanVien\\PhanMemQuanLyNhanVien\\data.txt",thongTinTaiKhoan );
               
            }
            static void DocFile(Admin admin,List<NhanVien> list)
            {
                static void DocThongTin(Admin admin,NhanVien nhanVien,List<NhanVien>list,string[] a,ref int i)
                {
                    // tang i len de tru cac dong thong tin admin
                    nhanVien.setLoaiNhanVien(int.Parse(a[i++]));
                    nhanVien.setMaNhanVien(a[i++]);
                    nhanVien.setHoVaTen(a[i++]);
                    nhanVien.setDiaChi(a[i++]);
                    nhanVien.setTuoi(int.Parse(a[i++]));
                    int ngay, thang, nam;
                    ngay = int.Parse(a[i++]);
                    thang = int.Parse(a[i++]);
                    nam = int.Parse(a[i++]);
                    nhanVien.setNgaySinh(new DateTime(nam, thang, ngay));
                    nhanVien.setDienThoai(int.Parse(a[i++]));
                    nhanVien.setKinhNghiem(int.Parse(a[i++]));
                    ngay = int.Parse(a[i++]);
                    thang = int.Parse(a[i++]);
                    nam = int.Parse(a[i++]);
                    nhanVien.setNgayBatDauLam(new DateTime(nam, thang, ngay));
                    nhanVien.setTinhTrang(bool.Parse(a[i++]));
                    nhanVien.setLuongCoBan(new TienLuong(double.Parse(a[i++])));
                }
                string[] a = File.ReadAllLines("D:\\OOP\\OOP\\DoAnCuoiKy\\PhanMemQuanLyNhanVien\\PhanMemQuanLyNhanVien\\data.txt");
                admin.setHoTen(a[0]);
                admin.setEmail(a[1]);
                admin.setDienThoai(int.Parse(a[2]));
                admin.setMatKhau(a[3]);
                for (int i = 4; i < a.Length; ++i)
                {
                    if(a[i]=="0")
                    {
                        LapTrinhVien nhanVien = new LapTrinhVien();
                        DocThongTin(admin,nhanVien,list,a, ref i);
                        nhanVien.setSoGioLamThem(int.Parse(a[i++]));
                        nhanVien.setLuongNgoaiGio(new TienLuong(double.Parse(a[i])));
                        list.Add(nhanVien as NhanVien);
                        continue;
                    }
                    else if(a[i]=="1")
                    {
                        KiemChungVien nhanVien = new KiemChungVien();
                        DocThongTin(admin,nhanVien, list, a, ref i);
                        nhanVien.setSoLoi(int.Parse(a[i++]));
                        nhanVien.setTienThuong(double.Parse(a[i]));
                        list.Add(nhanVien as NhanVien);
                    }
                }
                
            }
            
            XacThuc(admin,list);
        }
    }
}
