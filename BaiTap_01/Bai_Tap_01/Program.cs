using System;

namespace Bai_Tap_01
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;
        public int getHour()
        {
            return this.hour;
        }
        public Time(int hour = 0,int minute = 0,int second = 0)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
       
        public int getMinute()
        {
            return this.minute;
        }
        public int getSecond()
        {
            return this.second;
        }
        public void setHour(int hour)
        {
            if (hour<= 0 || hour <= 23)
                this.hour = hour;
            else
                Console.WriteLine("Hour chi nam trong pham vi tu 0 den 23");
        }
        public void setMinute(int minute)
        {
            if (minute <= 0 || minute<= 59)
                this.minute = minute;
            else
                Console.WriteLine("Minute chi nam trong pham vi tu 0 den 59");
        }
        public void setSecond(int second)
        {
            if (hour <= 0 || hour <= 59)
                this.second = second;
            else
                Console.WriteLine("Second chi nam trong pham vi tu 0 den 59");
        }
        public void setTime(int hour,int minute,int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public string toString()
        {
            int hr = this.hour;
            int mn = this.minute;
            int sc = this.second;
            int[] Times = { hr, mn ,sc};
            string kq ="";
            foreach(int time in Times)
            {
                string timeStr = time.ToString();
                if(time < 10 && time >=0)
                {
                    timeStr = '0' + timeStr;
                }
                kq = kq + ':' + timeStr ;
            }
            return kq;
        }
        public Time nextSecond()
        {
            int hr = this.hour, sc = this.second, mn = this.minute;
            Time timeNext = new Time();
            int totalMsTimeNext = hr * 60 * 60 + mn * 60 + sc + 1;
            timeNext.setHour(totalMsTimeNext/60/60);
            timeNext.setMinute(totalMsTimeNext/60%60);
            timeNext.setSecond(totalMsTimeNext%60);
            return timeNext;
        }
        public Time previousSecond()
        {
            int hr = this.hour, sc = this.second, mn = this.minute;
            Time timeNext = new Time();
            int totalMsTimeNext = hr * 60 * 60 + mn * 60 + sc -1;
            if(totalMsTimeNext == -1)
            {
                timeNext.minute = timeNext.second = 59;
                timeNext.hour = 23;
                return timeNext;
            }
            timeNext.setHour(totalMsTimeNext / 60 / 60);
            timeNext.setMinute(totalMsTimeNext / 60 % 60);
            timeNext.setSecond(totalMsTimeNext % 60);
            return timeNext;

        }
    }
    class Program
    {
            
        static void Main(string[] args)
        {
            Time testTime = new Time();

            int hour , minute = 0, second  = 0;

            Console.WriteLine("Nhap gio: ");
            hour =Convert.ToInt32(Console.ReadLine());
            testTime.setHour(hour);
            minute = Convert.ToInt32(Console.ReadLine());
            testTime.setMinute(minute);
            second = Convert.ToInt32(Console.ReadLine());
            testTime.setSecond(second);
            Console.WriteLine("Gio hien tai: " + testTime.toString());
            Time next1sTime = testTime.nextSecond();
            Time prev1sTime = testTime.previousSecond();
            Console.WriteLine($"Thoi gian tiep theo sau 1s: {next1sTime.toString()} ");
            Console.WriteLine($"Thoi gian truoc do 1s: {prev1sTime.toString()} ");
        }
    }
}
