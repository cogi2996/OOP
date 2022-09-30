using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_03
{
    class MyCircle
    {
        private MyPoint center;
        private int radius;
        public MyCircle()
        {
            this.center.X = 0;
            this.center.Y = 0;
            this.radius = 1;
        }
        public MyCircle(int x,int y,int radius)
        {
            this.center.X = x;
            this.center.Y = y;
            this.radius = radius;
        }
    //    public MyCircle(MyPoint center,int radius)
    //    {
    //        this.center = center;
    //        this.radius = radius;
    //    }
    //    public int getRadius()
    //    {
    //        return radius;
    //    }
    //    public void SetRadius(int radius)
    //    {
    //        this.radius = radius;
    //    }
    //    public MyPoint getCenter()
    //    {
    //        return this.center;
    //    }
    //    public void setCenter(MyPoint center)
    //    {
    //        this.center = center;
    //    }
        public int getCenterX()
        {
            return this.center.X;
        }
    //    public void setCenterX(int x)
    //    {
    //        this.center.X = x; 
    //    }
    //    public int getCenterY()
    //    {
    //        return this.center.Y;
    //    }
    //    public void setCenterY(int y)
    //    {
    //        this.center.Y = y;
    //    }
    //    public int[] getCenterXY()
    //    {
    //        int[] x ;
    //        x = new int[2];
    //        x[0] = this.center.X;
    //        x[1] = this.center.Y;
    //        return x;
    //    }
    //    public void setCenterXY(int x,int y)
    //    {
    //        this.center.X = x;
    //        this.center.Y = y;
    //    }
    //    public string toString()
    //    {
    //        return $"MyCircle[radius = {this.radius}, center = {center.toString()}";
    //    }
        public double getArea()
        {
            int R = this.radius;
            double area;
            area = 3.14 * R * R;
            return area;
        }
    //    public double getCircumference()
    //    {
    //        int R = this.radius;
    //        double circum;
    //        circum = 3.14 * 2 * R;
    //        return circum;
    //    }
    //    public double distance(MyCircle another)
    //    {
    //        return MyPoint.distance(this.center, another.center);
    //    }


    }
}
