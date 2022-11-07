using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    public class Rectangle: Shape
    {
        private double width;
        private double length;
        public Rectangle()
        {
            width = 0.0;
            length = 0.0;
        }
        public Rectangle(double width, double length)
        {
            this.width = width ;
            this.length = length;
        }
        public Rectangle(double width, double length,string color, Boolean filled):base(color,filled)
        {
            this.width = width;
            this.length = length;
        }
        public double getWidth()
        {
            return width;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getLength()
        {
            return length;
        }
        public void setLength(double length)
        {
            this.length = length;
        }
        public override double getArea()
        {
            return width * length;
        }
        public override double getPerimeter()
        {
            return 2 * (width + length);
        }
        public override string toString()
        {
            return $"Rectangle has widht = {width}, lenght = {length}";
        }



    }
}
