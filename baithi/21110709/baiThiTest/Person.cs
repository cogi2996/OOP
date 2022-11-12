using System;
using System.Collections.Generic;
using System.Text;

namespace baiThiTest
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private Address address;
        public static int countOfPerson;
        public Person(string firstName, string lastName, string street, string ward, string city)
        {
            countOfPerson++;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = new Address(street, ward, city);
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public void setHome(string street, string ward, string city)
        {
            address = new Address(street, ward, city);  
        }
        public virtual string toString()
        {
            return $"First name: {firstName}\nLast name: {lastName}\nAddress:\n{address.toString()}";
        }
        public abstract double pay();
    }
}
