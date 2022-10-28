using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Circle : Shape
    {
        private double radius;
        public double Radius
        { 
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public override string toString()
        {
            return $"Circle co radius = {radius}";
        }
        public override double ChuVi()
        {
            return Math.PI * 2 * radius;
        }
        public override double DienTich()
        {
            return Math.PI * radius * radius;
        }
        public Circle(string color, string filled , double radius) : base(color,filled)
        {
            this.radius = radius;
        }

    }
}
