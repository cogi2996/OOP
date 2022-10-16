using System;

namespace Bai_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(5, "blue", false);
            sq.setSide(5);
            Console.WriteLine($"{sq.getPerimeter()}");
        }
    }
}
