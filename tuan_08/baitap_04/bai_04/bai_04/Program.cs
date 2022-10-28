using System;

namespace bai_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so luong oto");

            OTO[] o = new OTO[int.Parse(Console.ReadLine())];
            OTO.nhap(o);
            OTO.xuat(o);
        }
    }
}
