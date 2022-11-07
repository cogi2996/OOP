using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    abstract public class Shape
    {
        private string color;
        private Boolean filled;
        public Shape()
        {
            color = "red";
            filled = true;
        }
        public Shape(string color, Boolean filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public Boolean isFilled ()
        {
            return filled = true;
        }
        public void setFilled(Boolean filled)
        {
            this.filled = filled;
        }
       
        abstract public double getArea();
        abstract public double getPerimeter();
        abstract public string toString();

    }
}
