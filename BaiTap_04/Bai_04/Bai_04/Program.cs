using System;

namespace Bai_04
{
    class Program
    {
        
        static void Main(string[] args)
        {
            void Render()
            {
                Nhap();
                ThongKeBaoHanh();
                thongKeXuatXu();
                InSoLuong();

            }
            Console.WriteLine("Nhap so luong may tinh ");
            int sl = int.Parse(Console.ReadLine());
            Computer.SetSoLuongMay(sl);

            Computer[] cpList= new Computer[sl];
            void Nhap()
            {
                for(int i = 0; i < sl; i++)
                {
                    string loaiMay, noiSx;
                    int timeBaoHanh;
                    Console.WriteLine("Nhap ten loai may: ");
                    loaiMay = Console.ReadLine();
                    Console.WriteLine("Nhap noi san xuat: ");
                    noiSx = Console.ReadLine();
                    Console.WriteLine("Nhap thoi gian bao hanh: ");
                    timeBaoHanh= int.Parse(Console.ReadLine());
                 
                    cpList[i] = new Computer(loaiMay, noiSx, timeBaoHanh);
                }
            }
            void ThongKeBaoHanh()
            {
                int sl1Nam = 0;
                foreach(Computer cp  in cpList)
                {
                    if (cp.ThoiGian == 1)
                        sl1Nam++;
                }
                if (sl1Nam > 0)
                    Console.WriteLine("Co {0} may tinh co thoi han bao hanh 1 nam.", sl1Nam);
                else
                {
                    Console.WriteLine("Khong co may tinh nao co thoi han bao hanh la 1 nam.");
                }
            }
            void thongKeXuatXu()
            {
                int slMay = 0;
                
                foreach(Computer cp in cpList)
                {
                    string name = cp.NoiSanXuat.ToLower();
                    if(name[0] == 'm' &&( name[1] == 'i' || name[1] == 'y'))
                    {
                        slMay++;
                    }
                }
                if (slMay > 0)
                    Console.WriteLine("Co {0} may tinh co xuat xu tu My", slMay);
                else
                    Console.WriteLine("Khong co may tinh nao co xuat xu tu My");
            }
            void InSoLuong()
            {
                Console.WriteLine("So luong may tinh: "+ Computer.GetSoLuongMay());
            }


            Render();

            
            
        }
    }
}
