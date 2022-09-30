using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_03
{
    class MyPoint
    {
        private int x;
        private int y;
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }

        }
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }

        }
        public MyPoint()
        {
            this.x = 0;
            this.y = 0;
        }
        public string  toString()
        {
            return $"({this.x},{this.y})";
        }
    //    public static double  distance(MyPoint point1,MyPoint point2)
    //    {
    //        double dis;
    //        dis = Math.Sqrt(Math.Pow(point1.x - point2.x, 2) + Math.Pow(point1.y - point2.y, 2));
    //        return dis;
    //    }
    }
}
