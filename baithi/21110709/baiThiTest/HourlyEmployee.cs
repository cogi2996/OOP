using System;
using System.Collections.Generic;
using System.Text;

namespace baiThiTest
{
    public class HourlyEmployee:Person
    {
        private double hourSalary;
        private int totalHour;
        public HourlyEmployee(double hourSalary, int totalHour, string firstName, string lastName, string street, string ward, string city) : base(firstName, lastName, street, ward, city)
        {
            this.hourSalary = hourSalary;
            this.totalHour = totalHour;
        }
        public override double pay()
        {
            return hourSalary * totalHour;
        }
        public override string toString()
        {
            return base.toString()+$"\nhourSalary:{pay().ToString()}";
        }
    }
}
