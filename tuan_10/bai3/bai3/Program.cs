using System;
using System.Collections;
namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList employee = new ArrayList();
            int n;
            Console.WriteLine("Nhap so luong nhan vien cong ty: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine("Chose 1 : san xuat\nCHose 2: van phong ");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    NhanVienSanXuat nv = new NhanVienSanXuat();
                    nv.Nhap();
                    employee.Add(nv);
                }
                if(choice == 2)
                {
                    NhanVienVanPhong nv = new NhanVienVanPhong();
                    nv.Nhap();
                    employee.Add(nv);
                }
            }
            Console.WriteLine(employee[0].ToString());

        }

    } 
}
