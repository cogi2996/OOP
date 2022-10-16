using System;
using System.Collections.Generic;
using System.Text;

namespace bai_03
{
    public class Point3D : Point20
    {
        private float z;
        public float Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        public Point3D(float x, float y, float z):base(x,y)
        {
            this.z = z;
        }
        public Point3D()
        {
            this.z = 0.0f;
        }
        public float getZ()
        {
            return z;
        }
        public void setZ(float z)
        {
            this.z = z;
        }
        public void setXYZ ( float x, float y, float z)
        {
            base.setXY(x, y);
            this.z = z;
        }
        public float[] getXYZ()
        {
            float[] list = new float[3];
            list[0] = this.getX();
            list[1] = this.getY();
            list[2] = this.z;
            return list;
        }
        public new string toString()
        {
            return $"({toString()},z = {z})";
        }
    }
}
