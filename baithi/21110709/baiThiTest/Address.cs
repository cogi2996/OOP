using System;
using System.Collections.Generic;
using System.Text;

namespace baiThiTest
{
    public class Address
    {
        private string street;
        private string ward;
        private string city;
        public Address(string street, string ward, string city)
        {
            this.street = street;
            this.ward = ward;
            this.city = city;
        }
        public string toString()
        {
            return $"Street:{street}\nWard: {ward}\nCity: {city}";
        }

    }
}
