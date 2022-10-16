using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_01
{
    public class Square: Rectangle
    {
        private double side = 1.0;
        public Square() { }
        public Square(double side):base(side,side)
        {
        }
        public Square(double side,string color,Boolean filled):base(side,side,color,filled)
        {
            
        }
        public double getSide()
        {
            return base.getWidth();
        }
        public void setSide(double side)
        {
            base.setWidth(side);
            base.setLength(side);
        }
       
        public new string toString()
        {
            return $"la hinh vuong side = {base.getWidth()},{base.toString()}";
        }

    }
}
