using System;
using System.Collections.Generic;
using System.Text;

namespace bai_02
{
    class Circle
    {
        private double radius;
        private string color;
        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle( double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius; 
        }
        public string getColor()
        {
            return this.Color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea()
        {
            return 3.14 * this.radius* this.radius;
        }
        public string toString()
        {
            string kq;
            kq = $"Circle[{this.radius},{this.color}]";
            return kq;
        }
    }
  
}
