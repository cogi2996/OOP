using System;

namespace bai_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder[] cylin;
            cylin = new Cylinder[3];
            int i = 0;
            double radius;
            radius = 3.0;
            cylin[i] = new Cylinder();
            cylin[0].setRadius(3.0);
            Console.WriteLine("hello");
            //cylin[i].setHeight(height);
            //cylin[i].setColor(color);
          
        }
    }
}
