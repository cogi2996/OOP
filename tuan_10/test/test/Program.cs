using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle("blue","yes",3);
            Console.WriteLine(circle.ChuVi());
        }
    }
}
