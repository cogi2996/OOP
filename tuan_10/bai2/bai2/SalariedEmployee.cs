using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    public class SalariedEmployee: Employee
    {
        private double commisionRate;
        private double grossSales;
        private double basic;
        public SalariedEmployee(double commisionRate, double grossSales, double basic,int empCode, string firstName, string lastName) : base(empCode, firstName, lastName)
        {
            this.commisionRate = commisionRate;
            this.grossSales = grossSales;
            this.basic = basic;
        }
        public double getCommissionRate()
        {
            return commisionRate;
        }
        public void setCommissionRate(double commisionRate)
        {
            this.commisionRate = commisionRate;
        }
        public double getgrossSales()
        {
            return grossSales;
        }
        public void setgrossSales(double grossSales)
        {
            this.grossSales = grossSales;
        }
        public double getBasic()
        {
            return basic;
        }
        public void setBasic(double basic)
        {
            this.basic= basic;
        }
        public override double pay()
        {
            return getBasic() + getCommissionRate() + getgrossSales();
        }


    }
}
