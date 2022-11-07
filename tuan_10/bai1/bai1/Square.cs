using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    public class Square : Rectangle
    {
        public Square() { }
        public Square (double side)
        {
            base.setLength(side) ;
            base.setWidth(side) ;
        }
        public Square(double side,string color, Boolean filled) 
        {
            base.setLength(side);
            base.setWidth(side);
            base.setColor(color);
            base.setFilled(filled);
        }
        public double getSide()
        {
            return base.getLength();
        }
        public void setSide(double side)
        {
            base.setLength(side);
            base.setWidth(side);
        }
        public override string toString()
        {
            return $" Square has side ={getLength()}, color = {getColor()}, filled = {isFilled()}";
        }
    }
}
