using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    abstract class Shape
    {
        private string filled;
        private string color;
        public Shape()
        {
            filled = "false";
            color = "white";
        }
        public Shape(string color, string filled)
        {
            this.filled = filled;
            this.color = color;
        }
        public abstract string toString();
        public abstract double DienTich();
        public abstract double ChuVi();
    }
}
