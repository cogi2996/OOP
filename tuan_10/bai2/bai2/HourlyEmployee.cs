using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    public class HourlyEmployee : Employee
    {
        private double rate;
        private double workingHoures;
        public HourlyEmployee(double rate, double workingHoures,int empCode,string firstName,string lastName):base(empCode,firstName,lastName)
        {
            this.rate = rate;
            this.workingHoures = workingHoures;
        }
        public double getRate()
        {
            return rate;
        }
        public void setRate(double rate)
        {
            this.rate = rate;
        }
        public void setWorkingHoures(double workingHoures)
        {
            this.workingHoures = workingHoures;
        }
        public double getWrokingHoures()
        {
            return workingHoures;
        }
        public override double pay()
        {
            return getRate() * getWrokingHoures();
        }
        public override string toString()
        {
            return base.toString() +"Pay:" + pay().ToString();
        }
    }
}
