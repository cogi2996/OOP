using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    public class Circle:Shape
    {
        private double radius;
        public Circle()
        {
            radius = 0.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius,string color,Boolean filled):base(color,filled)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return 3.14 * radius * radius;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public override double getPerimeter()
        {
            return 2 * 3.14 * radius;
        }
        public override string toString()
        {
            return$"Circle has color = {getColor()} filled = {isFilled()} and radius = {radius}";
        }
    }
}
