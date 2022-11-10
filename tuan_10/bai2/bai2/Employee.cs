using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    public abstract class Employee
    {
        private int empCode;
        private string firstName;
        private string lastName;
        public Employee()
        {
            firstName = "";
            lastName = "";
        }
        public Employee(int empCode, string firstName, string lastName)
        {
            this.empCode = empCode;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void setEmpCode(int empCode)
        {
            this.empCode = empCode;
        }
        public int getEmpCode()
        {
            return empCode;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string getlastName()
        {
            return lastName;
        }
        abstract public double pay() ;
        public virtual string  toString()
        {
            string kq = $"Name :{lastName} {firstName}\nempCode: {empCode}\n";
            return kq;
        }
      
    }
}
