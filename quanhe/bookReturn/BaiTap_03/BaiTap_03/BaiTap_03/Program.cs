using System;

namespace BaiTap_03
{
    class Program
    {
        static void Main(string[] args)
        {
            void render()
            {
                nhap();
                Console.WriteLine("here");
                ktra();
            }
            MyCircle[] mc;
            void nhap()
            {
                Console.WriteLine("Nhap so luong cac phan tu: ");
                int sl = int.Parse(Console.ReadLine());
                mc = new MyCircle[sl];
                //mc[0] = new MyCircle(1,1,1);
                Console.WriteLine(mc[0].getCenterX());
               //for(int i= 0; i < sl; i++)
               //{
               //    int x, y, radi;
               //    Console.WriteLine("May so {0}: ", i+1);
               //    Console.WriteLine("Nhap toa do tam X");
               //    x = int.Parse(Console.ReadLine());
               //    Console.WriteLine("Nhap toa do tam Y");
               //    y = int.Parse(Console.ReadLine());
               //    Console.WriteLine("Nhap ban kinh hinh tron");
               //    radi = int.Parse(Console.ReadLine())
               //    mc[i] = new MyCircle(x,y,radi);
               //    Console.WriteLine("-----------------------------------------------");
               //}
                
            }
            void ktra()
            {
                foreach(MyCircle circle in mc)
                {
                    if (circle.getArea() >= 100)
                        xuat(circle);
                }
            }
            void xuat(MyCircle circle)
            {
              //  Console.WriteLine(circle.toString());
            }

            render();
        }
    }
}
