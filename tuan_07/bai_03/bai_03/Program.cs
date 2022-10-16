using System;

namespace bai_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D poin = new Point3D();
            poin.setXYZ(5, 6, 7) ;
            Console.Write(poin.toString());
            Console.ReadKey();
        }
    }
}
