using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_01
{
    public class Rectangle:Shape
    {
        private double width = 1.0;
        private double length = 1.0;
        public Rectangle()
        {

        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length ;
        }
        public Rectangle( double width, double length, string color, Boolean filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        

        public double getWidth()
        {
            return width;
        }
        public void setWidth(double width) {
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
        public double getArea()
        {
            return width * length;
        }
        public double getPerimeter()
        {
            return 2 * (width + length);
        }
        public new string toString()
        {
            return $" Hinh chu nhat voi chieu rong = {getWidth()}, dai = {getLength()} -  {base.toString()}";
        }
    }
}
