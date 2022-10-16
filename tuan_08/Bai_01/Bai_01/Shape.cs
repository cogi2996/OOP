using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_01
{
    public class Shape
    {
        private string color;
        private bool filled;
        public Shape()
        {
            color = "red";
            filled = true;
        }
        public Shape(string color,Boolean filled)
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
        public Boolean isFilled()
        {
            return filled;
        }
        public void setFilled ( Boolean filled)
        {
            this.filled = filled;
        }
        public string toString()
        {
            return $"color = {color}, filled : {((this.filled ==true)? "filled" : "nofilled")}" ;
        }
    }
}
