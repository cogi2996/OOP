using System;
using System.Collections.Generic;
using System.Text;

namespace bai_03
{
    public class Point20
    {
        private float x ;
        private float y;
        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        
        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
      
        public Point20()
        {
            x = 0.0f;
            y = 0.0f;
        }
        public Point20(float x,float y)
        {
            this.x = x;
            this.y = y;
        }
        public float getX()
        {
            return this.x;
        }
        public void setX(float x)
        {
            this.x = x;
        }
        public float getY()
        {
            return this.y;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public void setXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] getXY()
        {
            float[] list = new float[2];
            list[0] = this.x;
            list[1] = this.y;
            return list;
        } 
        public string toString()
        {
            return $"x = {x},y = {y}";
        }

    }
}
