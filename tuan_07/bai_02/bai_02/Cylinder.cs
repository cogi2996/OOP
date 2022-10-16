using System;
using System.Collections.Generic;
using System.Text;

namespace bai_02
{
    class Cylinder:Circle
    {
        private double height;
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public Cylinder()
        {
            this.height = 1.0;    
        }
        public Cylinder(double radius) {
            base.Radius = radius; 
        }
        public Cylinder(double radius, double height)  {
            base.Radius = radius;
            this.height = height;
        }
        public Cylinder(double radius, double height, string color)
        {
            base.Radius = radius;
            this.height = height;
            base.Color = color;
        }
        public double getHeight()
        {
            return this.height;

        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            return base.getArea() * getHeight();
        }

            
    }
}
