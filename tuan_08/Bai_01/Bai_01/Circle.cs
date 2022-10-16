using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_01
{
    public class Circle:Shape
    {
        private double radius= 1.0;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius,string color,Boolean filled) : base (color,filled)
        {
            this.radius = radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public double getArea()
        {
            return Math.PI * radius * radius;
        }
        public double getPerimeter()
        {
            return 2 * Math.PI*radius;
        }
        public new string toString()
        {
            return $"La hinh tron co radius = {radius}  voi {base.toString()}";
            
        }

    
    }
}
