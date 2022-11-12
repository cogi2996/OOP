using System;
using System.Collections.Generic;
using System.Text;

namespace baiThiTest
{
    public class SalariedEmployee : Person
    {
        private double basicSalary;
        private float rate;
        public SalariedEmployee(double basicSalary, float rate, string firstName, string lastName, string street, string ward, string city):base(firstName,lastName,street, ward, city)
        {
            this.basicSalary = basicSalary;
            this.rate = rate;
        }
        public override double pay()
        {
            return basicSalary * rate;
        }
        public override string toString()
        {
            return base.toString() + $"\nSalariedEmployee :{pay().ToString()}";
        }

    }
}
